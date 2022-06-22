using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class ModuleVersionFile
    {
        public ModuleVersionFile()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int NID { get; set; }

        public int NVersion { get; set; }

        public byte NDivisionID { get; set; }

        public byte NContentID { get; set; }

        public byte NModuleID { get; set; }

        public string SzFilename { get; set; }

        public string SzPath { get; set; }

        public int NFileSize { get; set; }

        public byte NFileType { get; set; }

        public int NFileTypeVersion { get; set; }

        public byte NToBePacked { get; set; }

        public DateTime TimeModified { get; set; }

        public byte NValid { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
