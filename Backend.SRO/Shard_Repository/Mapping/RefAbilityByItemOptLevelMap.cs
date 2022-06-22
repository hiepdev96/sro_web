using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefAbilityByItemOptLevelMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefAbilityByItemOptLevel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefAbilityByItemOptLevel> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefAbilityByItemOptLevel", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.ItemOptLevel)
                .IsRequired()
                .HasColumnName("ItemOptLevel")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefAbilityByItemOptLevel";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string RefItemID = "RefItemID";
            public const string ItemOptLevel = "ItemOptLevel";
        }
        #endregion
    }
}
