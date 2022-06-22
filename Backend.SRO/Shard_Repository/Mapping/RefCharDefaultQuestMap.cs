using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefCharDefaultQuestMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefCharDefaultQuest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefCharDefaultQuest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefCharDefault_Quest", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Race)
                .IsRequired()
                .HasColumnName("Race")
                .HasColumnType("tinyint");

            builder.Property(t => t.CodeName)
                .IsRequired()
                .HasColumnName("CodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.RequiredLevel)
                .IsRequired()
                .HasColumnName("RequiredLevel")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefCharDefault_Quest";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string Race = "Race";
            public const string CodeName = "CodeName";
            public const string RequiredLevel = "RequiredLevel";
        }
        #endregion
    }
}
