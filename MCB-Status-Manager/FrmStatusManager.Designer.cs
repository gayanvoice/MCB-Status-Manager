
using System.Windows.Forms;

namespace MCB_Status_Manager
{
    partial class FrmStatusManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Add IP Address...");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Import Configuration....");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Save Configuration...");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("New Folder...");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Refresh");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Add IP Address...");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Import Configuration....");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Save Configuration...");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("New Folder...");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Refresh");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.ListViewIpAddressMain = new System.Windows.Forms.ListView();
            this.SplitContainerContent = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListViewPortStatusMain = new System.Windows.Forms.ListView();
            this.RichTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.SplitContainerSideBar = new System.Windows.Forms.SplitContainer();
            this.ListViewIpAddress = new System.Windows.Forms.ListView();
            this.PanelIpAddessSideBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewPort = new System.Windows.Forms.ListView();
            this.PanelPortSideBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerContent)).BeginInit();
            this.SplitContainerContent.Panel1.SuspendLayout();
            this.SplitContainerContent.Panel2.SuspendLayout();
            this.SplitContainerContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerSideBar)).BeginInit();
            this.SplitContainerSideBar.Panel1.SuspendLayout();
            this.SplitContainerSideBar.Panel2.SuspendLayout();
            this.SplitContainerSideBar.SuspendLayout();
            this.PanelIpAddessSideBar.SuspendLayout();
            this.PanelPortSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelReady});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelReady
            // 
            this.toolStripStatusLabelReady.Name = "toolStripStatusLabelReady";
            this.toolStripStatusLabelReady.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelReady.Text = "Ready";
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.ListViewIpAddressMain);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.SplitContainerContent);
            this.SplitContainerMain.Size = new System.Drawing.Size(800, 404);
            this.SplitContainerMain.SplitterDistance = 131;
            this.SplitContainerMain.TabIndex = 2;
            // 
            // ListViewIpAddressMain
            // 
            this.ListViewIpAddressMain.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListViewIpAddressMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewIpAddressMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewIpAddressMain.HideSelection = false;
            this.ListViewIpAddressMain.Location = new System.Drawing.Point(0, 0);
            this.ListViewIpAddressMain.Name = "ListViewIpAddressMain";
            this.ListViewIpAddressMain.Size = new System.Drawing.Size(129, 402);
            this.ListViewIpAddressMain.TabIndex = 0;
            this.ListViewIpAddressMain.UseCompatibleStateImageBehavior = false;
            this.ListViewIpAddressMain.View = System.Windows.Forms.View.List;
            this.ListViewIpAddressMain.ItemActivate += new System.EventHandler(this.ListViewIpAddressMain_ItemActivate);
            // 
            // SplitContainerContent
            // 
            this.SplitContainerContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerContent.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerContent.Name = "SplitContainerContent";
            // 
            // SplitContainerContent.Panel1
            // 
            this.SplitContainerContent.Panel1.Controls.Add(this.splitContainer1);
            // 
            // SplitContainerContent.Panel2
            // 
            this.SplitContainerContent.Panel2.Controls.Add(this.SplitContainerSideBar);
            this.SplitContainerContent.Size = new System.Drawing.Size(665, 404);
            this.SplitContainerContent.SplitterDistance = 463;
            this.SplitContainerContent.TabIndex = 0;
            this.SplitContainerContent.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainerContainer_SplitterMoved);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListViewPortStatusMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RichTextBoxLog);
            this.splitContainer1.Size = new System.Drawing.Size(463, 404);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 0;
            // 
            // ListViewPortStatusMain
            // 
            this.ListViewPortStatusMain.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListViewPortStatusMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewPortStatusMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewPortStatusMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewPortStatusMain.HideSelection = false;
            this.ListViewPortStatusMain.Location = new System.Drawing.Point(0, 0);
            this.ListViewPortStatusMain.Name = "ListViewPortStatusMain";
            this.ListViewPortStatusMain.Size = new System.Drawing.Size(461, 151);
            this.ListViewPortStatusMain.TabIndex = 0;
            this.ListViewPortStatusMain.UseCompatibleStateImageBehavior = false;
            this.ListViewPortStatusMain.View = System.Windows.Forms.View.Details;
            this.ListViewPortStatusMain.ItemActivate += new System.EventHandler(this.ListViewPortStatusMain_ItemActivate);
            // 
            // RichTextBoxLog
            // 
            this.RichTextBoxLog.BackColor = System.Drawing.Color.Black;
            this.RichTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxLog.ForeColor = System.Drawing.Color.White;
            this.RichTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.RichTextBoxLog.Name = "RichTextBoxLog";
            this.RichTextBoxLog.Size = new System.Drawing.Size(461, 245);
            this.RichTextBoxLog.TabIndex = 0;
            this.RichTextBoxLog.Text = "";
            // 
            // SplitContainerSideBar
            // 
            this.SplitContainerSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainerSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerSideBar.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerSideBar.Name = "SplitContainerSideBar";
            this.SplitContainerSideBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerSideBar.Panel1
            // 
            this.SplitContainerSideBar.Panel1.Controls.Add(this.ListViewIpAddress);
            this.SplitContainerSideBar.Panel1.Controls.Add(this.PanelIpAddessSideBar);
            this.SplitContainerSideBar.Panel1MinSize = 27;
            // 
            // SplitContainerSideBar.Panel2
            // 
            this.SplitContainerSideBar.Panel2.Controls.Add(this.ListViewPort);
            this.SplitContainerSideBar.Panel2.Controls.Add(this.PanelPortSideBar);
            this.SplitContainerSideBar.Panel2MinSize = 27;
            this.SplitContainerSideBar.Size = new System.Drawing.Size(198, 404);
            this.SplitContainerSideBar.SplitterDistance = 200;
            this.SplitContainerSideBar.SplitterIncrement = 2;
            this.SplitContainerSideBar.TabIndex = 0;
            this.SplitContainerSideBar.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainerSideBar_SplitterMoved);
            // 
            // ListViewIpAddress
            // 
            this.ListViewIpAddress.BackColor = System.Drawing.SystemColors.Window;
            this.ListViewIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewIpAddress.HideSelection = false;
            this.ListViewIpAddress.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.ListViewIpAddress.Location = new System.Drawing.Point(0, 28);
            this.ListViewIpAddress.Name = "ListViewIpAddress";
            this.ListViewIpAddress.Size = new System.Drawing.Size(196, 170);
            this.ListViewIpAddress.TabIndex = 2;
            this.ListViewIpAddress.TileSize = new System.Drawing.Size(168, 35);
            this.ListViewIpAddress.UseCompatibleStateImageBehavior = false;
            this.ListViewIpAddress.View = System.Windows.Forms.View.Tile;
            // 
            // PanelIpAddessSideBar
            // 
            this.PanelIpAddessSideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelIpAddessSideBar.Controls.Add(this.label1);
            this.PanelIpAddessSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelIpAddessSideBar.Location = new System.Drawing.Point(0, 0);
            this.PanelIpAddessSideBar.Name = "PanelIpAddessSideBar";
            this.PanelIpAddessSideBar.Size = new System.Drawing.Size(196, 28);
            this.PanelIpAddessSideBar.TabIndex = 1;
            this.PanelIpAddessSideBar.Click += new System.EventHandler(this.PanelIpAddessSideBar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Addess";
            // 
            // ListViewPort
            // 
            this.ListViewPort.BackColor = System.Drawing.SystemColors.Window;
            this.ListViewPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewPort.FullRowSelect = true;
            this.ListViewPort.HideSelection = false;
            this.ListViewPort.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.ListViewPort.Location = new System.Drawing.Point(0, 30);
            this.ListViewPort.Name = "ListViewPort";
            this.ListViewPort.Size = new System.Drawing.Size(196, 165);
            this.ListViewPort.TabIndex = 3;
            this.ListViewPort.TileSize = new System.Drawing.Size(168, 35);
            this.ListViewPort.UseCompatibleStateImageBehavior = false;
            this.ListViewPort.View = System.Windows.Forms.View.Tile;
            // 
            // PanelPortSideBar
            // 
            this.PanelPortSideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelPortSideBar.Controls.Add(this.label2);
            this.PanelPortSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelPortSideBar.Location = new System.Drawing.Point(0, 0);
            this.PanelPortSideBar.Name = "PanelPortSideBar";
            this.PanelPortSideBar.Size = new System.Drawing.Size(196, 28);
            this.PanelPortSideBar.TabIndex = 2;
            this.PanelPortSideBar.Click += new System.EventHandler(this.PanelPortSideBar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // FrmStatusManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitContainerMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmStatusManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCB Status Manager";
            this.Load += new System.EventHandler(this.FrmStatusManager_Load);
            this.Resize += new System.EventHandler(this.FrmStatusManager_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.SplitContainerContent.Panel1.ResumeLayout(false);
            this.SplitContainerContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerContent)).EndInit();
            this.SplitContainerContent.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SplitContainerSideBar.Panel1.ResumeLayout(false);
            this.SplitContainerSideBar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerSideBar)).EndInit();
            this.SplitContainerSideBar.ResumeLayout(false);
            this.PanelIpAddessSideBar.ResumeLayout(false);
            this.PanelIpAddessSideBar.PerformLayout();
            this.PanelPortSideBar.ResumeLayout(false);
            this.PanelPortSideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelReady;
        private System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.SplitContainer SplitContainerContent;
        private System.Windows.Forms.ListView ListViewPortStatusMain;
        private System.Windows.Forms.SplitContainer SplitContainerSideBar;
        private System.Windows.Forms.Panel PanelIpAddessSideBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelPortSideBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListViewIpAddress;
        private System.Windows.Forms.ListView ListViewPort;
        private ListView ListViewIpAddressMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private SplitContainer splitContainer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox RichTextBoxLog;
    }
}

