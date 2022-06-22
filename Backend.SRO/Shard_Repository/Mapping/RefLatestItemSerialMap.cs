using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefLatestItemSerialMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefLatestItemSerial>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefLatestItemSerial> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefLatestItemSerial", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.LatestItemSerial)
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
            public const string Name = "_RefLatestItemSerial";
        }

        public struct Columns
        {
            public const string LatestItemSerial = "LatestItemSerial";
        }
        #endregion
    }
}
