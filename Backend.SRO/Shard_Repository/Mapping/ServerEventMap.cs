using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ServerEventMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ServerEvent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ServerEvent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ServerEvent", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(t => t.CompletionValue)
                .IsRequired()
                .HasColumnName("CompletionValue")
                .HasColumnType("int");

            builder.Property(t => t.AchievementCondition)
                .IsRequired()
                .HasColumnName("AchievementCondition")
                .HasColumnType("int");

            builder.Property(t => t.ProgressCount)
                .IsRequired()
                .HasColumnName("ProgressCount")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ServerEvent";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string CompletionValue = "CompletionValue";
            public const string AchievementCondition = "AchievementCondition";
            public const string ProgressCount = "ProgressCount";
        }
        #endregion
    }
}
