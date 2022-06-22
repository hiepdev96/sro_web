using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class DeletedChar
    {
        public DeletedChar()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public int UserJID { get; set; }

        public DateTime DeletedDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
