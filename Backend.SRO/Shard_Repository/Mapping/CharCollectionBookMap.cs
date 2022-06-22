using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharCollectionBookMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharCollectionBook>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharCollectionBook> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharCollectionBook", "dbo");

            // key
            builder.HasKey(t => new { t.CharID, t.ThemeID, t.SlotIndex });

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.ThemeID)
                .IsRequired()
                .HasColumnName("ThemeID")
                .HasColumnType("int");

            builder.Property(t => t.SlotIndex)
                .IsRequired()
                .HasColumnName("SlotIndex")
                .HasColumnType("int");

            builder.Property(t => t.RegDate)
                .IsRequired()
                .HasColumnName("RegDate")
                .HasColumnType("smalldatetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharCollectionBook";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string ThemeID = "ThemeID";
            public const string SlotIndex = "SlotIndex";
            public const string RegDate = "RegDate";
        }
        #endregion
    }
}
