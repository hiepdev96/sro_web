using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefQuestMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefQuest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefQuest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefQuest", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(t => t.CodeName)
                .IsRequired()
                .HasColumnName("CodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Level)
                .IsRequired()
                .HasColumnName("Level")
                .HasColumnType("tinyint");

            builder.Property(t => t.DescName)
                .IsRequired()
                .HasColumnName("DescName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.NameString)
                .IsRequired()
                .HasColumnName("NameString")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.PayString)
                .IsRequired()
                .HasColumnName("PayString")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.ContentsString)
                .IsRequired()
                .HasColumnName("ContentsString")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.PayContents)
                .IsRequired()
                .HasColumnName("PayContents")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.NoticeNPC)
                .IsRequired()
                .HasColumnName("NoticeNPC")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('')");

            builder.Property(t => t.NoticeCondition)
                .IsRequired()
                .HasColumnName("NoticeCondition")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('')");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefQuest";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName = "CodeName";
            public const string Level = "Level";
            public const string DescName = "DescName";
            public const string NameString = "NameString";
            public const string PayString = "PayString";
            public const string ContentsString = "ContentsString";
            public const string PayContents = "PayContents";
            public const string NoticeNPC = "NoticeNPC";
            public const string NoticeCondition = "NoticeCondition";
        }
        #endregion
    }
}
