using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TestItemTNETMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TestItemTNET>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TestItemTNET> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("test_item_TNET", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .HasColumnName("id")
                .HasColumnType("float");

            builder.Property(t => t.CodeName)
                .HasColumnName("CodeName")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "test_item_TNET";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string CodeName = "CodeName";
        }
        #endregion
    }
}
