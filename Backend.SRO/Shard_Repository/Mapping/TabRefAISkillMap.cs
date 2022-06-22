using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TabRefAISkillMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TabRefAISkill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TabRefAISkill> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Tab_RefAISkill", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.TacticsID)
                .IsRequired()
                .HasColumnName("TacticsID")
                .HasColumnType("int");

            builder.Property(t => t.SkillCodeName)
                .IsRequired()
                .HasColumnName("SkillCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ExcuteConditionType)
                .IsRequired()
                .HasColumnName("ExcuteConditionType")
                .HasColumnType("tinyint");

            builder.Property(t => t.ExcuteConditionData)
                .HasColumnName("ExcuteConditionData")
                .HasColumnType("int");

            builder.Property(t => t.Option)
                .HasColumnName("Option")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Tab_RefAISkill";
        }

        public struct Columns
        {
            public const string TacticsID = "TacticsID";
            public const string SkillCodeName = "SkillCodeName";
            public const string ExcuteConditionType = "ExcuteConditionType";
            public const string ExcuteConditionData = "ExcuteConditionData";
            public const string Option = "Option";
        }
        #endregion
    }
}
