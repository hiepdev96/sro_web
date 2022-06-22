using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SecurityDescriptionMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SecurityDescription>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SecurityDescription> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SecurityDescription", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NID)
                .IsRequired()
                .HasColumnName("nID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SzName)
                .IsRequired()
                .HasColumnName("szName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

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
            public const string Name = "_SecurityDescription";
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
