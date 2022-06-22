using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class TabRefNest
    {
        public TabRefNest()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int DwNestID { get; set; }

        public int DwHiveID { get; set; }

        public int DwTacticsID { get; set; }

        public short NRegionDBID { get; set; }

        public float? FLocalPosX { get; set; }

        public float? FLocalPosY { get; set; }

        public float? FLocalPosZ { get; set; }

        public short? WInitialDir { get; set; }

        public int? NRadius { get; set; }

        public int? NGenerateRadius { get; set; }

        public int? NChampionGenPercentage { get; set; }

        public int? DwDelayTimeMin { get; set; }

        public int? DwDelayTimeMax { get; set; }

        public int DwMaxTotalCount { get; set; }

        public byte? BtFlag { get; set; }

        public byte BtRespawn { get; set; }

        public byte BtType { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
