using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefEventMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefEvent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefEvent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefEvent", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CodeName)
                .IsRequired()
                .HasColumnName("CodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.DescName)
                .IsRequired()
                .HasColumnName("DescName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.ScheduleName)
                .HasColumnName("ScheduleName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('')");

            builder.Property(t => t.ScheduleCount)
                .IsRequired()
                .HasColumnName("ScheduleCount")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefEvent";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName = "CodeName";
            public const string DescName = "DescName";
            public const string ScheduleName = "ScheduleName";
            public const string ScheduleCount = "ScheduleCount";
        }
        #endregion
    }
}
