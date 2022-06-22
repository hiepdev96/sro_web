using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class GuildMember
    {
        public GuildMember()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int GuildID { get; set; }

        public int CharID { get; set; }

        public string CharName { get; set; }

        public byte MemberClass { get; set; }

        public byte CharLevel { get; set; }

        public int GPDonation { get; set; }

        public DateTime JoinDate { get; set; }

        public int? Permission { get; set; }

        public int? Contribution { get; set; }

        public int? GuildWarKill { get; set; }

        public int? GuildWarKilled { get; set; }

        public string Nickname { get; set; }

        public int? RefObjID { get; set; }

        public byte? SiegeAuthority { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        public virtual Guild Guild { get; set; }

        #endregion

    }
}
