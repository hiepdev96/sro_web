using System;
using System.Collections.Generic;

namespace VsroLog.Log_Repository.Entities
{
    public partial class LogEventSiegeFortress
    {
        public LogEventSiegeFortress()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int FortressID { get; set; }

        public DateTime EventTime { get; set; }

        public byte EventID { get; set; }

        public int CharID { get; set; }

        public int Data1 { get; set; }

        public int Data2 { get; set; }

        public string StrDesc { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
