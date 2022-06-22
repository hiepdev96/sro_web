using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SMCLog
    {
        public SMCLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public string SzUserID { get; set; }

        public byte Catagory { get; set; }

        public string SzLog { get; set; }

        public DateTime DLogDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
