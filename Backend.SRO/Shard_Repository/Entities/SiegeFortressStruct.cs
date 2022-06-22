using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class SiegeFortressStruct
    {
        public SiegeFortressStruct()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FortressID { get; set; }

        public int OwnerGuildID { get; set; }

        public int RefEventStructID { get; set; }

        public int RefObjID { get; set; }

        public int Hp { get; set; }

        public DateTime MakeDate { get; set; }

        public short State { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
