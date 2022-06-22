using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefFmnCategoryTree
    {
        public RefFmnCategoryTree()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public string CategoryName { get; set; }

        public string StringID { get; set; }

        public string ParentCategoryName { get; set; }

        public int TidGroupID { get; set; }

        public byte Degree { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
