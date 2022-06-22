using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefShopItemGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefShopItemGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefShopItemGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefShopItemGroup", "dbo");

            // key
            builder.HasKey(t => t.GroupID);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.GroupID)
                .IsRequired()
                .HasColumnName("GroupID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.StrID128Group)
                .IsRequired()
                .HasColumnName("StrID128_Group")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefShopItemGroup";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string GroupID = "GroupID";
            public const string CodeName128 = "CodeName128";
            public const string StrID128Group = "StrID128_Group";
        }
        #endregion
    }
}
