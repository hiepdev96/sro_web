using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefShopGoods
    {
        public RefShopGoods()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Country { get; set; }

        public string RefTabCodeName { get; set; }

        public string RefPackageItemCodeName { get; set; }

        public byte SlotIndex { get; set; }

        public int Param1 { get; set; }

        public string Param1Desc128 { get; set; }

        public int Param2 { get; set; }

        public string Param2Desc128 { get; set; }

        public int Param3 { get; set; }

        public string Param3Desc128 { get; set; }

        public int Param4 { get; set; }

        public string Param4Desc128 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefShopObject CountryRefShopObject { get; set; }

        #endregion

    }
}
