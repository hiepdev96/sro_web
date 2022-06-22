using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class RefCountryNameAndCodeMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.RefCountryNameAndCode>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.RefCountryNameAndCode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefCountryNameAndCode", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("code")
                .HasColumnType("char(2)")
                .HasMaxLength(2);

            builder.Property(t => t.SzCountryName)
                .IsRequired()
                .HasColumnName("szCountryName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefCountryNameAndCode";
        }

        public struct Columns
        {
            public const string Code = "code";
            public const string SzCountryName = "szCountryName";
        }
        #endregion
    }
}
