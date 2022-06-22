using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTriggerAction
    {
        public RefTriggerAction()
        {
            #region Generated Constructor
            TriggerActionRefTriggerBindActions = new HashSet<RefTriggerBindAction>();
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public int RefTriggerCommonID { get; set; }

        public int Delay { get; set; }

        public string ParamGroupCodeName128 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefTriggerCommon RefTriggerCommon { get; set; }

        public virtual ICollection<RefTriggerBindAction> TriggerActionRefTriggerBindActions { get; set; }

        #endregion

    }
}
