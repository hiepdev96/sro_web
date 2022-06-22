using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class PrivilegedIPMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.PrivilegedIP>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.PrivilegedIP> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_PrivilegedIP", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.IPBegin)
                .IsRequired()
                .HasColumnName("IP_Begin")
                .HasColumnType("int");

            builder.Property(t => t.IPEnd)
                .IsRequired()
                .HasColumnName("IP_End")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_PrivilegedIP";
        }

        public struct Columns
        {
            public const string IPBegin = "IP_Begin";
            public const string IPEnd = "IP_End";
        }
        #endregion
    }
}
