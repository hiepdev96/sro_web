using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class ShardCurrentUser
    {
        public ShardCurrentUser()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int NID { get; set; }

        public int NShardID { get; set; }

        public int NUserCount { get; set; }

        public DateTime DLogDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
