using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefQuestRewardItems
    {
        public RefQuestRewardItems()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int QuestID { get; set; }

        public string QuestCodeName { get; set; }

        public byte RewardType { get; set; }

        public string ItemCodeName { get; set; }

        public string OptionalItemCode { get; set; }

        public int OptionalItemCnt { get; set; }

        public int AchieveQuantity { get; set; }

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
