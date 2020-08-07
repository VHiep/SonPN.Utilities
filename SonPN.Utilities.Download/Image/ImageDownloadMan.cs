using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NLog;

namespace SonPN.Utilities.Download.Image
{
    public class ImageDownloadMan:IImageDownloadMan, IDisposable
    {
        private bool _disposed;
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        public ImageDownloadMan(HttpClient httpClient = null)
        {
            _httpClient = httpClient ?? new HttpClient();
        }
        public async Task DownloadImageAsync(string directoryPath, string fileName, Uri uri)
        {
            try
            {
                _logger.Trace($"Invoked with agument {directoryPath}, {fileName}, {uri}");
                // For SSL/TLS secure.
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                if (_disposed) { throw new ObjectDisposedException(GetType().FullName); }

                // Create file path and ensure directory exists
                Directory.CreateDirectory(directoryPath);
                string path = Path.Combine(directoryPath, string.IsNullOrEmpty(fileName) ?
                    uri.GetLeftPart(UriPartial.Path) :
                    $"{fileName}{Path.GetExtension(uri.GetLeftPart(UriPartial.Path))}");

                // Download the image and write to the file
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    byte[] imageBytes = await _httpClient.GetByteArrayAsync(uri);
                    await stream.WriteAsync(imageBytes, 0, imageBytes.Length);
                }
            }
            catch (Exception e)
            {
                _logger.Error(e, $"Exception when get image from uri {uri}");
                throw;
            }
        }

        public void Dispose()
        {
            if (_disposed) { return; }
            
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
            
            _disposed = true;
        }
    }
}