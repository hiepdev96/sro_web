using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class OldBlockedUser
    {
        public OldBlockedUser()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int UserJID { get; set; }

        public byte Type { get; set; }

        public int SerialNo { get; set; }

        public DateTime TimeBegin { get; set; }

        public DateTime TimeEnd { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
