using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class CasGMChatLog
    {
        public CasGMChatLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int NSerial { get; set; }

        public string SzGM { get; set; }

        public short WShardID { get; set; }

        public string SzCharName { get; set; }

        public int NCasSerial { get; set; }

        public string SzGMChatLog { get; set; }

        public DateTime DWritten { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
