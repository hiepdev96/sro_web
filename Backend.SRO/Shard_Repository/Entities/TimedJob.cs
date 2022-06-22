using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class TimedJob
    {
        public TimedJob()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int CharID { get; set; }

        public byte Category { get; set; }

        public int JobID { get; set; }

        public int TimeToKeep { get; set; }

        public int? Data1 { get; set; }

        public int? Data2 { get; set; }

        public int? Data3 { get; set; }

        public int? Data4 { get; set; }

        public int? Data5 { get; set; }

        public int? Data6 { get; set; }

        public int? Data7 { get; set; }

        public int? Data8 { get; set; }

        public long Serial64 { get; set; }

        public int? Jid { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        #endregion

    }
}
