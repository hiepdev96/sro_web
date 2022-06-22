using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class CharQuest
    {
        public CharQuest()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public int QuestID { get; set; }

        public byte Status { get; set; }

        public short AchievementCount { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public long QuestData1 { get; set; }

        public long QuestData2 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
