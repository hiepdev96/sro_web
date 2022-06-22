using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class ShopItemStockQuantity
    {
        public ShopItemStockQuantity()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Country { get; set; }

        public string RefShopGroupCodeName { get; set; }

        public string RefPackageItemCodeName { get; set; }

        public short ConstStockQuantity { get; set; }

        public short StockQuantity { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
