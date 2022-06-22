using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefMagicOptGroup
    {
        public RefMagicOptGroup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int LinkID { get; set; }

        public byte MagicType { get; set; }

        public string CodeName128 { get; set; }

        public int MOptID { get; set; }

        public byte MOptLevel { get; set; }

        public int Value { get; set; }

        public int Param1 { get; set; }

        public string Param1Desc { get; set; }

        public int Param2 { get; set; }

        public string Param2Desc { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
