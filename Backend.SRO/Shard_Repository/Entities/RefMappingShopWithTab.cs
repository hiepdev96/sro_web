using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefMappingShopWithTab
    {
        public RefMappingShopWithTab()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Country { get; set; }

        public string RefShopCodeName { get; set; }

        public string RefTabGroupCodeName { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefShopObject CountryRefShopObject { get; set; }

        #endregion

    }
}
