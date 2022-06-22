using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKGamebangIpMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKGamebangIp>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKGamebangIp> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_gamebang_ip", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NID)
                .IsRequired()
                .HasColumnName("nID")
                .HasColumnType("smallint");

            builder.Property(t => t.Ip)
                .IsRequired()
                .HasColumnName("ip")
                .HasColumnType("int");

            builder.Property(t => t.Capacity)
                .IsRequired()
                .HasColumnName("capacity")
                .HasColumnType("smallint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_gamebang_ip";
        }

        public struct Columns
        {
            public const string NID = "nID";
            public const string Ip = "ip";
            public const string Capacity = "capacity";
        }
        #endregion
    }
}
