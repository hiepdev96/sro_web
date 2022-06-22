using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SKSubtractSilkVAS
    {
        public SKSubtractSilkVAS()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int BuyNo { get; set; }

        public int UserJID { get; set; }

        public byte SilkType { get; set; }

        public byte SilkReason { get; set; }

        public int SilkOffset { get; set; }

        public int SilkRemain { get; set; }

        public int Id { get; set; }

        public int BuyQuantity { get; set; }

        public string OrderNumber { get; set; }

        public byte? PGCompany { get; set; }

        public byte? PayMethod { get; set; }

        public string PGUniqueNo { get; set; }

        public string AuthNumber { get; set; }

        public DateTime? AuthDate { get; set; }

        public int? SubJID { get; set; }

        public string SrID { get; set; }

        public string SlipPaper { get; set; }

        public int? MngID { get; set; }

        public string Ip { get; set; }

        public DateTime RegDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
