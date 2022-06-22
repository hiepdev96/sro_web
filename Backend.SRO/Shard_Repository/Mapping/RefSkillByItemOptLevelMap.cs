using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSkillByItemOptLevelMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSkillByItemOptLevel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSkillByItemOptLevel> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSkillByItemOptLevel", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Link)
                .IsRequired()
                .HasColumnName("Link")
                .HasColumnType("int");

            builder.Property(t => t.RefSkillID)
                .IsRequired()
                .HasColumnName("RefSkillID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSkillByItemOptLevel";
        }

        public struct Columns
        {
            public const string Link = "Link";
            public const string RefSkillID = "RefSkillID";
        }
        #endregion
    }
}
