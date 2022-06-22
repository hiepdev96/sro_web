using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefSiegeBlessBuff
    {
        public RefSiegeBlessBuff()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int BlessID { get; set; }

        public int FortressID { get; set; }

        public int RefBlessBuffID { get; set; }

        public long? NeedGold { get; set; }

        public int? NeedGP { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefSkill RefBlessBuffRefSkill { get; set; }

        public virtual RefSiegeFortress RefSiegeFortress { get; set; }

        #endregion

    }
}
