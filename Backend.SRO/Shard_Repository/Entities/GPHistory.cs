using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class GPHistory
    {
        public GPHistory()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int GuildID { get; set; }

        public DateTime? UsedTime { get; set; }

        public string CharName { get; set; }

        public int UsedGP { get; set; }

        public byte Reason { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
