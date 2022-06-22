using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class LoginLogoutStatisticsMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.LoginLogoutStatistics>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.LoginLogoutStatistics> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_LoginLogoutStatistics", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NIdx)
                .IsRequired()
                .HasColumnName("nIdx")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NJID)
                .IsRequired()
                .HasColumnName("nJID")
                .HasColumnType("int");

            builder.Property(t => t.NIP)
                .IsRequired()
                .HasColumnName("nIP")
                .HasColumnType("int");

            builder.Property(t => t.DLogin)
                .IsRequired()
                .HasColumnName("dLogin")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.DLogout)
                .IsRequired()
                .HasColumnName("dLogout")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.ByReserved)
                .IsRequired()
                .HasColumnName("byReserved")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_LoginLogoutStatistics";
        }

        public struct Columns
        {
            public const string NIdx = "nIdx";
            public const string NJID = "nJID";
            public const string NIP = "nIP";
            public const string DLogin = "dLogin";
            public const string DLogout = "dLogout";
            public const string ByReserved = "byReserved";
        }
        #endregion
    }
}
