using System.Collections.ObjectModel;
using SonPN.Utilities.Download.Excel;

namespace SonPN.Utilities.Download.Base
{
    /// <summary>
    /// Top level any file type to save and get <see cref="NwData"/>
    /// </summary>
    internal interface IFileHandle
    {
        /// <summary>
        /// Read file from path and return collection of <see cref="NwData"/>
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Collection of <see cref="NwData"/></returns>
        Collection<NwImage> ReadFile(string path);
        /// <summary>
        /// Write collection of <see cref="NwData"/> to path
        /// </summary>
        /// <param name="nwData"></param>
        /// <param name="path"></param>
        /// <returns>true if success, false if failure.</returns>
        bool WriteFile(Collection<NwImage> nwData, string path);
    }
}