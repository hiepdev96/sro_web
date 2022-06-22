using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefMappingShopGroup
    {
        public RefMappingShopGroup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Country { get; set; }

        public string RefShopGroupCodeName { get; set; }

        public string RefShopCodeName { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefShopObject CountryRefShopObject { get; set; }

        #endregion

    }
}
