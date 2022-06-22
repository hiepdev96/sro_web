using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class CharInstanceWorldData
    {
        public CharInstanceWorldData()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public int DungeonKeyID { get; set; }

        public int WorldID { get; set; }

        public int LayerID { get; set; }

        public DateTime OpenedTime { get; set; }

        public short RegionID { get; set; }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public int PosZ { get; set; }

        public byte IsActivated { get; set; }

        public int EnterCount { get; set; }

        public DateTime LastEnterTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
