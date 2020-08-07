using NLog;
using SonPN.Utilities.Download.Excel;
using SonPN.Utilities.Download.Image;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SonPN.Utilities.Download
{
    public class DownloadMain
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        private string _localFolder;
        public DownloadMain(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void Execute(string excelFile, string localFolder, int uriIndex, int nameIndex, double maxThread)
        {
            try
            {
                _logger.Trace($"Invoked with argument {excelFile}, {uriIndex}, {nameIndex}, {maxThread}");
                _localFolder = localFolder;
                int toProcess = (int) maxThread;


                Collection<NwImage> images = new ExcelHandle(uriIndex, nameIndex).ReadFile(excelFile);
                double imagePerThread = Math.Floor(images.Count / maxThread);
                _logger.Trace($"Calculate number of image per thread is {imagePerThread}");

                using (ManualResetEvent resetEvent = new ManualResetEvent(false))
                {
                    for (int i = 0; i < maxThread; i++)
                    {
                        double countTemp = imagePerThread;

                        if (i + 1 == (int)maxThread)
                        {
                            countTemp = images.Count - imagePerThread * i;
                        }

                        ThreadPool.QueueUserWorkItem(item =>
                        {
                            DownloadThread(item);

                            // ReSharper disable AccessToDisposedClosure
                            if (Interlocked.Decrement(ref toProcess) == 0) resetEvent.Set();
                            // ReSharper disable AccessToDisposedClosure

                        }, images.ToList().GetRange((int)(i * imagePerThread), (int)countTemp));
                    }

                    resetEvent.WaitOne();
                }
            }
            catch (Exception e)
            {
                _logger.Error(e, $"Exception when execute with argument file: {excelFile}, Uri index: {uriIndex}, name index: {nameIndex}, maxthread: {maxThread}");
                throw;
            }
        }

        private void DownloadThread(object nwImages)
        {
            List<NwImage> images = new List<NwImage>();
            try
            {
                images = (List<NwImage>) nwImages;
                ImageDownloadMan downloadMan = new ImageDownloadMan(_httpClient);
                foreach (Task temp in images.Select(nwImage => Task.Run(() => downloadMan.DownloadImageAsync(_localFolder, nwImage.Name, new Uri(nwImage.Url)))))
                {
                    temp.Wait();
                }
            }
            catch (Exception e)
            {
                _logger.Error(e, "Exception when try to download image.");
                _logger.Error("Images in error thread are:");
                foreach (NwImage nwImage in images)
                {
                    _logger.Error($"{nwImage.Url}");
                }
            }
        }
    }
}
