using MCB_Status_Manager.Modal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MCB_Status_Manager.Helper
{
    class FileHelper
    {
        public async Task<FileHelperResponseModal> SaveJsonFileAsync(FileHelperRequestModal fileRequest)
        {
            FileHelperResponseModal fileHelperResponse = new FileHelperResponseModal();
            System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();

            await Task.Run(() => {
                string jsonString = JsonSerializer.Serialize(fileRequest.Object);
                File.WriteAllText(fileRequest.Path, jsonString);
            });

            stopwatch.Stop();
            long elapsedMilliSeconds = stopwatch.ElapsedMilliseconds;

            fileHelperResponse.TimeElapsed = elapsedMilliSeconds;
            fileHelperResponse.Status = true;
            return fileHelperResponse;
        }
        public async Task<FileHelperDataResponseModal> ReadDataModalAsync(FileHelperRequestModal fileRequest)
        {
            FileHelperDataResponseModal fileHelperDataResponse = new FileHelperDataResponseModal();
            DataModal data = new DataModal();
            System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
            await Task.Run(() => {
                string jsonString = File.ReadAllText(fileRequest.Path);
                data =  JsonSerializer.Deserialize<DataModal>(jsonString);
            });
            stopwatch.Stop();
            long elapsedMilliSeconds = stopwatch.ElapsedMilliseconds;

            fileHelperDataResponse.Data = data;
            fileHelperDataResponse.TimeElapsed = elapsedMilliSeconds;
            fileHelperDataResponse.Status = true;
            return fileHelperDataResponse;
        }
    }
}
