using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class WebShopSROLog
    {
        public WebShopSROLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public int Jid { get; set; }

        public string Ip { get; set; }

        public string CodeName128 { get; set; }

        public decimal BalanceBeforeBuy { get; set; }

        public decimal BalanceAfterBuy { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
