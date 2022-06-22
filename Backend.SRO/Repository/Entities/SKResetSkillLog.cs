using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SKResetSkillLog
    {
        public SKResetSkillLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? Jid { get; set; }

        public string Struserid { get; set; }

        public string Charname { get; set; }

        public string SkillDown { get; set; }

        public string NewSkill { get; set; }

        public string SilkDown { get; set; }

        public string Server { get; set; }

        public DateTime? TimeReset { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
