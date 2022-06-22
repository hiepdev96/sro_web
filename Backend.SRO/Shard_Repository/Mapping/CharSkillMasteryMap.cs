using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharSkillMasteryMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharSkillMastery>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharSkillMastery> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharSkillMastery", "dbo");

            // key
            builder.HasKey(t => new { t.CharID, t.MasteryID });

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.MasteryID)
                .IsRequired()
                .HasColumnName("MasteryID")
                .HasColumnType("int");

            builder.Property(t => t.Level)
                .IsRequired()
                .HasColumnName("Level")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.Char)
                .WithMany(t => t.CharSkillMasteries)
                .HasForeignKey(d => d.CharID)
                .HasConstraintName("FK__CharSkillMastery__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharSkillMastery";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string MasteryID = "MasteryID";
            public const string Level = "Level";
        }
        #endregion
    }
}
