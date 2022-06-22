using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class QuaySoEpoint
    {
        public QuaySoEpoint()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string UserCash { get; set; }

        public int? Server { get; set; }

        public int? CharID { get; set; }

        public string CharName { get; set; }

        public int? SPOwn { get; set; }

        public int? SPBefore { get; set; }

        public int? SPAfter { get; set; }

        public DateTime? Regdate { get; set; }

        public string SourcePoint { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
