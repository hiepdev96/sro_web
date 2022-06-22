using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDummySlotMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDummySlot>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDummySlot> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDummySlot", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Cnt)
                .IsRequired()
                .HasColumnName("cnt")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDummySlot";
        }

        public struct Columns
        {
            public const string Cnt = "cnt";
        }
        #endregion
    }
}
