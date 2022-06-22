using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class Chest
    {
        public Chest()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int UserJID { get; set; }

        public byte Slot { get; set; }

        public long? ItemID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Items ItemItems { get; set; }

        public virtual AccountJID UserJAccountJID { get; set; }

        #endregion

    }
}
