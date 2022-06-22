using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefServerEventRewardExpUPForPlayers
    {
        public RefServerEventRewardExpUPForPlayers()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int OwnerRewardID { get; set; }

        public int ApplyTime { get; set; }

        public byte ApplyExpRatio { get; set; }

        public byte ApplySExpRatio { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefServerEventReward OwnerRefServerEventReward { get; set; }

        #endregion

    }
}
