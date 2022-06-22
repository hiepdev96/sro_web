using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SkShlMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SkShl>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SkShl> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_SHL", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Idx)
                .IsRequired()
                .HasColumnName("idx")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.Cos)
                .IsRequired()
                .HasColumnName("COS")
                .HasColumnType("int");

            builder.Property(t => t.Cgs)
                .IsRequired()
                .HasColumnName("CGS")
                .HasColumnType("int");

            builder.Property(t => t.Hos)
                .IsRequired()
                .HasColumnName("HOS")
                .HasColumnType("int");

            builder.Property(t => t.Hgs)
                .IsRequired()
                .HasColumnName("HGS")
                .HasColumnType("int");

            builder.Property(t => t.EventTime)
                .IsRequired()
                .HasColumnName("event_time")
                .HasColumnType("smalldatetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_SHL";
        }

        public struct Columns
        {
            public const string Idx = "idx";
            public const string Jid = "JID";
            public const string Cos = "COS";
            public const string Cgs = "CGS";
            public const string Hos = "HOS";
            public const string Hgs = "HGS";
            public const string EventTime = "event_time";
        }
        #endregion
    }
}
