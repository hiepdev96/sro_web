using System;
using System.Collections.Generic;

namespace VsroLog.Log_Repository.Entities
{
    public partial class LogServerEvent
    {
        public LogServerEvent()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime EventTime { get; set; }

        public int ServerEventID { get; set; }

        public byte LogType { get; set; }

        public string StrDesc { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
