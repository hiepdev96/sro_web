using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TestHNMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.TestHN>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.TestHN> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Test_HN", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Stt)
                .HasColumnName("STT")
                .HasColumnType("float");

            builder.Property(t => t.Username)
                .HasColumnName("Username")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CodeCB)
                .HasColumnName("CodeCB")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Họ)
                .HasColumnName("Họ")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Tên)
                .HasColumnName("Tên")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Password)
                .HasColumnName("password")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.FOnline)
                .HasColumnName("F_ONLINE")
                .HasColumnType("float");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Test_HN";
        }

        public struct Columns
        {
            public const string Stt = "STT";
            public const string Username = "Username";
            public const string CodeCB = "CodeCB";
            public const string Họ = "Họ";
            public const string Tên = "Tên";
            public const string Email = "Email";
            public const string Password = "password";
            public const string FOnline = "F_ONLINE";
        }
        #endregion
    }
}
