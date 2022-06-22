using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefTeleport1
    {
        public RefTeleport1()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Service { get; set; }

        public int Id { get; set; }

        public string CodeName128 { get; set; }

        public string AssocRefObjCodeName128 { get; set; }

        public int AssocRefObjID { get; set; }

        public string ZoneName128 { get; set; }

        public short GenRegionID { get; set; }

        public short GenPosX { get; set; }

        public short GenPosY { get; set; }

        public short GenPosZ { get; set; }

        public short GenAreaRadius { get; set; }

        public byte CanBeResurrectPos { get; set; }

        public byte CanGotoResurrectPos { get; set; }

        public short GenWorldID { get; set; }

        public byte BindInteractionMask { get; set; }

        public byte FixedService { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
