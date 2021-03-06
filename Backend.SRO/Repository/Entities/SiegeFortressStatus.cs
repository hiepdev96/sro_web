using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SiegeFortressStatus
    {
        public SiegeFortressStatus()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int ShardID { get; set; }

        public string FortressName { get; set; }

        public byte FortressScale { get; set; }

        public short TaxRatio { get; set; }

        public string OwnerGuildName { get; set; }

        public string OwnerGuildMaster { get; set; }

        public string OwnerAllianceGuildName1 { get; set; }

        public string OwnerAllianceGuildName2 { get; set; }

        public string OwnerAllianceGuildName3 { get; set; }

        public string OwnerAllianceGuildName4 { get; set; }

        public string OwnerAllianceGuildName5 { get; set; }

        public string OwnerAllianceGuildName6 { get; set; }

        public string OwnerAllianceGuildName7 { get; set; }

        public string OwnerAllianceGuildName8 { get; set; }

        public DateTime? OwnerUpdateDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
