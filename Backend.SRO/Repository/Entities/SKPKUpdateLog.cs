using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SKPKUpdateLog
    {
        public SKPKUpdateLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int Jid { get; set; }

        public string UserName { get; set; }

        public int? CharID { get; set; }

        public string CharName { get; set; }

        public int PackageItemID { get; set; }

        public int? SilkOwn { get; set; }

        public int? SilkBefore { get; set; }

        public int? SilkAfter { get; set; }

        public long? GoldRemain { get; set; }

        public long? GoldBefore { get; set; }

        public long? GoldAfter { get; set; }

        public int Ip { get; set; }

        public DateTime RegDate { get; set; }

        public long? Serial64 { get; set; }

        public int? ShardID { get; set; }

        public string ServiceCode { get; set; }

        public int? Strength { get; set; }

        public int? Intellect { get; set; }

        public int? CurLevel { get; set; }

        public int? Statpoint { get; set; }

        public string NewName { get; set; }

        public string OldPetName { get; set; }

        public string NewPetName { get; set; }

        public int? NewStatPoint { get; set; }

        public int? NewLevel { get; set; }

        public int? NewStrength { get; set; }

        public int? NewIntellect { get; set; }

        public int? SkillOwn { get; set; }

        public int? SkillBefore { get; set; }

        public int? SkillAfter { get; set; }

        public string ItemBH { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
