using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTriggerCommon
    {
        public RefTriggerCommon()
        {
            #region Generated Constructor
            RefTriggerActions = new HashSet<RefTriggerAction>();
            RefTriggerConditions = new HashSet<RefTriggerCondition>();
            RefTriggerEvents = new HashSet<RefTriggerEvent>();
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public string CodeName128 { get; set; }

        public string ObjName128 { get; set; }

        public short Tid1 { get; set; }

        public short Tid2 { get; set; }

        public short Tid3 { get; set; }

        public short Tid4 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<RefTriggerAction> RefTriggerActions { get; set; }

        public virtual ICollection<RefTriggerCondition> RefTriggerConditions { get; set; }

        public virtual ICollection<RefTriggerEvent> RefTriggerEvents { get; set; }

        #endregion

    }
}
