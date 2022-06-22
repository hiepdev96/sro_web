using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TrainingCampMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TrainingCamp>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TrainingCamp> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_TrainingCamp", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CreationDate)
                .IsRequired()
                .HasColumnName("CreationDate")
                .HasColumnType("smalldatetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.Rank)
                .IsRequired()
                .HasColumnName("Rank")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("(5)");

            builder.Property(t => t.GraduateCount)
                .IsRequired()
                .HasColumnName("GraduateCount")
                .HasColumnType("int");

            builder.Property(t => t.EvaluationPoint)
                .IsRequired()
                .HasColumnName("EvaluationPoint")
                .HasColumnType("int");

            builder.Property(t => t.LatestEvaluationDate)
                .IsRequired()
                .HasColumnName("LatestEvaluationDate")
                .HasColumnType("datetime");

            builder.Property(t => t.CommentTitle)
                .HasColumnName("CommentTitle")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Comment)
                .HasColumnName("Comment")
                .HasColumnType("varchar(2048)")
                .HasMaxLength(2048);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_TrainingCamp";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string CreationDate = "CreationDate";
            public const string Rank = "Rank";
            public const string GraduateCount = "GraduateCount";
            public const string EvaluationPoint = "EvaluationPoint";
            public const string LatestEvaluationDate = "LatestEvaluationDate";
            public const string CommentTitle = "CommentTitle";
            public const string Comment = "Comment";
        }
        #endregion
    }
}
