using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefEvent
    {
        public RefEvent()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Id { get; set; }

        public string CodeName { get; set; }

        public string DescName { get; set; }

        public string ScheduleName { get; set; }

        public int ScheduleCount { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
