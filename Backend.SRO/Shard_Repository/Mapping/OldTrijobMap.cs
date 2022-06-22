using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class OldTrijobMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.OldTrijob>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.OldTrijob> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_OldTrijob", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.JobLvlTrader)
                .IsRequired()
                .HasColumnName("JobLvl_Trader")
                .HasColumnType("tinyint");

            builder.Property(t => t.TraderExp)
                .IsRequired()
                .HasColumnName("Trader_Exp")
                .HasColumnType("int");

            builder.Property(t => t.JobLvlRobber)
                .IsRequired()
                .HasColumnName("JobLvl_Robber")
                .HasColumnType("tinyint");

            builder.Property(t => t.RobberExp)
                .IsRequired()
                .HasColumnName("Robber_Exp")
                .HasColumnType("int");

            builder.Property(t => t.JobLvlHunter)
                .IsRequired()
                .HasColumnName("JobLvl_Hunter")
                .HasColumnType("tinyint");

            builder.Property(t => t.HunterExp)
                .IsRequired()
                .HasColumnName("Hunter_Exp")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_OldTrijob";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string JobLvlTrader = "JobLvl_Trader";
            public const string TraderExp = "Trader_Exp";
            public const string JobLvlRobber = "JobLvl_Robber";
            public const string RobberExp = "Robber_Exp";
            public const string JobLvlHunter = "JobLvl_Hunter";
            public const string HunterExp = "Hunter_Exp";
        }
        #endregion
    }
}
