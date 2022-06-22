using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class Schedule
    {
        public Schedule()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int ScheduleIdx { get; set; }

        public int ScheduleDefineIdx { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int MainIntervalType { get; set; }

        public int MainIntervalTypeDate { get; set; }

        public byte? SubIntervalDayOfWeek { get; set; }

        public byte? SubIntervalDays { get; set; }

        public byte? SubIntervalWeeks { get; set; }

        public byte? SubIntervalMonths { get; set; }

        public byte? SubIntervalStartTimeHour { get; set; }

        public byte? SubIntervalStartTimeMinute { get; set; }

        public byte? SubIntervalStartTimeSecond { get; set; }

        public int? SubIntervalDurationSecond { get; set; }

        public int? SubIntervalRepititionTerm { get; set; }

        public int? SubIntervalMaintainTime { get; set; }

        public string Param { get; set; }

        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
