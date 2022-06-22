using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class SiegeFortressBattleRecord
    {
        public SiegeFortressBattleRecord()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FortressID { get; set; }

        public int CharID { get; set; }

        public int KillCount { get; set; }

        public int KilledCount { get; set; }

        public DateTime RankUpDate { get; set; }

        public byte CurRank { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SiegeFortress SiegeFortress { get; set; }

        #endregion

    }
}
