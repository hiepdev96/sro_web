using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefDropItemGroup
    {
        public RefDropItemGroup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int RefItemGroupID { get; set; }

        public string CodeName128 { get; set; }

        public int RefItemID { get; set; }

        public float SelectRatio { get; set; }

        public int RefMagicGroupID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefObjCommon RefItemRefObjCommon { get; set; }

        #endregion

    }
}
