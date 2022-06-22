using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefEventReward
    {
        public RefEventReward()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int EventID { get; set; }

        public string EventCodeName { get; set; }

        public byte IsView { get; set; }

        public byte IsBasicReward { get; set; }

        public byte IsItemReward { get; set; }

        public byte IsCheckCondition { get; set; }

        public byte IsCheckCountry { get; set; }

        public byte IsCheckClass { get; set; }

        public byte IsCheckGender { get; set; }

        public int Gold { get; set; }

        public int Exp { get; set; }

        public int SPExp { get; set; }

        public int Sp { get; set; }

        public byte Hwan { get; set; }

        public byte Inventory { get; set; }

        public byte ItemRewardType { get; set; }

        public byte SelectionCnt { get; set; }

        public int Param1 { get; set; }

        public string Param1Desc { get; set; }

        public int Param2 { get; set; }

        public string Param2Desc { get; set; }

        public int Param3 { get; set; }

        public string Param3Desc { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
