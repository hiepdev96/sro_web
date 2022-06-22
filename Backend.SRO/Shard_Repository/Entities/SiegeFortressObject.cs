using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class SiegeFortressObject
    {
        public SiegeFortressObject()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int FortressID { get; set; }

        public int OwnerGuildID { get; set; }

        public int RefObjID { get; set; }

        public int Hp { get; set; }

        public short Region { get; set; }

        public float PosX { get; set; }

        public float PosY { get; set; }

        public float PosZ { get; set; }

        public float Direction { get; set; }

        public byte OwnerLevel { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SiegeFortress SiegeFortress { get; set; }

        #endregion

    }
}
