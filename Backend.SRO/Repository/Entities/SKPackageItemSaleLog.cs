using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SKPackageItemSaleLog
    {
        public SKPackageItemSaleLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int Jid { get; set; }

        public int ShardID { get; set; }

        public int CharID { get; set; }

        public int PackageItemID { get; set; }

        public int SilkOwn { get; set; }

        public int SilkGift { get; set; }

        public int SilkPoint { get; set; }

        public int? Ip { get; set; }

        public DateTime RegDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
