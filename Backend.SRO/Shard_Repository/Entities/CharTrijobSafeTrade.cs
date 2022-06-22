using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class CharTrijobSafeTrade
    {
        public CharTrijobSafeTrade()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public int AbleCount { get; set; }

        public int Status { get; set; }

        public DateTime LastSafeTrade { get; set; }

        #endregion

        #region Generated Relationships
        public virtual CharTrijob CharTrijob { get; set; }

        #endregion

    }
}
