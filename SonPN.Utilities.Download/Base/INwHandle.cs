using System.Collections.ObjectModel;

namespace SonPN.Utilities.Download.Base
{
    /// <summary>
    /// Network handler. Top level of any type of download.
    /// </summary>
    public interface INwHandle
    {
        /// <summary>
        /// Get collection of <see cref="NwData"/> from <see cref="NwData.Url"/> and save to <see cref="NwData.LocalPath"/>
        /// </summary>
        /// <param name="colData"></param>
        /// <returns><see cref="HandleResult"/></returns>
        HandleResult GetData(Collection<NwData> colData);
        /// <summary>
        /// Push collection of <see cref="NwData"/> from <see cref="NwData.LocalPath"/> to <see cref="NwData.Url"/>
        /// </summary>
        /// <param name="colData"></param>
        /// <returns><see cref="HandleResult"/></returns>
        HandleResult PushData(Collection<NwData> colData);
    }
}