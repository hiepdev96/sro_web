using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefRegion
    {
        public RefRegion()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public short WRegionID { get; set; }

        public byte X { get; set; }

        public byte Z { get; set; }

        public string ContinentName { get; set; }

        public string AreaName { get; set; }

        public byte IsBattleField { get; set; }

        public int Climate { get; set; }

        public int MaxCapacity { get; set; }

        public int AssocObjID { get; set; }

        public int AssocServer { get; set; }

        public string AssocFile256 { get; set; }

        public int? LinkedRegion1 { get; set; }

        public int? LinkedRegion2 { get; set; }

        public int? LinkedRegion3 { get; set; }

        public int? LinkedRegion4 { get; set; }

        public int? LinkedRegion5 { get; set; }

        public int? LinkedRegion6 { get; set; }

        public int? LinkedRegion7 { get; set; }

        public int? LinkedRegion8 { get; set; }

        public int? LinkedRegion9 { get; set; }

        public int? LinkedRegion10 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
