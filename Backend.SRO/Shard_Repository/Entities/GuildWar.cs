using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class GuildWar
    {
        public GuildWar()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public byte WarType { get; set; }

        public byte VictoryPointIndex { get; set; }

        public int LodgedGold { get; set; }

        public DateTime? WarEndTime { get; set; }

        public int Guild1 { get; set; }

        public int Guild2 { get; set; }

        public int PointGain1 { get; set; }

        public int PointGain2 { get; set; }

        public int Data1 { get; set; }

        public int Data2 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Guild Guild { get; set; }

        public virtual Guild Guild3 { get; set; }

        #endregion

    }
}
