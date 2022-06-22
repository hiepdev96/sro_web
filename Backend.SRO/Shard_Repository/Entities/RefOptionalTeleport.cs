using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefOptionalTeleport
    {
        public RefOptionalTeleport()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public string ObjName128 { get; set; }

        public string ZoneName128 { get; set; }

        public short RegionID { get; set; }

        public short PosX { get; set; }

        public short PosY { get; set; }

        public short PosZ { get; set; }

        public short WorldID { get; set; }

        public int RegionIDGroup { get; set; }

        public byte MapPoint { get; set; }

        public short LevelMin { get; set; }

        public short LevelMax { get; set; }

        public int? Param1 { get; set; }

        public string Param1Desc128 { get; set; }

        public int? Param2 { get; set; }

        public string Param2Desc128 { get; set; }

        public int? Param3 { get; set; }

        public string Param3Desc128 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
