using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class ItemPool
    {
        public ItemPool()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long ItemID { get; set; }

        public byte InUse { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Items ItemItems { get; set; }

        #endregion

    }
}
