using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class SiegeFortressItemForge
    {
        public SiegeFortressItemForge()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FortressID { get; set; }

        public int ItemRefID { get; set; }

        public short Amount { get; set; }

        public byte Finished { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SiegeFortress SiegeFortress { get; set; }

        #endregion

    }
}
