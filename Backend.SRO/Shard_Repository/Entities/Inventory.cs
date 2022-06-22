using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class Inventory
    {
        public Inventory()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public byte Slot { get; set; }

        public long ItemID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        public virtual Items ItemItems { get; set; }

        #endregion

    }
}
