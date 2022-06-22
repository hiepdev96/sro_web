using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class BrutalBlockedIP
    {
        public BrutalBlockedIP()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int NIdx { get; set; }

        public string SzIPBegin { get; set; }

        public string SzIPEnd { get; set; }

        public string SzGM { get; set; }

        public DateTime DIssueDate { get; set; }

        public string SzISP { get; set; }

        public string SzDesc { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
