using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefRentItem
    {
        public RefRentItem()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public string RentCodeName { get; set; }

        public int RefItemID { get; set; }

        public byte CanDelete { get; set; }

        public byte CnaRecharge { get; set; }

        public int? RentType { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public byte? TimeCnt { get; set; }

        public int? Time1 { get; set; }

        public int? Time2 { get; set; }

        public int? Time3 { get; set; }

        public int? Time4 { get; set; }

        public int? Time5 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
