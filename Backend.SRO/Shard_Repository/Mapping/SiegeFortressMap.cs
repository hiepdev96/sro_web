using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class SiegeFortressMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.SiegeFortress>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.SiegeFortress> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SiegeFortress", "dbo");

            // key
            builder.HasKey(t => t.FortressID);

            // properties
            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.GuildID)
                .IsRequired()
                .HasColumnName("GuildID")
                .HasColumnType("int");

            builder.Property(t => t.TaxRatio)
                .IsRequired()
                .HasColumnName("TaxRatio")
                .HasColumnType("smallint");

            builder.Property(t => t.Tax)
                .IsRequired()
                .HasColumnName("Tax")
                .HasColumnType("bigint");

            builder.Property(t => t.NPCHired)
                .IsRequired()
                .HasColumnName("NPCHired")
                .HasColumnType("tinyint");

            builder.Property(t => t.TempGuildID)
                .IsRequired()
                .HasColumnName("TempGuildID")
                .HasColumnType("int");

            builder.Property(t => t.Introduction)
                .HasColumnName("Introduction")
                .HasColumnType("varchar(120)")
                .HasMaxLength(120);

            builder.Property(t => t.CreatedDungeonTime)
                .HasColumnName("CreatedDungeonTime")
                .HasColumnType("datetime");

            builder.Property(t => t.CreatedDungeonCount)
                .HasColumnName("CreatedDungeonCount")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.IntroductionModificationPermission)
                .IsRequired()
                .HasColumnName("IntroductionModificationPermission")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("(1)");

            // relationships
            builder.HasOne(t => t.Guild)
                .WithMany(t => t.SiegeFortresses)
                .HasForeignKey(d => d.GuildID)
                .HasConstraintName("FK__SiegeFortress__Guild");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SiegeFortress";
        }

        public struct Columns
        {
            public const string FortressID = "FortressID";
            public const string GuildID = "GuildID";
            public const string TaxRatio = "TaxRatio";
            public const string Tax = "Tax";
            public const string NPCHired = "NPCHired";
            public const string TempGuildID = "TempGuildID";
            public const string Introduction = "Introduction";
            public const string CreatedDungeonTime = "CreatedDungeonTime";
            public const string CreatedDungeonCount = "CreatedDungeonCount";
            public const string IntroductionModificationPermission = "IntroductionModificationPermission";
        }
        #endregion
    }
}
