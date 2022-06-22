using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKSilkMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKSilk>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKSilk> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_Silk", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.SilkOwn)
                .IsRequired()
                .HasColumnName("silk_own")
                .HasColumnType("int");

            builder.Property(t => t.SilkGift)
                .IsRequired()
                .HasColumnName("silk_gift")
                .HasColumnType("int");

            builder.Property(t => t.SilkPoint)
                .IsRequired()
                .HasColumnName("silk_point")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_Silk";
        }

        public struct Columns
        {
            public const string Jid = "JID";
            public const string SilkOwn = "silk_own";
            public const string SilkGift = "silk_gift";
            public const string SilkPoint = "silk_point";
        }
        #endregion
    }
}
