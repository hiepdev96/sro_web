using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TrainingCampBuffStatusMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_TrainingCampBuffStatus", "dbo");

            // key
            builder.HasKey(t => new { t.CampID, t.RecipientCharID, t.BuffSlotIdx });

            // properties
            builder.Property(t => t.CampID)
                .IsRequired()
                .HasColumnName("CampID")
                .HasColumnType("int");

            builder.Property(t => t.RecipientCharID)
                .IsRequired()
                .HasColumnName("RecipientCharID")
                .HasColumnType("int");

            builder.Property(t => t.BuffSlotIdx)
                .IsRequired()
                .HasColumnName("BuffSlotIdx")
                .HasColumnType("tinyint");

            builder.Property(t => t.DonorCharID)
                .IsRequired()
                .HasColumnName("DonorCharID")
                .HasColumnType("int");

            builder.Property(t => t.StartingTime)
                .IsRequired()
                .HasColumnName("StartingTime")
                .HasColumnType("smalldatetime")
                .HasDefaultValueSql("('2000-01-01')");

            builder.Property(t => t.RemainBuffPoint)
                .IsRequired()
                .HasColumnName("RemainBuffPoint")
                .HasColumnType("int");

            builder.Property(t => t.BuffType)
                .IsRequired()
                .HasColumnName("BuffType")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_TrainingCampBuffStatus";
        }

        public struct Columns
        {
            public const string CampID = "CampID";
            public const string RecipientCharID = "RecipientCharID";
            public const string BuffSlotIdx = "BuffSlotIdx";
            public const string DonorCharID = "DonorCharID";
            public const string StartingTime = "StartingTime";
            public const string RemainBuffPoint = "RemainBuffPoint";
            public const string BuffType = "BuffType";
        }
        #endregion
    }
}
