using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefInstanceWorldRegionMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefInstanceWorldRegion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefInstanceWorldRegion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefInstance_World_Region", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.WorldID)
                .IsRequired()
                .HasColumnName("WorldID")
                .HasColumnType("int");

            builder.Property(t => t.RegionID)
                .IsRequired()
                .HasColumnName("RegionID")
                .HasColumnType("smallint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefInstance_World_Region";
        }

        public struct Columns
        {
            public const string WorldID = "WorldID";
            public const string RegionID = "RegionID";
        }
        #endregion
    }
}
