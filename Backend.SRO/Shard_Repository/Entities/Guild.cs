using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class Guild
    {
        public Guild()
        {
            #region Generated Constructor
            Ally1AlliedClans = new HashSet<AlliedClans>();
            Ally2AlliedClans = new HashSet<AlliedClans>();
            Ally3AlliedClans = new HashSet<AlliedClans>();
            Ally4AlliedClans = new HashSet<AlliedClans>();
            Ally5AlliedClans = new HashSet<AlliedClans>();
            Ally6AlliedClans = new HashSet<AlliedClans>();
            Ally7AlliedClans = new HashSet<AlliedClans>();
            Ally8AlliedClans = new HashSet<AlliedClans>();
            GuildChests = new HashSet<GuildChest>();
            GuildMembers = new HashSet<GuildMember>();
            GuildWars = new HashSet<GuildWar>();
            GuildWars1 = new HashSet<GuildWar>();
            SiegeFortresses = new HashSet<SiegeFortress>();
            SiegeFortressRequests = new HashSet<SiegeFortressRequest>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public byte Lvl { get; set; }

        public int GatheredSP { get; set; }

        public DateTime FoundationDate { get; set; }

        public int? Alliance { get; set; }

        public string MasterCommentTitle { get; set; }

        public string MasterComment { get; set; }

        public int? Booty { get; set; }

        public long Gold { get; set; }

        public int LastCrestRev { get; set; }

        public int CurCrestRev { get; set; }

        public byte MercenaryAttr { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AlliedClans AllianceAlliedClans { get; set; }

        public virtual ICollection<AlliedClans> Ally1AlliedClans { get; set; }

        public virtual ICollection<AlliedClans> Ally2AlliedClans { get; set; }

        public virtual ICollection<AlliedClans> Ally3AlliedClans { get; set; }

        public virtual ICollection<AlliedClans> Ally4AlliedClans { get; set; }

        public virtual ICollection<AlliedClans> Ally5AlliedClans { get; set; }

        public virtual ICollection<AlliedClans> Ally6AlliedClans { get; set; }

        public virtual ICollection<AlliedClans> Ally7AlliedClans { get; set; }

        public virtual ICollection<AlliedClans> Ally8AlliedClans { get; set; }

        public virtual ICollection<GuildChest> GuildChests { get; set; }

        public virtual ICollection<GuildMember> GuildMembers { get; set; }

        public virtual ICollection<GuildWar> GuildWars { get; set; }

        public virtual ICollection<GuildWar> GuildWars1 { get; set; }

        public virtual ICollection<SiegeFortress> SiegeFortresses { get; set; }

        public virtual ICollection<SiegeFortressRequest> SiegeFortressRequests { get; set; }

        #endregion

    }
}
