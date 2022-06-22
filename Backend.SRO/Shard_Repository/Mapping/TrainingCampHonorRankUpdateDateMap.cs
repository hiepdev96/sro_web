using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TrainingCampHonorRankUpdateDateMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TrainingCampHonorRankUpdateDate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TrainingCampHonorRankUpdateDate> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_TrainingCampHonorRankUpdateDate", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.LastUpdateDate)
                .HasColumnName("LastUpdateDate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_TrainingCampHonorRankUpdateDate";
        }

        public struct Columns
        {
            public const string LastUpdateDate = "LastUpdateDate";
        }
        #endregion
    }
}
