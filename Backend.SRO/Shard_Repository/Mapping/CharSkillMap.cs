using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharSkillMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharSkill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharSkill> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharSkill", "dbo");

            // key
            builder.HasKey(t => new { t.CharID, t.SkillID });

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.SkillID)
                .IsRequired()
                .HasColumnName("SkillID")
                .HasColumnType("int");

            builder.Property(t => t.Enable)
                .IsRequired()
                .HasColumnName("Enable")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("(1)");

            // relationships
            builder.HasOne(t => t.Char)
                .WithMany(t => t.CharSkills)
                .HasForeignKey(d => d.CharID)
                .HasConstraintName("FK__CharSkill__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharSkill";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string SkillID = "SkillID";
            public const string Enable = "Enable";
        }
        #endregion
    }
}
