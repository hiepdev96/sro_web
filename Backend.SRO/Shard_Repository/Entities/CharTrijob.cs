using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class CharTrijob
    {
        public CharTrijob()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public byte JobType { get; set; }

        public byte Level { get; set; }

        public int Exp { get; set; }

        public int Contribution { get; set; }

        public int Reward { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        public virtual CharTrijobSafeTrade CharTrijobSafeTrade { get; set; }

        #endregion

    }
}
