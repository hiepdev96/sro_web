using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefSiegeQuestReward
    {
        public RefSiegeQuestReward()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int QuestID { get; set; }

        public byte RewardType { get; set; }

        public int RewardRefID { get; set; }

        public int RewardValue { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
