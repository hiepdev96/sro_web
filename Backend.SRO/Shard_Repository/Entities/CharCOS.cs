using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class CharCOS
    {
        public CharCOS()
        {
            #region Generated Constructor
            CosidInvCOs = new HashSet<InvCOS>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int OwnerCharID { get; set; }

        public int RefCharID { get; set; }

        public int Hp { get; set; }

        public int Mp { get; set; }

        public int KeeperNPC { get; set; }

        public byte State { get; set; }

        public string CharName { get; set; }

        public byte Lvl { get; set; }

        public long ExpOffset { get; set; }

        public short Hgp { get; set; }

        public int PetOption { get; set; }

        public DateTime? RentEndTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<InvCOS> CosidInvCOs { get; set; }

        public virtual Char OwnerChar { get; set; }

        #endregion

    }
}
