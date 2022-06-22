using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class CasData
    {
        public CasData()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int NSerial { get; set; }

        public byte NCategory { get; set; }

        public DateTime DReportDate { get; set; }

        public short WShardID { get; set; }

        public int DwUserJID { get; set; }

        public string SzCharName { get; set; }

        public string SzTgtCharName { get; set; }

        public string SzMailAddress { get; set; }

        public string SzStatement { get; set; }

        public byte NStatus { get; set; }

        public DateTime? DProcessDate { get; set; }

        public string SzProcessedGM { get; set; }

        public string SzMemo { get; set; }

        public string SzAnswer { get; set; }

        public byte BtUserChecked { get; set; }

        public string SzChatLog { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
