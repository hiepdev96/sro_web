using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefServerEventRewardSpawnMonster
    {
        public RefServerEventRewardSpawnMonster()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int OwnerRewardID { get; set; }

        public int RegionID { get; set; }

        public float PosX { get; set; }

        public float PosY { get; set; }

        public float PosZ { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefServerEventReward OwnerRefServerEventReward { get; set; }

        #endregion

    }
}
