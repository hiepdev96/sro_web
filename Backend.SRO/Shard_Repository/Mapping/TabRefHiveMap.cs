using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TabRefHiveMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TabRefHive>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TabRefHive> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Tab_RefHive", "dbo");

            // key
            builder.HasKey(t => t.DwHiveID);

            // properties
            builder.Property(t => t.DwHiveID)
                .IsRequired()
                .HasColumnName("dwHiveID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.BtKeepMonsterCountType)
                .HasColumnName("btKeepMonsterCountType")
                .HasColumnType("tinyint");

            builder.Property(t => t.DwOverwriteMaxTotalCount)
                .HasColumnName("dwOverwriteMaxTotalCount")
                .HasColumnType("int");

            builder.Property(t => t.FMonsterCountPerPC)
                .HasColumnName("fMonsterCountPerPC")
                .HasColumnType("real");

            builder.Property(t => t.DwSpawnSpeedIncreaseRate)
                .HasColumnName("dwSpawnSpeedIncreaseRate")
                .HasColumnType("int");

            builder.Property(t => t.DwMaxIncreaseRate)
                .HasColumnName("dwMaxIncreaseRate")
                .HasColumnType("int");

            builder.Property(t => t.BtFlag)
                .HasColumnName("btFlag")
                .HasColumnType("tinyint");

            builder.Property(t => t.GameWorldID)
                .HasColumnName("GameWorldID")
                .HasColumnType("smallint");

            builder.Property(t => t.HatchObjType)
                .HasColumnName("HatchObjType")
                .HasColumnType("smallint");

            builder.Property(t => t.SzDescString128)
                .HasColumnName("szDescString128")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Tab_RefHive";
        }

        public struct Columns
        {
            public const string DwHiveID = "dwHiveID";
            public const string BtKeepMonsterCountType = "btKeepMonsterCountType";
            public const string DwOverwriteMaxTotalCount = "dwOverwriteMaxTotalCount";
            public const string FMonsterCountPerPC = "fMonsterCountPerPC";
            public const string DwSpawnSpeedIncreaseRate = "dwSpawnSpeedIncreaseRate";
            public const string DwMaxIncreaseRate = "dwMaxIncreaseRate";
            public const string BtFlag = "btFlag";
            public const string GameWorldID = "GameWorldID";
            public const string HatchObjType = "HatchObjType";
            public const string SzDescString128 = "szDescString128";
        }
        #endregion
    }
}
