using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeFortressBattleRankMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeFortressBattleRank", "dbo");

            // key
            builder.HasKey(t => t.RankLvl);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.RankLvl)
                .IsRequired()
                .HasColumnName("RankLvl")
                .HasColumnType("tinyint");

            builder.Property(t => t.RankName)
                .IsRequired()
                .HasColumnName("RankName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqPKCount)
                .IsRequired()
                .HasColumnName("ReqPKCount")
                .HasColumnType("int");

            builder.Property(t => t.BindedSkillID)
                .IsRequired()
                .HasColumnName("BindedSkillID")
                .HasColumnType("int");

            builder.Property(t => t.CrestPath128)
                .IsRequired()
                .HasColumnName("CrestPath128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeFortressBattleRank";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string RankLvl = "RankLvl";
            public const string RankName = "RankName";
            public const string ReqPKCount = "ReqPKCount";
            public const string BindedSkillID = "BindedSkillID";
            public const string CrestPath128 = "CrestPath128";
        }
        #endregion
    }
}
