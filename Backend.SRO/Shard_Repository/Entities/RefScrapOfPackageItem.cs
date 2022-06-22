using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefScrapOfPackageItem
    {
        public RefScrapOfPackageItem()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Country { get; set; }

        public string RefPackageItemCodeName { get; set; }

        public string RefItemCodeName { get; set; }

        public byte OptLevel { get; set; }

        public long Variance { get; set; }

        public int Data { get; set; }

        public byte MagParamNum { get; set; }

        public long MagParam1 { get; set; }

        public long MagParam2 { get; set; }

        public long MagParam3 { get; set; }

        public long MagParam4 { get; set; }

        public long MagParam5 { get; set; }

        public long MagParam6 { get; set; }

        public long MagParam7 { get; set; }

        public long MagParam8 { get; set; }

        public long MagParam9 { get; set; }

        public long MagParam10 { get; set; }

        public long MagParam11 { get; set; }

        public long MagParam12 { get; set; }

        public int Param1 { get; set; }

        public string Param1Desc128 { get; set; }

        public int Param2 { get; set; }

        public string Param2Desc128 { get; set; }

        public int Param3 { get; set; }

        public string Param3Desc128 { get; set; }

        public int Param4 { get; set; }

        public string Param4Desc128 { get; set; }

        public int Index { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefShopObject CountryRefShopObject { get; set; }

        #endregion

    }
}
