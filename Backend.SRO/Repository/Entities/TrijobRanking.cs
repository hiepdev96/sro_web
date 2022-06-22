using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class TrijobRanking
    {
        public TrijobRanking()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int ShardID { get; set; }

        public byte TrijobType { get; set; }

        public byte RankType { get; set; }

        public byte Rank { get; set; }

        public string NickName { get; set; }

        public byte JobLevel { get; set; }

        public int JobData { get; set; }

        public byte IsNewEntry { get; set; }

        public short RankDelta { get; set; }

        public byte Country { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
