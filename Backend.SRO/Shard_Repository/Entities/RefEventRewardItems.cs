using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefEventRewardItems
    {
        public RefEventRewardItems()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int EventID { get; set; }

        public string EventCodeName { get; set; }

        public string ItemCodeName { get; set; }

        public int PayCount { get; set; }

        public float AchieveRatio { get; set; }

        public string RentItemCodeName { get; set; }

        public int Param1 { get; set; }

        public string Param1Desc { get; set; }

        public int Param2 { get; set; }

        public string Param2Desc { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
