using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefEventZoneMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefEventZone>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefEventZone> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefEventZone", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ZoneName)
                .IsRequired()
                .HasColumnName("ZoneName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.EventName)
                .IsRequired()
                .HasColumnName("EventName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Param1)
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Param2)
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Param3)
                .HasColumnName("Param3")
                .HasColumnType("int");

            builder.Property(t => t.Param4)
                .HasColumnName("Param4")
                .HasColumnType("int");

            builder.Property(t => t.Param5)
                .HasColumnName("Param5")
                .HasColumnType("int");

            builder.Property(t => t.StrParam1)
                .HasColumnName("strParam1")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.StrParam2)
                .HasColumnName("strParam2")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.StrParam3)
                .HasColumnName("strParam3")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.StrParam4)
                .HasColumnName("strParam4")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.StrParam5)
                .HasColumnName("strParam5")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefEventZone";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string ZoneName = "ZoneName";
            public const string EventName = "EventName";
            public const string Param1 = "Param1";
            public const string Param2 = "Param2";
            public const string Param3 = "Param3";
            public const string Param4 = "Param4";
            public const string Param5 = "Param5";
            public const string StrParam1 = "strParam1";
            public const string StrParam2 = "strParam2";
            public const string StrParam3 = "strParam3";
            public const string StrParam4 = "strParam4";
            public const string StrParam5 = "strParam5";
        }
        #endregion
    }
}
