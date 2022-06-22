using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class Notice
    {
        public Notice()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public byte ContentID { get; set; }

        public string Subject { get; set; }

        public string Article { get; set; }

        public DateTime EditDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
