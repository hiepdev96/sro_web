using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class Friend
    {
        public Friend()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public int FriendCharID { get; set; }

        public string FriendCharName { get; set; }

        public int? RefObjID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        public virtual Char Char1 { get; set; }

        #endregion

    }
}
