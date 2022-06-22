using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTriggerCategoryBindTrigger
    {
        public RefTriggerCategoryBindTrigger()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public int TriggerCategoryID { get; set; }

        public int TriggerID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefTrigger TriggerRefTrigger { get; set; }

        #endregion

    }
}
