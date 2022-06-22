using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefScheduleDefineMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefScheduleDefine>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefScheduleDefine> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefScheduleDefine", "dbo");

            // key
            builder.HasKey(t => t.ScheduleDefineIdx);

            // properties
            builder.Property(t => t.ScheduleDefineIdx)
                .IsRequired()
                .HasColumnName("ScheduleDefineIdx")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ScheduleName)
                .IsRequired()
                .HasColumnName("ScheduleName")
                .HasColumnType("varchar(124)")
                .HasMaxLength(124);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(2000)")
                .HasMaxLength(2000);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefScheduleDefine";
        }

        public struct Columns
        {
            public const string ScheduleDefineIdx = "ScheduleDefineIdx";
            public const string ScheduleName = "ScheduleName";
            public const string Description = "Description";
        }
        #endregion
    }
}
