using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TrijobRankingMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.TrijobRanking>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.TrijobRanking> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("__TrijobRanking__", "dbo");

            // key
            builder.HasKey(t => new { t.ShardID, t.TrijobType, t.RankType, t.Rank });

            // properties
            builder.Property(t => t.ShardID)
                .IsRequired()
                .HasColumnName("ShardID")
                .HasColumnType("int");

            builder.Property(t => t.TrijobType)
                .IsRequired()
                .HasColumnName("TrijobType")
                .HasColumnType("tinyint");

            builder.Property(t => t.RankType)
                .IsRequired()
                .HasColumnName("RankType")
                .HasColumnType("tinyint");

            builder.Property(t => t.Rank)
                .IsRequired()
                .HasColumnName("Rank")
                .HasColumnType("tinyint");

            builder.Property(t => t.NickName)
                .IsRequired()
                .HasColumnName("NickName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.JobLevel)
                .IsRequired()
                .HasColumnName("JobLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.JobData)
                .IsRequired()
                .HasColumnName("JobData")
                .HasColumnType("int");

            builder.Property(t => t.IsNewEntry)
                .IsRequired()
                .HasColumnName("IsNewEntry")
                .HasColumnType("tinyint");

            builder.Property(t => t.RankDelta)
                .IsRequired()
                .HasColumnName("RankDelta")
                .HasColumnType("smallint");

            builder.Property(t => t.Country)
                .IsRequired()
                .HasColumnName("Country")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "__TrijobRanking__";
        }

        public struct Columns
        {
            public const string ShardID = "ShardID";
            public const string TrijobType = "TrijobType";
            public const string RankType = "RankType";
            public const string Rank = "Rank";
            public const string NickName = "NickName";
            public const string JobLevel = "JobLevel";
            public const string JobData = "JobData";
            public const string IsNewEntry = "IsNewEntry";
            public const string RankDelta = "RankDelta";
            public const string Country = "Country";
        }
        #endregion
    }
}
