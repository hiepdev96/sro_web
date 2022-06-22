using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefCustomizingReservedItemDropForMonster
    {
        public RefCustomizingReservedItemDropForMonster()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int RefMonsterID { get; set; }

        public byte Rarity { get; set; }

        public int Command { get; set; }

        public byte DropGroupType { get; set; }

        public int? Param1 { get; set; }

        public int? Param2 { get; set; }

        public int? Param3 { get; set; }

        public int? Param4 { get; set; }

        public int? Param5 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefObjCommon RefMonsterRefObjCommon { get; set; }

        #endregion

    }
}
