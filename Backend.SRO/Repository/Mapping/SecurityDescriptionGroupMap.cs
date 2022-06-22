using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SecurityDescriptionGroupMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SecurityDescriptionGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SecurityDescriptionGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SecurityDescriptionGroup", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NID)
                .IsRequired()
                .HasColumnName("nID")
                .HasColumnType("tinyint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SzName)
                .IsRequired()
                .HasColumnName("szName")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.SzDesc)
                .IsRequired()
                .HasColumnName("szDesc")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SecurityDescriptionGroup";
        }

        public struct Columns
        {
            public const string NID = "nID";
            public const string SzName = "szName";
            public const string SzDesc = "szDesc";
        }
        #endregion
    }
}
