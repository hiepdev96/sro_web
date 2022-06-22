using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class AlliedClans
    {
        public AlliedClans()
        {
            #region Generated Constructor
            AllianceGuilds = new HashSet<Guild>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? Ally1 { get; set; }

        public int? Ally2 { get; set; }

        public int? Ally3 { get; set; }

        public int? Ally4 { get; set; }

        public int? Ally5 { get; set; }

        public int? Ally6 { get; set; }

        public int? Ally7 { get; set; }

        public int? Ally8 { get; set; }

        public DateTime FoundationDate { get; set; }

        public int LastCrestRev { get; set; }

        public int CurCrestRev { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Guild> AllianceGuilds { get; set; }

        public virtual Guild Ally1Guild { get; set; }

        public virtual Guild Ally2Guild { get; set; }

        public virtual Guild Ally3Guild { get; set; }

        public virtual Guild Ally4Guild { get; set; }

        public virtual Guild Ally5Guild { get; set; }

        public virtual Guild Ally6Guild { get; set; }

        public virtual Guild Ally7Guild { get; set; }

        public virtual Guild Ally8Guild { get; set; }

        #endregion

    }
}
