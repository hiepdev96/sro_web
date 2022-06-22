using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharTrijobMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharTrijob>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharTrijob> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharTrijob", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.JobType)
                .IsRequired()
                .HasColumnName("JobType")
                .HasColumnType("tinyint");

            builder.Property(t => t.Level)
                .IsRequired()
                .HasColumnName("Level")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("(1)");

            builder.Property(t => t.Exp)
                .IsRequired()
                .HasColumnName("Exp")
                .HasColumnType("int");

            builder.Property(t => t.Contribution)
                .IsRequired()
                .HasColumnName("Contribution")
                .HasColumnType("int");

            builder.Property(t => t.Reward)
                .IsRequired()
                .HasColumnName("Reward")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Char)
                .WithOne(t => t.CharTrijob)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.CharTrijob>(d => d.CharID)
                .HasConstraintName("FK__CharTrijob__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharTrijob";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string JobType = "JobType";
            public const string Level = "Level";
            public const string Exp = "Exp";
            public const string Contribution = "Contribution";
            public const string Reward = "Reward";
        }
        #endregion
    }
}
