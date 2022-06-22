using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class SiegeFortressBattleRecordMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SiegeFortressBattleRecord", "dbo");

            // key
            builder.HasKey(t => new { t.FortressID, t.CharID });

            // properties
            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.KillCount)
                .IsRequired()
                .HasColumnName("KillCount")
                .HasColumnType("int");

            builder.Property(t => t.KilledCount)
                .IsRequired()
                .HasColumnName("KilledCount")
                .HasColumnType("int");

            builder.Property(t => t.RankUpDate)
                .IsRequired()
                .HasColumnName("RankUpDate")
                .HasColumnType("datetime");

            builder.Property(t => t.CurRank)
                .IsRequired()
                .HasColumnName("CurRank")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.SiegeFortress)
                .WithMany(t => t.SiegeFortressBattleRecords)
                .HasForeignKey(d => d.FortressID)
                .HasConstraintName("FK__SiegeFortressBattleRecord__SiegeFortress");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SiegeFortressBattleRecord";
        }

        public struct Columns
        {
            public const string FortressID = "FortressID";
            public const string CharID = "CharID";
            public const string KillCount = "KillCount";
            public const string KilledCount = "KilledCount";
            public const string RankUpDate = "RankUpDate";
            public const string CurRank = "CurRank";
        }
        #endregion
    }
}
