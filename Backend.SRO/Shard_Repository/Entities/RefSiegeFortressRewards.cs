using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefSiegeFortressRewards
    {
        public RefSiegeFortressRewards()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int FortressID { get; set; }

        public byte RewardTypeID { get; set; }

        public int RewardValue { get; set; }

        public byte RewardCount { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefSiegeFortress RefSiegeFortress { get; set; }

        #endregion

    }
}
