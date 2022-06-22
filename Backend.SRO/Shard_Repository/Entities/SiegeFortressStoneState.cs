using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class SiegeFortressStoneState
    {
        public SiegeFortressStoneState()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FortressID { get; set; }

        public int GuildID { get; set; }

        public int AccumulateDamage { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SiegeFortress SiegeFortress { get; set; }

        #endregion

    }
}
