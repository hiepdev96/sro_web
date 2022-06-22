using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class SiegeFortress
    {
        public SiegeFortress()
        {
            #region Generated Constructor
            SiegeFortressBattleRecords = new HashSet<SiegeFortressBattleRecord>();
            SiegeFortressItemForges = new HashSet<SiegeFortressItemForge>();
            SiegeFortressObjects = new HashSet<SiegeFortressObject>();
            SiegeFortressRequests = new HashSet<SiegeFortressRequest>();
            SiegeFortressStoneStates = new HashSet<SiegeFortressStoneState>();
            #endregion
        }

        #region Generated Properties
        public int FortressID { get; set; }

        public int GuildID { get; set; }

        public short TaxRatio { get; set; }

        public long Tax { get; set; }

        public byte NPCHired { get; set; }

        public int TempGuildID { get; set; }

        public string Introduction { get; set; }

        public DateTime? CreatedDungeonTime { get; set; }

        public byte? CreatedDungeonCount { get; set; }

        public byte IntroductionModificationPermission { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Guild Guild { get; set; }

        public virtual ICollection<SiegeFortressBattleRecord> SiegeFortressBattleRecords { get; set; }

        public virtual ICollection<SiegeFortressItemForge> SiegeFortressItemForges { get; set; }

        public virtual ICollection<SiegeFortressObject> SiegeFortressObjects { get; set; }

        public virtual ICollection<SiegeFortressRequest> SiegeFortressRequests { get; set; }

        public virtual ICollection<SiegeFortressStoneState> SiegeFortressStoneStates { get; set; }

        #endregion

    }
}
