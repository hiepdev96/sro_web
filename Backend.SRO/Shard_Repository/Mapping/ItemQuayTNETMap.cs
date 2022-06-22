using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ItemQuayTNETMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ItemQuayTNET>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ItemQuayTNET> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Item_Quay_TNET", "dbo");

            // key
            builder.HasNoKey();

            // properties
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
            public const string Name = "Item_Quay_TNET";
        }

        public struct Columns
        {
            public const string CodeName = "CodeName";
        }
        #endregion
    }
}
