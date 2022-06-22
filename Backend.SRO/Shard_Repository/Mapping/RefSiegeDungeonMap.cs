using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeDungeonMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeDungeon>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeDungeon> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeDungeon", "dbo");

            // key
            builder.HasKey(t => t.FortressID);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.WorldID)
                .IsRequired()
                .HasColumnName("WorldID")
                .HasColumnType("int");

            builder.Property(t => t.MaxCreateCount)
                .IsRequired()
                .HasColumnName("MaxCreateCount")
                .HasColumnType("tinyint");

            builder.Property(t => t.EntryGold)
                .IsRequired()
                .HasColumnName("EntryGold")
                .HasColumnType("bigint");

            builder.Property(t => t.EntryGP)
                .IsRequired()
                .HasColumnName("EntryGP")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeDungeon";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string FortressID = "FortressID";
            public const string WorldID = "WorldID";
            public const string MaxCreateCount = "MaxCreateCount";
            public const string EntryGold = "EntryGold";
            public const string EntryGP = "EntryGP";
        }
        #endregion
    }
}
