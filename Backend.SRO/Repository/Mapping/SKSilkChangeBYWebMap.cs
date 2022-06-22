using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKSilkChangeBYWebMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKSilkChangeBYWeb>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKSilkChangeBYWeb> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_SilkChange_BY_Web", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.SilkRemain)
                .IsRequired()
                .HasColumnName("silk_remain")
                .HasColumnType("int");

            builder.Property(t => t.SilkOffset)
                .IsRequired()
                .HasColumnName("silk_offset")
                .HasColumnType("int");

            builder.Property(t => t.SilkType)
                .IsRequired()
                .HasColumnName("silk_type")
                .HasColumnType("tinyint");

            builder.Property(t => t.Reason)
                .IsRequired()
                .HasColumnName("reason")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_SilkChange_BY_Web";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Jid = "JID";
            public const string SilkRemain = "silk_remain";
            public const string SilkOffset = "silk_offset";
            public const string SilkType = "silk_type";
            public const string Reason = "reason";
        }
        #endregion
    }
}
