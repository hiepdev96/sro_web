using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SKDownLevelLog
    {
        public SKDownLevelLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? Jid { get; set; }

        public string Struserid { get; set; }

        public string Charname { get; set; }

        public string Package { get; set; }

        public string Newlevel { get; set; }

        public string Server { get; set; }

        public DateTime? Timedown { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
