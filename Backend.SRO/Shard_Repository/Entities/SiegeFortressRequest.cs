using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class SiegeFortressRequest
    {
        public SiegeFortressRequest()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FortressID { get; set; }

        public int GuildID { get; set; }

        public byte RequestType { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Guild Guild { get; set; }

        public virtual SiegeFortress SiegeFortress { get; set; }

        #endregion

    }
}
