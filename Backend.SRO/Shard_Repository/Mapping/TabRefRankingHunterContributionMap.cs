using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TabRefRankingHunterContributionMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Tab_RefRanking_HunterContribution", "dbo");

            // key
            builder.HasKey(t => t.Rank);

            // properties
            builder.Property(t => t.Rank)
                .IsRequired()
                .HasColumnName("Rank")
                .HasColumnType("tinyint");

            builder.Property(t => t.NickName)
                .IsRequired()
                .HasColumnName("NickName")
                .HasColumnType("varchar(17)")
                .HasMaxLength(17);

            builder.Property(t => t.JobLevel)
                .IsRequired()
                .HasColumnName("JobLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.Contribution)
                .IsRequired()
                .HasColumnName("Contribution")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Tab_RefRanking_HunterContribution";
        }

        public struct Columns
        {
            public const string Rank = "Rank";
            public const string NickName = "NickName";
            public const string JobLevel = "JobLevel";
            public const string Contribution = "Contribution";
        }
        #endregion
    }
}
