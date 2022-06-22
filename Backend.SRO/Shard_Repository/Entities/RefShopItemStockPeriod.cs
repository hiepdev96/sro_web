using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefShopItemStockPeriod
    {
        public RefShopItemStockPeriod()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Country { get; set; }

        public int Id { get; set; }

        public string RefShopGroupCodeName { get; set; }

        public string RefPackageItemCodeName { get; set; }

        public DateTime StockOpeningDate { get; set; }

        public DateTime StockExpireDate { get; set; }

        public byte PeriodDevice { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
