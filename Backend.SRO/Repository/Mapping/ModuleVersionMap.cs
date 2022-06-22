using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class ModuleVersionMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.ModuleVersion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.ModuleVersion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ModuleVersion", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NID)
                .IsRequired()
                .HasColumnName("nID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

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

            builder.Property(t => t.NVersion)
                .IsRequired()
                .HasColumnName("nVersion")
                .HasColumnType("int");

            builder.Property(t => t.SzVersion)
                .IsRequired()
                .HasColumnName("szVersion")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.SzDesc)
                .IsRequired()
                .HasColumnName("szDesc")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

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
            public const string Name = "_ModuleVersion";
        }

        public struct Columns
        {
            public const string NID = "nID";
            public const string NDivisionID = "nDivisionID";
            public const string NContentID = "nContentID";
            public const string NModuleID = "nModuleID";
            public const string NVersion = "nVersion";
            public const string SzVersion = "szVersion";
            public const string SzDesc = "szDesc";
            public const string NValid = "nValid";
        }
        #endregion
    }
}
