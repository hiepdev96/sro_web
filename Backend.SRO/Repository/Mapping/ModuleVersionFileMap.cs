using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class ModuleVersionFileMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.ModuleVersionFile>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.ModuleVersionFile> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ModuleVersionFile", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NID)
                .IsRequired()
                .HasColumnName("nID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NVersion)
                .IsRequired()
                .HasColumnName("nVersion")
                .HasColumnType("int");

            builder.Property(t => t.NDivisionID)
                .IsRequired()
                .HasColumnName("nDivisionID")
                .HasColumnType("tinyint");

            builder.Property(t => t.NContentID)
                .IsRequired()
                .HasColumnName("nContentID")
                .HasColumnType("tinyint");

            builder.Property(t => t.NModuleID)
                .IsRequired()
                .HasColumnName("nModuleID")
                .HasColumnType("tinyint");

            builder.Property(t => t.SzFilename)
                .IsRequired()
                .HasColumnName("szFilename")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.SzPath)
                .IsRequired()
                .HasColumnName("szPath")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.NFileSize)
                .IsRequired()
                .HasColumnName("nFileSize")
                .HasColumnType("int");

            builder.Property(t => t.NFileType)
                .IsRequired()
                .HasColumnName("nFileType")
                .HasColumnType("tinyint");

            builder.Property(t => t.NFileTypeVersion)
                .IsRequired()
                .HasColumnName("nFileTypeVersion")
                .HasColumnType("int");

            builder.Property(t => t.NToBePacked)
                .IsRequired()
                .HasColumnName("nToBePacked")
                .HasColumnType("tinyint");

            builder.Property(t => t.TimeModified)
                .IsRequired()
                .HasColumnName("timeModified")
                .HasColumnType("datetime");

            builder.Property(t => t.NValid)
                .IsRequired()
                .HasColumnName("nValid")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ModuleVersionFile";
        }

        public struct Columns
        {
            public const string NID = "nID";
            public const string NVersion = "nVersion";
            public const string NDivisionID = "nDivisionID";
            public const string NContentID = "nContentID";
            public const string NModuleID = "nModuleID";
            public const string SzFilename = "szFilename";
            public const string SzPath = "szPath";
            public const string NFileSize = "nFileSize";
            public const string NFileType = "nFileType";
            public const string NFileTypeVersion = "nFileTypeVersion";
            public const string NToBePacked = "nToBePacked";
            public const string TimeModified = "timeModified";
            public const string NValid = "nValid";
        }
        #endregion
    }
}
