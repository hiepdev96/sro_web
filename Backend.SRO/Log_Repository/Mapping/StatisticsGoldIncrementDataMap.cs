using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Mapping
{
    public partial class StatisticsGoldIncrementDataMap
        : IEntityTypeConfiguration<VsroLog.Log_Repository.Entities.StatisticsGoldIncrementData>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroLog.Log_Repository.Entities.StatisticsGoldIncrementData> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("__StatisticsGoldIncrementData__", "sro_servers_vt");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BeginDate)
                .IsRequired()
                .HasColumnName("BeginDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Paid)
                .HasColumnName("Paid")
                .HasColumnType("bigint");

            builder.Property(t => t.Income)
                .HasColumnName("Income")
                .HasColumnType("bigint");

            builder.Property(t => t.HunterProfit)
                .HasColumnName("HunterProfit")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "sro_servers_vt";
            public const string Name = "__StatisticsGoldIncrementData__";
        }

        public struct Columns
        {
            public const string BeginDate = "BeginDate";
            public const string EndDate = "EndDate";
            public const string Paid = "Paid";
            public const string Income = "Income";
            public const string HunterProfit = "HunterProfit";
        }
        #endregion
    }
}
