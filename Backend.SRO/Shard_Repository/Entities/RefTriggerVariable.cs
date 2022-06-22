using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTriggerVariable
    {
        public RefTriggerVariable()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public int BindTriggerID { get; set; }

        public string CodeName128 { get; set; }

        public string Type { get; set; }

        public int Value { get; set; }

        public string Comment128 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefTrigger BindTriggerRefTrigger { get; set; }

        #endregion

    }
}
