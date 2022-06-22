using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefLevel
    {
        public RefLevel()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Lvl { get; set; }

        public long ExpC { get; set; }

        public int ExpM { get; set; }

        public int CostM { get; set; }

        public int CostST { get; set; }

        public int GUSTMobExp { get; set; }

        public int? JobExpTrader { get; set; }

        public int? JobExpRobber { get; set; }

        public int? JobExpHunter { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
