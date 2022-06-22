using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefDropItemAssign
    {
        public RefDropItemAssign()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int RefItemID { get; set; }

        public int ProbRelative { get; set; }

        public int ProbAbsolute { get; set; }

        public int AssignedGroup { get; set; }

        public int DropCount { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
