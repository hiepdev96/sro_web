using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RentItemInfo
    {
        public RentItemInfo()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long NItemDBID { get; set; }

        public int NRentType { get; set; }

        public short NCanDelete { get; set; }

        public short NCanRecharge { get; set; }

        public DateTime PeriodBeginTime { get; set; }

        public DateTime PeriodEndTime { get; set; }

        public DateTime? MeterRateTime { get; set; }

        public short? NPackingState { get; set; }

        public int? NPackingTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
