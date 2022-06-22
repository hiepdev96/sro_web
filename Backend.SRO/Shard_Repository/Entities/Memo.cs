using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class Memo
    {
        public Memo()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id64 { get; set; }

        public int CharID { get; set; }

        public string FromCharName { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public byte Status { get; set; }

        public int? RefObjID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        #endregion

    }
}
