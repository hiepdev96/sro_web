using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class ChestInfo
    {
        public ChestInfo()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Jid { get; set; }

        public byte ChestSize { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AccountJID AccountJID { get; set; }

        #endregion

    }
}
