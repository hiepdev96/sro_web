using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class ItemQuotation
    {
        public ItemQuotation()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int Service { get; set; }

        public int AssocNPC { get; set; }

        public int RefItemID { get; set; }

        public float BaseQuot { get; set; }

        public float QuotLB { get; set; }

        public float QuotUB { get; set; }

        public int BaseStockAmount { get; set; }

        public int FluctuateAmount { get; set; }

        public int CurStockAmount { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
