using System;
using System.Collections.Generic;

namespace VsroLog.Log_Repository.Entities
{
    public partial class LogSchedule
    {
        public LogSchedule()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string ServerType { get; set; }

        public int ServerBodyID { get; set; }

        public string ScheduleDefine { get; set; }

        public int ScheduleIdx { get; set; }

        public string Type { get; set; }

        public DateTime OccureTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
