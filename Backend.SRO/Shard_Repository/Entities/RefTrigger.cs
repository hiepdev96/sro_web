using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTrigger
    {
        public RefTrigger()
        {
            #region Generated Constructor
            BindTriggerRefTriggerVariables = new HashSet<RefTriggerVariable>();
            TriggerRefTriggerBindActions = new HashSet<RefTriggerBindAction>();
            TriggerRefTriggerBindConditions = new HashSet<RefTriggerBindCondition>();
            TriggerRefTriggerBindEvents = new HashSet<RefTriggerBindEvent>();
            TriggerRefTriggerCategoryBindTriggers = new HashSet<RefTriggerCategoryBindTrigger>();
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public string CodeName128 { get; set; }

        public byte IsActive { get; set; }

        public byte IsRepeat { get; set; }

        public string Comment512 { get; set; }

        public int IndexNumber { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<RefTriggerVariable> BindTriggerRefTriggerVariables { get; set; }

        public virtual ICollection<RefTriggerBindAction> TriggerRefTriggerBindActions { get; set; }

        public virtual ICollection<RefTriggerBindCondition> TriggerRefTriggerBindConditions { get; set; }

        public virtual ICollection<RefTriggerBindEvent> TriggerRefTriggerBindEvents { get; set; }

        public virtual ICollection<RefTriggerCategoryBindTrigger> TriggerRefTriggerCategoryBindTriggers { get; set; }

        #endregion

    }
}
