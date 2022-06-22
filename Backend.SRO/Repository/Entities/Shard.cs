using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class Shard
    {
        public Shard()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public short NID { get; set; }

        public byte NFarmID { get; set; }

        public byte NContentID { get; set; }

        public string SzName { get; set; }

        public string SzDesc { get; set; }

        public string SzDBConfig { get; set; }

        public short NMaxUser { get; set; }

        public short NStartupServerID { get; set; }

        public byte NStatus { get; set; }

        public byte NCurrentUserRatio { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
