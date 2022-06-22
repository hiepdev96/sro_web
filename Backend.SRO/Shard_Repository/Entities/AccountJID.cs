using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class AccountJID
    {
        public AccountJID()
        {
            #region Generated Constructor
            JUsers = new HashSet<User>();
            UserJChests = new HashSet<Chest>();
            #endregion
        }

        #region Generated Properties
        public string AccountID { get; set; }

        public int Jid { get; set; }

        public long Gold { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ChestInfo ChestInfo { get; set; }

        public virtual ICollection<User> JUsers { get; set; }

        public virtual OpenMarket OpenMarket { get; set; }

        public virtual ICollection<Chest> UserJChests { get; set; }

        #endregion

    }
}
