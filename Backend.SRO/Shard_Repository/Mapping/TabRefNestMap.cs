using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TabRefNestMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TabRefNest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TabRefNest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Tab_RefNest", "dbo");

            // key
            builder.HasKey(t => t.DwNestID);

            // properties
            builder.Property(t => t.DwNestID)
                .IsRequired()
                .HasColumnName("dwNestID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DwHiveID)
                .IsRequired()
                .HasColumnName("dwHiveID")
                .HasColumnType("int");

            builder.Property(t => t.DwTacticsID)
                .IsRequired()
                .HasColumnName("dwTacticsID")
                .HasColumnType("int");

            builder.Property(t => t.NRegionDBID)
                .IsRequired()
                .HasColumnName("nRegionDBID")
                .HasColumnType("smallint");

            builder.Property(t => t.FLocalPosX)
                .HasColumnName("fLocalPosX")
                .HasColumnType("real");

            builder.Property(t => t.FLocalPosY)
                .HasColumnName("fLocalPosY")
                .HasColumnType("real");

            builder.Property(t => t.FLocalPosZ)
                .HasColumnName("fLocalPosZ")
                .HasColumnType("real");

            builder.Property(t => t.WInitialDir)
                .HasColumnName("wInitialDir")
                .HasColumnType("smallint");

            builder.Property(t => t.NRadius)
                .HasColumnName("nRadius")
                .HasColumnType("int");

            builder.Property(t => t.NGenerateRadius)
                .HasColumnName("nGenerateRadius")
                .HasColumnType("int");

            builder.Property(t => t.NChampionGenPercentage)
                .HasColumnName("nChampionGenPercentage")
                .HasColumnType("int");

            builder.Property(t => t.DwDelayTimeMin)
                .HasColumnName("dwDelayTimeMin")
                .HasColumnType("int");

            builder.Property(t => t.DwDelayTimeMax)
                .HasColumnName("dwDelayTimeMax")
                .HasColumnType("int");

            builder.Property(t => t.DwMaxTotalCount)
                .IsRequired()
                .HasColumnName("dwMaxTotalCount")
                .HasColumnType("int");

            builder.Property(t => t.BtFlag)
                .HasColumnName("btFlag")
                .HasColumnType("tinyint");

            builder.Property(t => t.BtRespawn)
                .IsRequired()
                .HasColumnName("btRespawn")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.BtType)
                .IsRequired()
                .HasColumnName("btType")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Tab_RefNest";
        }

        public struct Columns
        {
            public const string DwNestID = "dwNestID";
            public const string DwHiveID = "dwHiveID";
            public const string DwTacticsID = "dwTacticsID";
            public const string NRegionDBID = "nRegionDBID";
            public const string FLocalPosX = "fLocalPosX";
            public const string FLocalPosY = "fLocalPosY";
            public const string FLocalPosZ = "fLocalPosZ";
            public const string WInitialDir = "wInitialDir";
            public const string NRadius = "nRadius";
            public const string NGenerateRadius = "nGenerateRadius";
            public const string NChampionGenPercentage = "nChampionGenPercentage";
            public const string DwDelayTimeMin = "dwDelayTimeMin";
            public const string DwDelayTimeMax = "dwDelayTimeMax";
            public const string DwMaxTotalCount = "dwMaxTotalCount";
            public const string BtFlag = "btFlag";
            public const string BtRespawn = "btRespawn";
            public const string BtType = "btType";
        }
        #endregion
    }
}
