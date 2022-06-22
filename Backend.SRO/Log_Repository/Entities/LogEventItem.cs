using System;
using System.Collections.Generic;

namespace VsroLog.Log_Repository.Entities
{
    public partial class LogEventItem
    {
        public LogEventItem()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public DateTime EventTime { get; set; }

        public int CharID { get; set; }

        public int ItemRefID { get; set; }

        public int DwData { get; set; }

        public byte TargetStorage { get; set; }

        public byte Operation { get; set; }

        public byte SlotFrom { get; set; }

        public byte SlotTo { get; set; }

        public string EventPos { get; set; }

        public string StrDesc { get; set; }

        public long Serial64 { get; set; }

        public long? Gold { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
