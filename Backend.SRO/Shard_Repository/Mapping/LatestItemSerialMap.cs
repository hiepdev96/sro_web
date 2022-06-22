using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class LatestItemSerialMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.LatestItemSerial>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.LatestItemSerial> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_LatestItemSerial", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.LatestItemSerialMember)
                .IsRequired()
                .HasColumnName("LatestItemSerial")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_LatestItemSerial";
        }

        public struct Columns
        {
            public const string LatestItemSerialMember = "LatestItemSerial";
        }
        #endregion
    }
}
