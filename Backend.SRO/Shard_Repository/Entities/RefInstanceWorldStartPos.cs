using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefInstanceWorldStartPos
    {
        public RefInstanceWorldStartPos()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int WorldID { get; set; }

        public short RegionID { get; set; }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public int PosZ { get; set; }

        public int? Param { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
