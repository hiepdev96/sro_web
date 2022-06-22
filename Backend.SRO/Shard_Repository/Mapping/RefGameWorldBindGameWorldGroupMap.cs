using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefGameWorldBindGameWorldGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefGameWorldBindGameWorldGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefGameWorldBindGameWorldGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefGameWorldBindGameWorldGroup", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.GameWorldID)
                .IsRequired()
                .HasColumnName("GameWorldID")
                .HasColumnType("int");

            builder.Property(t => t.GameWorldGroupID)
                .IsRequired()
                .HasColumnName("GameWorldGroupID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefGameWorldBindGameWorldGroup";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string GameWorldID = "GameWorldID";
            public const string GameWorldGroupID = "GameWorldGroupID";
        }
        #endregion
    }
}
