using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class TabRefHive
    {
        public TabRefHive()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int DwHiveID { get; set; }

        public byte? BtKeepMonsterCountType { get; set; }

        public int? DwOverwriteMaxTotalCount { get; set; }

        public float? FMonsterCountPerPC { get; set; }

        public int? DwSpawnSpeedIncreaseRate { get; set; }

        public int? DwMaxIncreaseRate { get; set; }

        public byte? BtFlag { get; set; }

        public short? GameWorldID { get; set; }

        public short? HatchObjType { get; set; }

        public string SzDescString128 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
