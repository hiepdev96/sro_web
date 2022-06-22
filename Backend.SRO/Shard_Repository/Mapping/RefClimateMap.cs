using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefClimateMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefClimate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefClimate> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefClimate", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(t => t.InitialWeather)
                .IsRequired()
                .HasColumnName("InitialWeather")
                .HasColumnType("tinyint");

            builder.Property(t => t.InitialAmount)
                .IsRequired()
                .HasColumnName("InitialAmount")
                .HasColumnType("tinyint");

            builder.Property(t => t.ChangeWeather)
                .IsRequired()
                .HasColumnName("ChangeWeather")
                .HasColumnType("tinyint");

            builder.Property(t => t.Division)
                .IsRequired()
                .HasColumnName("Division")
                .HasColumnType("tinyint");

            builder.Property(t => t.Duration)
                .IsRequired()
                .HasColumnName("Duration")
                .HasColumnType("int");

            builder.Property(t => t.DurationVariance)
                .IsRequired()
                .HasColumnName("DurationVariance")
                .HasColumnType("int");

            builder.Property(t => t.Snowfall)
                .IsRequired()
                .HasColumnName("Snowfall")
                .HasColumnType("tinyint");

            builder.Property(t => t.SnowfallVariance)
                .IsRequired()
                .HasColumnName("SnowfallVariance")
                .HasColumnType("tinyint");

            builder.Property(t => t.ProbSnow)
                .IsRequired()
                .HasColumnName("ProbSnow")
                .HasColumnType("tinyint");

            builder.Property(t => t.Rainfall)
                .IsRequired()
                .HasColumnName("Rainfall")
                .HasColumnType("tinyint");

            builder.Property(t => t.RainfallVariance)
                .IsRequired()
                .HasColumnName("RainfallVariance")
                .HasColumnType("tinyint");

            builder.Property(t => t.ProbRain)
                .IsRequired()
                .HasColumnName("ProbRain")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefClimate";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string InitialWeather = "InitialWeather";
            public const string InitialAmount = "InitialAmount";
            public const string ChangeWeather = "ChangeWeather";
            public const string Division = "Division";
            public const string Duration = "Duration";
            public const string DurationVariance = "DurationVariance";
            public const string Snowfall = "Snowfall";
            public const string SnowfallVariance = "SnowfallVariance";
            public const string ProbSnow = "ProbSnow";
            public const string Rainfall = "Rainfall";
            public const string RainfallVariance = "RainfallVariance";
            public const string ProbRain = "ProbRain";
        }
        #endregion
    }
}
