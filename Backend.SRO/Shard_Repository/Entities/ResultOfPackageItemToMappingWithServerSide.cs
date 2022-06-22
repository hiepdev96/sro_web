using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class ResultOfPackageItemToMappingWithServerSide
    {
        public ResultOfPackageItemToMappingWithServerSide()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Operation { get; set; }

        public int CharID { get; set; }

        public int Slot { get; set; }

        public long RefItemSerial64 { get; set; }

        public long RefItemDBID { get; set; }

        public int RefItemID { get; set; }

        public byte Type { get; set; }

        public byte SubType { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
