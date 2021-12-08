using MCB_Status_Manager.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using MCB_Status_Manager.Helper;

namespace MCB_Status_Manager
{
    public partial class FrmStatusManager : Form
    {
        Settings settings;
        CancellationTokenSource cancellationTokenSource;
        FileHelper fileHelper;
        DataModal data;
        public FrmStatusManager()
        {
            InitializeComponent();
            settings = new Settings();
            fileHelper = new FileHelper();
            data = new DataModal();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.Cancel();
        }
        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ResizePanelInActions();

        }
        private void SplitContainerContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ResizePanelInActions();
        }
        private void ResizePanelInActions()
        {
            PanelIpAddessSideBar.Width = SplitContainerSideBar.Width;

            ListViewIpAddress.Height = SplitContainerSideBar.SplitterDistance - 28;
            ListViewIpAddress.Width = SplitContainerSideBar.Width;

            ListViewPort.Height = SplitContainerSideBar.Height - (SplitContainerSideBar.SplitterDistance - 28);
            ListViewPort.Width = SplitContainerSideBar.Width;

            PanelPortSideBar.Width = SplitContainerSideBar.Width;
        }

        //private void ListViewPortStatus_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        //{


        //    //Caching is not required but improves performance on large sets.
        //    //To leave out caching, don't connect the CacheVirtualItems event 
        //    //and make sure myCache is null.

        //    //check to see if the requested item is currently in the cache
        //    if (listViewItem != null && e.ItemIndex >= firstItem && e.ItemIndex < firstItem + listViewItem.Length)
        //    {
        //        //A cache hit, so get the ListViewItem from the cache instead of making a new one.
        //        e.Item = listViewItem[e.ItemIndex - firstItem];
        //    }
        //    else
        //    {
        //        //A cache miss, so create a new ListViewItem and pass it back.
        //        int x = e.ItemIndex * e.ItemIndex;
        //        e.Item = new ListViewItem(x.ToString());
        //    }
        //}

        //Manages the cache.  ListView calls this when it might need a 
        //cache refresh.
        //private void ListViewPortStatus_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e)
        //{
        //    //We've gotten a request to refresh the cache.
        //    //First check if it's really neccesary.
        //    if (listViewItem != null && e.StartIndex >= firstItem && e.EndIndex <= firstItem + listViewItem.Length)
        //    {
        //        //If the newly requested cache is a subset of the old cache, 
        //        //no need to rebuild everything, so do nothing.
        //        return;
        //    }

        //    //Now we need to rebuild the cache.
        //    firstItem = e.StartIndex;
        //    int length = e.EndIndex - e.StartIndex + 1; //indexes are inclusive*/
        //    listViewItem = new ListViewItem[length];

        //    //Fill the cache with the appropriate ListViewItems.
        //    int x = 70;
        //    for (int i = 0; i < length; i++)
        //    {
        //        x++;
        //        ListViewItem item = new ListViewItem(x.ToString());
        //        item.SubItems.Add("TCP");
        //        item.SubItems.Add("CONNECTED");
        //        item.SubItems.Add(DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
        //        item.SubItems.Add("LOCALRPSSERVER");
        //        item.SubItems.Add("1/23/2016 2:18:03 PM");
        //        item.SubItems.Add("5/23/2016 5:18:03 PM");

        //        //x = (i + firstItem) * (i + firstItem);
        //        listViewItem[i] = item;


        //    }
        //}

        //This event handler enables search functionality, and is called
        //for every search request when in Virtual mode.
        //void ListViewPortStatus_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        //{
        //    //We've gotten a search request.
        //    //In this example, finding the item is easy since it's
        //    //just the square of its index.  We'll take the square root
        //    //and round.
        //    double x = 0;
        //    if (Double.TryParse(e.Text, out x)) //check if this is a valid search
        //    {
        //        x = Math.Sqrt(x);
        //        x = Math.Round(x);
        //        e.Index = (int)x;
        //    }
        //    //If e.Index is not set, the search returns null.
        //    //Note that this only handles simple searches over the entire
        //    //list, ignoring any other settings.  Handling Direction, StartIndex,
        //    //and the other properties of SearchForVirtualItemEventArgs is up
        //    //to this handler.
        //}

        private async void FrmStatusManager_Load(object sender, EventArgs e)
        {
            await SetDataModalAsync();
            data = await GetDataModal();

            foreach (IpAddressModal ipAddress in data.IpAddress)
            {
                ListViewIpAddressMain.Items.Add(ipAddress.IpAddress);
            }


            ListViewPortStatusMain.Columns.Add("Port").Width = 50;
            ListViewPortStatusMain.Columns.Add("Protocol").Width = 50;
            ListViewPortStatusMain.Columns.Add("State").Width = 100;
            ListViewPortStatusMain.Columns.Add("Last Check").Width = 150;
            ListViewPortStatusMain.Columns.Add("Address").Width = 150;
            ListViewPortStatusMain.Columns.Add("Last DownTime").Width = 150;
            ListViewPortStatusMain.Columns.Add("Create Time").Width = 150;

           

            //Console.WriteLine("22" + await TcpConnectAsync("208.113.182.151", 22));
            //Console.WriteLine("25" + await TcpConnectAsync("208.113.182.151", 25));
            //Console.WriteLine("80" + await TcpConnectAsync("208.113.182.151", 80));
            //Console.WriteLine("587" + await TcpConnectAsync("208.113.182.151", 587));
            //Console.WriteLine("5222" + await TcpConnectAsync("208.113.182.151", 5222));
            //Console.WriteLine("5269" + await TcpConnectAsync("208.113.182.151", 5269));
            //Console.WriteLine("5270" + await TcpConnectAsync("208.113.182.151", 5270));




            






        }



        private async Task<DataModal> GetDataModal()
        {
            FileHelperRequestModal fileHelperRequest = new FileHelperRequestModal();
            fileHelperRequest.Path = "config//data.json";

            FileHelperDataResponseModal fileHelperDataResponse= await fileHelper.ReadDataModalAsync(fileHelperRequest);
            if (fileHelperDataResponse.Status)
            {
                Console.WriteLine($"ReadDataModalAsync TimeElapsed={fileHelperDataResponse.TimeElapsed} Status={fileHelperDataResponse.Status}");
            }
            return fileHelperDataResponse.Data;
        }

        private async Task SetDataModalAsync()
        {
            HostModal host1883 = new HostModal()
            {
                Port = 1883
            };
            HostModal host8069 = new HostModal()
            {
                Port = 8069
            };
            HostModal host22 = new HostModal()
            {
                Port = 22
            };
            HostModal host80= new HostModal()
            {
                Port = 80
            };
            HostModal host443 = new HostModal()
            {
                Port = 443
            };
            HostModal host8443 = new HostModal()
            {
                Port = 8443
            };
            HostModal host7777 = new HostModal()
            {
                Port = 7777
            };
            EmailModal email1001 = new EmailModal()
            {
                To = new List<string> { "user.to1@gmail.com", "user.to2@gmail.com" },
                CC = new List<string> { "user.cc1@gmail.com", "user.cc2@gmail.com", "user.cc3@gmail.com" }
            };
            IpAddressModal ipAddress112195 = new IpAddressModal()
            {
                IpAddress = "61.90.112.195",
                Tag = "FCCM",
                Host = new HostModal[] { host1883 },
                Email = new EmailModal[] { email1001 }
            };
            IpAddressModal ipAddress56171 = new IpAddressModal()
            {
                IpAddress = "27.72.56.171",
                Tag = "CBSKM",
                Host = new HostModal[] { host8069 },
                Email = new EmailModal[] { email1001 }
            };
            IpAddressModal ipAddress199159 = new IpAddressModal()
            {
                IpAddress = "3.237.199.159",
                Tag = "FCCM",
                Host = new HostModal[] { host22, host7777 },
                Email = new EmailModal[] { email1001 }
            };
            IpAddressModal ipAddress199186 = new IpAddressModal()
            {
                IpAddress = "50.230.119.186",
                Tag = "FCCM",
                Host = new HostModal[] { host80, host443, host8443},
                Email = new EmailModal[] { email1001 }
            };
            DataModal data = new DataModal()
            {
                IpAddress = new IpAddressModal[] { ipAddress112195, ipAddress56171, ipAddress199159, ipAddress199186 }
            };

            FileHelperRequestModal fileHelperRequest = new FileHelperRequestModal();
            fileHelperRequest.Object = data;
            fileHelperRequest.Path = "config//data.json";

            FileHelperResponseModal fileHelperResponse = await fileHelper.SaveJsonFileAsync(fileHelperRequest);
            if (fileHelperResponse.Status)
            {
                Console.WriteLine($"SaveJsonFileAsync TimeElapsed={fileHelperResponse.TimeElapsed} Status={fileHelperResponse.Status}");
            }
        }

        //private static async Task<string> GetJson(object obj)
        //{
        //    string json = string.Empty;
        //    using (var stream = new MemoryStream())
        //    {
        //        await JsonSerializer.SerializeAsync(stream, obj, obj.GetType());
        //        stream.Position = 0;
        //        using var reader = new StreamReader(stream);
        //        return await reader.ReadToEndAsync();
        //    }
        //}


        private void FrmStatusManager_Resize(object sender, EventArgs e)
        {
            ResizePanelInActions();
        }
        private void PanelIpAddessSideBar_Click(object sender, EventArgs e)
        {
            if (SplitContainerSideBar.SplitterDistance == 27)
            {
                SplitContainerSideBar.SplitterDistance = SplitContainerSideBar.Height / 2;
            }
            else
            {
                SplitContainerSideBar.SplitterDistance = 27;
            }

        }
        private void PanelPortSideBar_Click(object sender, EventArgs e)
        {
            if (SplitContainerSideBar.SplitterDistance == 27)
            {
                SplitContainerSideBar.SplitterDistance = SplitContainerSideBar.Height / 2;
            }
            else
            {
                SplitContainerSideBar.SplitterDistance = 27;
            }
        }
        private void SplitContainerSideBar_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ResizePanelInActions();
        }
        private async void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cancellationTokenSource = new CancellationTokenSource();
                await PeriodicFooAsync(10000);

            } catch
            {
                RichTextBoxLog.Text += $"{DateTime.Now} Task Cancelled {Environment.NewLine}";
            }
        }

        private void ListViewIpAddressMain_ItemActivate(object sender, EventArgs e)
        {
            int index = ListViewIpAddressMain.SelectedIndices[0];
            //Text = "MCB Status Manager - " + ListViewIpAddressMain.Items[index].Text;


            settings.IpAddress = ListViewIpAddressMain.Items[index].Text;
            settings.Save();

            //Properties.Settings.Default.IpAddress = ListViewIpAddressMain.Items[index].Text;
            //Properties.Settings.Default.Save();


            ListViewPortStatusMain.Items.Clear();

            foreach (HostModal host in data.IpAddress[index].Host)
            {
                ListViewItem item = new ListViewItem(host.Port.ToString());
                item.SubItems.Add("TCP");
                item.SubItems.Add("CONNECTED");
                item.SubItems.Add(DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
                item.SubItems.Add("LOCALRPSSERVER");
                item.SubItems.Add("1/23/2016 2:18:03 PM");
                item.SubItems.Add("5/23/2016 5:18:03 PM");
                ListViewPortStatusMain.Items.Add(item);
            }
        }

        private void ListViewPortStatusMain_ItemActivate(object sender, EventArgs e)
        {
            int index = ListViewPortStatusMain.SelectedIndices[0];

            settings.Host = ListViewPortStatusMain.Items[index].Text;
            settings.Save();

            Text = "MCB Status Manager - IP-" + settings.IpAddress + " PORT-" + settings.Host;

            RichTextBoxLog.Clear();

            RichTextBoxLog.Text = GetLog("log//ip-" + settings.IpAddress + "-p-" + settings.Host + "-log.txt");
        }

        public string GetLog(string path)
        {
            StringBuilder log = new StringBuilder();
            using (StreamReader r = File.OpenText(path))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    log.Append(line + "\n");
                }
            }
            return log.ToString();

        }

        public async Task PeriodicFooAsync(int milliseconds)
        {
            while (true)
            {
                RichTextBoxLog.Text += $"{DateTime.Now} Task Started {Environment.NewLine}";

                System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
                await RunParallelAsync();
                stopwatch.Stop();
                long elapsedMs = stopwatch.ElapsedMilliseconds;

                RichTextBoxLog.Text += $"{DateTime.Now} Total execution time: { elapsedMs } {Environment.NewLine}";
                RichTextBoxLog.Text += $"{DateTime.Now} Task Completed {Environment.NewLine}";
                await Task.Delay(milliseconds, cancellationTokenSource.Token);
            }
        }

        private List<IpPortModal> GetIpPortModalList()
        {
            List<IpPortModal> ipPortModalList = new List<IpPortModal>();
            foreach (IpAddressModal ipAddress in data.IpAddress)
            {
                foreach (HostModal host in ipAddress.Host)
                {
                    IpPortModal ipPort = new IpPortModal();
                    ipPort.Ip = ipAddress.IpAddress;
                    ipPort.Port = host.Port;
                    ipPortModalList.Add(ipPort);
                }
            }
            return ipPortModalList;
        }
        private async Task RunParallelAsync()
        {
            List<Task<IpPortStatusModal>> ipPortStatusTaskList = new List<Task<IpPortStatusModal>>();
            List<IpPortModal> ipPorModaltList = GetIpPortModalList();
            foreach (IpPortModal ipPort in ipPorModaltList)
            {
                ipPortStatusTaskList.Add(TcpConnectAsync(ipPort));
            }
            IpPortStatusModal[] ipPortStatusModalArray = await Task.WhenAll(ipPortStatusTaskList);
            foreach (IpPortStatusModal ipPortStatus in ipPortStatusModalArray)
            {
                ReportWebsiteInfo(ipPortStatus);
            }
        }
        private void ReportWebsiteInfo(IpPortStatusModal ipPortStatus)
        {
            RichTextBoxLog.Text += $"IP: { ipPortStatus.Ip} Port: { ipPortStatus.Port} Status: {ipPortStatus.Status}{ Environment.NewLine }";
        }

        private async Task<IpPortStatusModal> TcpConnectAsync(IpPortModal ipPort)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                IpPortStatusModal ipPortStatus = new IpPortStatusModal();

                try
                {
                    await tcpClient.ConnectAsync(ipPort.Ip, ipPort.Port);

                    ipPortStatus.Ip = ipPort.Ip;
                    ipPortStatus.Port = ipPort.Port;
                    ipPortStatus.Status = true;

                    return ipPortStatus;
                }
                catch (Exception)
                {
                    ipPortStatus.Ip = ipPort.Ip;
                    ipPortStatus.Port = ipPort.Port;
                    ipPortStatus.Status = false;

                    return ipPortStatus;
                }
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //BackgroundWorker worker = sender as BackgroundWorker;


            //while (true)
            //{
            //    if (worker.CancellationPending == true)
            //    {
            //        e.Cancel = true;
            //    }
            //    else
            //    {
            //        foreach (IpAddressModal ipAddress in data.IpAddress)
            //        {
            //            foreach (HostModal host in ipAddress.Host)
            //            {
            //                string status = TcpConnect(ipAddress.IpAddress, host.Port).ToString();
            //                using (StreamWriter w = File.AppendText("log//ip-" + ipAddress.IpAddress + "-p-" + host.Port + "-log.txt"))
            //                {
            //                    Log(ipAddress.IpAddress, host.Port, status, w);
            //                }
            //            }
            //        }
            //        System.Threading.Thread.Sleep(10000);
            //        worker.ReportProgress(10);
            //    }
            //}
        }

        public void Log(string ipAddress, int port, string status, TextWriter w)
        {
            //w.WriteLine($"{DateTime.Now.ToLongTimeString()}\t{DateTime.Now.ToLongDateString()}\t{ipAddress}\t{port}\t{status}");
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //toolStripStatusLabelReady.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (e.Cancelled == true)
            //{
            //    toolStripStatusLabelReady.Text = "Canceled!";
            //}
            //else if (e.Error != null)
            //{
            //    toolStripStatusLabelReady.Text = "Error: " + e.Error.Message;
            //}
            //else
            //{
            //    toolStripStatusLabelReady.Text = "Done!";
            //}
        }
    }
}
