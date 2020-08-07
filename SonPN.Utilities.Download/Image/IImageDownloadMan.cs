using System;
using System.Threading.Tasks;

namespace SonPN.Utilities.Download.Image
{
    public interface IImageDownloadMan
    {
        Task DownloadImageAsync(string directoryPath, string fileName, Uri uri);
    }
}