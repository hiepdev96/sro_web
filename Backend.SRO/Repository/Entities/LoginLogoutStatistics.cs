using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class LoginLogoutStatistics
    {
        public LoginLogoutStatistics()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int NIdx { get; set; }

        public int NJID { get; set; }

        public int NIP { get; set; }

        public DateTime DLogin { get; set; }

        public DateTime DLogout { get; set; }

        public byte ByReserved { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
