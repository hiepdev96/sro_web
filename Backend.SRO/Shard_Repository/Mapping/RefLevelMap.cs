using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefLevelMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefLevel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefLevel> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefLevel", "dbo");

            // key
            builder.HasKey(t => t.Lvl);

            // properties
            builder.Property(t => t.Lvl)
                .IsRequired()
                .HasColumnName("Lvl")
                .HasColumnType("tinyint");

            builder.Property(t => t.ExpC)
                .IsRequired()
                .HasColumnName("Exp_C")
                .HasColumnType("bigint");

            builder.Property(t => t.ExpM)
                .IsRequired()
                .HasColumnName("Exp_M")
                .HasColumnType("int");

            builder.Property(t => t.CostM)
                .IsRequired()
                .HasColumnName("Cost_M")
                .HasColumnType("int");

            builder.Property(t => t.CostST)
                .IsRequired()
                .HasColumnName("Cost_ST")
                .HasColumnType("int");

            builder.Property(t => t.GUSTMobExp)
                .IsRequired()
                .HasColumnName("GUST_Mob_Exp")
                .HasColumnType("int");

            builder.Property(t => t.JobExpTrader)
                .HasColumnName("JobExp_Trader")
                .HasColumnType("int");

            builder.Property(t => t.JobExpRobber)
                .HasColumnName("JobExp_Robber")
                .HasColumnType("int");

            builder.Property(t => t.JobExpHunter)
                .HasColumnName("JobExp_Hunter")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefLevel";
        }

        public struct Columns
        {
            public const string Lvl = "Lvl";
            public const string ExpC = "Exp_C";
            public const string ExpM = "Exp_M";
            public const string CostM = "Cost_M";
            public const string CostST = "Cost_ST";
            public const string GUSTMobExp = "GUST_Mob_Exp";
            public const string JobExpTrader = "JobExp_Trader";
            public const string JobExpRobber = "JobExp_Robber";
            public const string JobExpHunter = "JobExp_Hunter";
        }
        #endregion
    }
}
