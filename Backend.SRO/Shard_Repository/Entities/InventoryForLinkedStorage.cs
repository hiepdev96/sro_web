using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class InventoryForLinkedStorage
    {
        public InventoryForLinkedStorage()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long LinkedItemID { get; set; }

        public byte Slot { get; set; }

        public long ItemID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Items ItemItems { get; set; }

        #endregion

    }
}
