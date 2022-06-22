using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefGameWorld
    {
        public RefGameWorld()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string WorldCodeName128 { get; set; }

        public byte Type { get; set; }

        public short WorldMaxCount { get; set; }

        public short WorldMaxUserCount { get; set; }

        public byte WorldEntryType { get; set; }

        public byte WorldEntranceType { get; set; }

        public byte WorldLeaveType { get; set; }

        public int WorldDurationTime { get; set; }

        public int WorldEmptyRemainTime { get; set; }

        public string ConfigGroupCodeName128 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
