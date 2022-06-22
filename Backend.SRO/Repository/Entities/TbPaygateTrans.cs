using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class TbPaygateTrans
    {
        public TbPaygateTrans()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int TransID { get; set; }

        public DateTime? TransDate { get; set; }

        public string TransType { get; set; }

        public string BankId { get; set; }

        public string AccountId { get; set; }

        public string OrderNo { get; set; }

        public int? MoneyValue { get; set; }

        public int? BeforeMoney { get; set; }

        public int? AfterMoney { get; set; }

        public long? PGTransID { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
