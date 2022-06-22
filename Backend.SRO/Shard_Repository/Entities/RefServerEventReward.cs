using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefServerEventReward
    {
        public RefServerEventReward()
        {
            #region Generated Constructor
            OwnerRefServerEventRewardExpUPForPlayers = new HashSet<RefServerEventRewardExpUPForPlayers>();
            OwnerRefServerEventRewardSpawnMonsters = new HashSet<RefServerEventRewardSpawnMonster>();
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int RewardID { get; set; }

        public int OwnerServerEventID { get; set; }

        public int RefRewardID { get; set; }

        public byte Quantity { get; set; }

        public byte RewardClass { get; set; }

        public byte MasterReward { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<RefServerEventRewardExpUPForPlayers> OwnerRefServerEventRewardExpUPForPlayers { get; set; }

        public virtual ICollection<RefServerEventRewardSpawnMonster> OwnerRefServerEventRewardSpawnMonsters { get; set; }

        public virtual RefServerEvent OwnerServerEventRefServerEvent { get; set; }

        #endregion

    }
}
