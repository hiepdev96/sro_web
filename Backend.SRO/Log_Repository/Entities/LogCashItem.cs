using System;
using System.Collections.Generic;

namespace VsroLog.Log_Repository.Entities
{
    public partial class LogCashItem
    {
        public LogCashItem()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int RefItemID { get; set; }

        public int CharID { get; set; }

        public short Cnt { get; set; }

        public DateTime EventTime { get; set; }

        public long Serial64 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
