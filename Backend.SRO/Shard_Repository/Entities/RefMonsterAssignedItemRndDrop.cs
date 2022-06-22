using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefMonsterAssignedItemRndDrop
    {
        public RefMonsterAssignedItemRndDrop()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int RefMonsterID { get; set; }

        public int RefItemGroupID { get; set; }

        public string ItemGroupCodeName128 { get; set; }

        public byte Overlap { get; set; }

        public byte DropAmountMin { get; set; }

        public byte DropAmountMax { get; set; }

        public float DropRatio { get; set; }

        public int Param1 { get; set; }

        public int Param2 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefObjCommon RefMonsterRefObjCommon { get; set; }

        #endregion

    }
}
