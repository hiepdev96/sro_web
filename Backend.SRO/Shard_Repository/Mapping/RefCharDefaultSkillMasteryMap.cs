using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefCharDefaultSkillMasteryMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefCharDefaultSkillMastery>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefCharDefaultSkillMastery> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefCharDefault_SkillMastery", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Race)
                .IsRequired()
                .HasColumnName("Race")
                .HasColumnType("tinyint");

            builder.Property(t => t.MasteryID)
                .IsRequired()
                .HasColumnName("MasteryID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefCharDefault_SkillMastery";
        }

        public struct Columns
        {
            public const string Race = "Race";
            public const string MasteryID = "MasteryID";
        }
        #endregion
    }
}
