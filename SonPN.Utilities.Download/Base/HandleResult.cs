namespace SonPN.Utilities.Download.Base
{
    public class HandleResult
    {
        /// <summary>
        /// Result of <see cref="INwHandle"/> actions.
        /// </summary>
        /// <param name="status">Status of process</param>
        /// <param name="nwData"><see cref="NwData"/> processed</param>
        public HandleResult(ActionStatus status, NwData nwData)
        {
            Status = status;
            NwData = nwData;
        }
        public ActionStatus Status { get; }
        public NwData NwData { get; }
    }
}