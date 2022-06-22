using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefSiegeFortress
    {
        public RefSiegeFortress()
        {
            #region Generated Constructor
            RefSiegeBlessBuffs = new HashSet<RefSiegeBlessBuff>();
            RefSiegeFortressRewards = new HashSet<RefSiegeFortressRewards>();
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int FortressID { get; set; }

        public string CodeName128 { get; set; }

        public string Name { get; set; }

        public string NameID128 { get; set; }

        public string LinkedTeleportCodeName { get; set; }

        public byte Scale { get; set; }

        public short MaxAdmission { get; set; }

        public byte MaxGuard { get; set; }

        public byte MaxBarricade { get; set; }

        public short TaxTargets { get; set; }

        public int RequestFee { get; set; }

        public string CrestPath128 { get; set; }

        public string RequestNPCName128 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<RefSiegeBlessBuff> RefSiegeBlessBuffs { get; set; }

        public virtual ICollection<RefSiegeFortressRewards> RefSiegeFortressRewards { get; set; }

        #endregion

    }
}
