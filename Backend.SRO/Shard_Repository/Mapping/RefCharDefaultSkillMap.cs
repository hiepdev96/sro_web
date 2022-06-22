using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefCharDefaultSkillMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefCharDefaultSkill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefCharDefaultSkill> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefCharDefault_Skill", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Race)
                .IsRequired()
                .HasColumnName("Race")
                .HasColumnType("tinyint");

            builder.Property(t => t.SkillID)
                .IsRequired()
                .HasColumnName("SkillID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefCharDefault_Skill";
        }

        public struct Columns
        {
            public const string Race = "Race";
            public const string SkillID = "SkillID";
        }
        #endregion
    }
}
