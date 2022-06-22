using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class OpenMarket
    {
        public OpenMarket()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Jid { get; set; }

        public int PersnalID { get; set; }

        public string CharName16 { get; set; }

        public byte Status { get; set; }

        public int RefItemID { get; set; }

        public int TidGroupID { get; set; }

        public int ItemClass { get; set; }

        public long ItemID { get; set; }

        public int SellCnt { get; set; }

        public DateTime RegDate { get; set; }

        public DateTime EndDate { get; set; }

        public long Price { get; set; }

        public long Deposit { get; set; }

        public long SellFee { get; set; }

        public int UseCash { get; set; }

        public long Serial64 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AccountJID AccountJID { get; set; }

        public virtual Items ItemItems { get; set; }

        #endregion

    }
}
