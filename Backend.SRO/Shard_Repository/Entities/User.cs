using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class User
    {
        public User()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int UserJID { get; set; }

        public int CharID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        public virtual AccountJID JAccountJID { get; set; }

        #endregion

    }
}
