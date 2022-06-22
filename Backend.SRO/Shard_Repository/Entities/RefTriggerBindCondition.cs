using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTriggerBindCondition
    {
        public RefTriggerBindCondition()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public int TriggerID { get; set; }

        public int TriggerConditionID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefTriggerCondition TriggerConditionRefTriggerCondition { get; set; }

        public virtual RefTrigger TriggerRefTrigger { get; set; }

        #endregion

    }
}
