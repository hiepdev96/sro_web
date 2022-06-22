using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class ModuleVersion
    {
        public ModuleVersion()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int NID { get; set; }

        public byte NDivisionID { get; set; }

        public byte NContentID { get; set; }

        public byte NModuleID { get; set; }

        public int NVersion { get; set; }

        public string SzVersion { get; set; }

        public string SzDesc { get; set; }

        public byte NValid { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
