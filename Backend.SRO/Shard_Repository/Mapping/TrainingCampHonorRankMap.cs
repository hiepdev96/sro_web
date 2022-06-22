using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TrainingCampHonorRankMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_TrainingCampHonorRank", "dbo");

            // key
            builder.HasKey(t => t.Ranking);

            // properties
            builder.Property(t => t.Ranking)
                .IsRequired()
                .HasColumnName("Ranking")
                .HasColumnType("int");

            builder.Property(t => t.CampID)
                .HasColumnName("CampID")
                .HasColumnType("int");

            builder.Property(t => t.Rank)
                .HasColumnName("Rank")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_TrainingCampHonorRank";
        }

        public struct Columns
        {
            public const string Ranking = "Ranking";
            public const string CampID = "CampID";
            public const string Rank = "Rank";
        }
        #endregion
    }
}
