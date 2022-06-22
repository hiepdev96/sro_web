using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class GuildChest
    {
        public GuildChest()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int GuildID { get; set; }

        public byte Slot { get; set; }

        public long? ItemID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Guild Guild { get; set; }

        #endregion

    }
}
