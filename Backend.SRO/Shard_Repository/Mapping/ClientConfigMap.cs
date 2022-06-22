using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ClientConfigMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ClientConfig>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ClientConfig> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ClientConfig", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.ConfigType)
                .IsRequired()
                .HasColumnName("ConfigType")
                .HasColumnType("tinyint");

            builder.Property(t => t.SlotSeq)
                .IsRequired()
                .HasColumnName("SlotSeq")
                .HasColumnType("tinyint");

            builder.Property(t => t.SlotType)
                .IsRequired()
                .HasColumnName("SlotType")
                .HasColumnType("tinyint");

            builder.Property(t => t.Data)
                .IsRequired()
                .HasColumnName("Data")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ClientConfig";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string ConfigType = "ConfigType";
            public const string SlotSeq = "SlotSeq";
            public const string SlotType = "SlotType";
            public const string Data = "Data";
        }
        #endregion
    }
}
