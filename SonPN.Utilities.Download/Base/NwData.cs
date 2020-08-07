namespace SonPN.Utilities.Download.Base
{
    /// <summary>
    /// Abstract class Network data. Top level of any type of file from internet
    /// </summary>
    public class NwData
    {
        /// <summary>
        /// Local path to storage file from internet.
        /// eg. D:\Storage
        /// </summary>
        public string LocalPath { get; set; }
        /// <summary>
        /// Link get file from internet.
        /// eg: http://facebook.com/sexy.jpg
        /// </summary>
        public string Url { get; set; }
    }
}