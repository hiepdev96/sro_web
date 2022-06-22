using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class BrutalBlockedIPMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.BrutalBlockedIP>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.BrutalBlockedIP> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_BrutalBlockedIP", "dbo");

            // key
            builder.HasKey(t => t.NIdx);

            // properties
            builder.Property(t => t.NIdx)
                .IsRequired()
                .HasColumnName("nIdx")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SzIPBegin)
                .IsRequired()
                .HasColumnName("szIPBegin")
                .HasColumnType("varchar(16)")
                .HasMaxLength(16);

            builder.Property(t => t.SzIPEnd)
                .IsRequired()
                .HasColumnName("szIPEnd")
                .HasColumnType("varchar(16)")
                .HasMaxLength(16);

            builder.Property(t => t.SzGM)
                .IsRequired()
                .HasColumnName("szGM")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.DIssueDate)
                .IsRequired()
                .HasColumnName("dIssueDate")
                .HasColumnType("datetime");

            builder.Property(t => t.SzISP)
                .HasColumnName("szISP")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.SzDesc)
                .HasColumnName("szDesc")
                .HasColumnType("varchar(512)")
                .HasMaxLength(512);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_BrutalBlockedIP";
        }

        public struct Columns
        {
            public const string NIdx = "nIdx";
            public const string SzIPBegin = "szIPBegin";
            public const string SzIPEnd = "szIPEnd";
            public const string SzGM = "szGM";
            public const string DIssueDate = "dIssueDate";
            public const string SzISP = "szISP";
            public const string SzDesc = "szDesc";
        }
        #endregion
    }
}
