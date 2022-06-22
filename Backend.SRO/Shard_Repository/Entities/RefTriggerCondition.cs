using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTriggerCondition
    {
        public RefTriggerCondition()
        {
            #region Generated Constructor
            TriggerConditionRefTriggerBindConditions = new HashSet<RefTriggerBindCondition>();
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public int RefTriggerCommonID { get; set; }

        public string OnTrue { get; set; }

        public string OnFalse { get; set; }

        public short Sequence { get; set; }

        public string ParamGroupCodeName128 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefTriggerCommon RefTriggerCommon { get; set; }

        public virtual ICollection<RefTriggerBindCondition> TriggerConditionRefTriggerBindConditions { get; set; }

        #endregion

    }
}
