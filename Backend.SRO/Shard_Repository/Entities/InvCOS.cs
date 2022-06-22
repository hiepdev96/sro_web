using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class InvCOS
    {
        public InvCOS()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Cosid { get; set; }

        public byte Slot { get; set; }

        public long? ItemID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual CharCOS CosidCharCOS { get; set; }

        public virtual Items ItemItems { get; set; }

        #endregion

    }
}
