using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class FleaMarketNetwork
    {
        public FleaMarketNetwork()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte AbleOpen { get; set; }

        public int CharID { get; set; }

        public byte Slot { get; set; }

        public int TidGroupID { get; set; }

        public byte ItemClass { get; set; }

        public int ItemCount { get; set; }

        public byte MakeZone { get; set; }

        public long Cash { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        #endregion

    }
}
