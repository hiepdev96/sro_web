using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SKCharRenameLog
    {
        public SKCharRenameLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? Jid { get; set; }

        public string Struserid { get; set; }

        public string OldChar { get; set; }

        public string NewChar { get; set; }

        public string Server { get; set; }

        public DateTime? Timechange { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
