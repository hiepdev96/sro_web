using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TrainingCampSubMentorHonorPointMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TrainingCampSubMentorHonorPoint>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TrainingCampSubMentorHonorPoint> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_TrainingCampSubMentorHonorPoint", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.HonorPoint)
                .IsRequired()
                .HasColumnName("HonorPoint")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Char)
                .WithOne(t => t.TrainingCampSubMentorHonorPoint)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.TrainingCampSubMentorHonorPoint>(d => d.CharID)
                .HasConstraintName("FK__TrainingCampSubMentorHonorPoint__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_TrainingCampSubMentorHonorPoint";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string HonorPoint = "HonorPoint";
        }
        #endregion
    }
}
