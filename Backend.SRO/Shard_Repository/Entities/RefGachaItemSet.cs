using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefGachaItemSet
    {
        public RefGachaItemSet()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int SetID { get; set; }

        public int RefItemID { get; set; }

        public short Ratio { get; set; }

        public short Count { get; set; }

        public int GachaID { get; set; }

        public byte Visible { get; set; }

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
        #endregion

    }
}
