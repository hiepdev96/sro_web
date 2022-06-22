using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharTrijobSafeTradeMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharTrijobSafeTrade>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharTrijobSafeTrade> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharTrijobSafeTrade", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.AbleCount)
                .IsRequired()
                .HasColumnName("AbleCount")
                .HasColumnType("int");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.LastSafeTrade)
                .IsRequired()
                .HasColumnName("LastSafeTrade")
                .HasColumnType("datetime");

            // relationships
            builder.HasOne(t => t.CharTrijob)
                .WithOne(t => t.CharTrijobSafeTrade)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.CharTrijobSafeTrade>(d => d.CharID)
                .HasConstraintName("FK__CharTrijobSafeTrade__CharTrijob");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharTrijobSafeTrade";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string AbleCount = "AbleCount";
            public const string Status = "Status";
            public const string LastSafeTrade = "LastSafeTrade";
        }
        #endregion
    }
}
