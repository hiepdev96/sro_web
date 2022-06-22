using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefSiegeQuest
    {
        public RefSiegeQuest()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int QuestID { get; set; }

        public string QuestName { get; set; }

        public byte QuestType { get; set; }

        public byte RewardConditionTargetCount { get; set; }

        public byte IsAccumulation { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
