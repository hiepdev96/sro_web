using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTriggerEvent
    {
        public RefTriggerEvent()
        {
            #region Generated Constructor
            TriggerEventRefTriggerBindEvents = new HashSet<RefTriggerBindEvent>();
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public int RefTriggerCommonID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefTriggerCommon RefTriggerCommon { get; set; }

        public virtual ICollection<RefTriggerBindEvent> TriggerEventRefTriggerBindEvents { get; set; }

        #endregion

    }
}
