using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefGameWorldMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefGameWorld>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefGameWorld> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefGame_World", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.WorldCodeName128)
                .IsRequired()
                .HasColumnName("WorldCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('INSTANC_WORLD_CODENAME')");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("tinyint");

            builder.Property(t => t.WorldMaxCount)
                .IsRequired()
                .HasColumnName("WorldMaxCount")
                .HasColumnType("smallint");

            builder.Property(t => t.WorldMaxUserCount)
                .IsRequired()
                .HasColumnName("WorldMaxUserCount")
                .HasColumnType("smallint");

            builder.Property(t => t.WorldEntryType)
                .IsRequired()
                .HasColumnName("WorldEntryType")
                .HasColumnType("tinyint");

            builder.Property(t => t.WorldEntranceType)
                .IsRequired()
                .HasColumnName("WorldEntranceType")
                .HasColumnType("tinyint");

            builder.Property(t => t.WorldLeaveType)
                .IsRequired()
                .HasColumnName("WorldLeaveType")
                .HasColumnType("tinyint");

            builder.Property(t => t.WorldDurationTime)
                .IsRequired()
                .HasColumnName("WorldDurationTime")
                .HasColumnType("int");

            builder.Property(t => t.WorldEmptyRemainTime)
                .IsRequired()
                .HasColumnName("WorldEmptyRemainTime")
                .HasColumnType("int");

            builder.Property(t => t.ConfigGroupCodeName128)
                .IsRequired()
                .HasColumnName("ConfigGroupCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefGame_World";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string WorldCodeName128 = "WorldCodeName128";
            public const string Type = "Type";
            public const string WorldMaxCount = "WorldMaxCount";
            public const string WorldMaxUserCount = "WorldMaxUserCount";
            public const string WorldEntryType = "WorldEntryType";
            public const string WorldEntranceType = "WorldEntranceType";
            public const string WorldLeaveType = "WorldLeaveType";
            public const string WorldDurationTime = "WorldDurationTime";
            public const string WorldEmptyRemainTime = "WorldEmptyRemainTime";
            public const string ConfigGroupCodeName128 = "ConfigGroupCodeName128";
        }
        #endregion
    }
}
