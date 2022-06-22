using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefPackageItem
    {
        public RefPackageItem()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Country { get; set; }

        public int Id { get; set; }

        public string CodeName128 { get; set; }

        public short SaleTag { get; set; }

        public string ExpandTerm { get; set; }

        public string NameStrID { get; set; }

        public string DescStrID { get; set; }

        public string AssocFileIcon { get; set; }

        public int Param1 { get; set; }

        public string Param1Desc128 { get; set; }

        public int Param2 { get; set; }

        public string Param2Desc128 { get; set; }

        public int Param3 { get; set; }

        public string Param3Desc128 { get; set; }

        public int Param4 { get; set; }

        public string Param4Desc128 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefShopObject CountryRefShopObject { get; set; }

        #endregion

    }
}
