using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class BindingOptionWithItem
    {
        public BindingOptionWithItem()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long NItemDBID { get; set; }

        public byte BOptType { get; set; }

        public byte NSlot { get; set; }

        public int NOptID { get; set; }

        public byte NOptLvl { get; set; }

        public int NOptValue { get; set; }

        public int? NParam1 { get; set; }

        public int? NParam2 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
