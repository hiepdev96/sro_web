using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefRegionBindAssocServerMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefRegionBindAssocServer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefRegionBindAssocServer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefRegionBindAssocServer", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.AreaName)
                .IsRequired()
                .HasColumnName("AreaName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.AssocServer)
                .IsRequired()
                .HasColumnName("AssocServer")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefRegionBindAssocServer";
        }

        public struct Columns
        {
            public const string AreaName = "AreaName";
            public const string AssocServer = "AssocServer";
        }
        #endregion
    }
}
