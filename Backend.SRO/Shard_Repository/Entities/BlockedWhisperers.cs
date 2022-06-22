using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class BlockedWhisperers
    {
        public BlockedWhisperers()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int OwnerID { get; set; }

        public string TargetName { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char OwnerChar { get; set; }

        #endregion

    }
}
