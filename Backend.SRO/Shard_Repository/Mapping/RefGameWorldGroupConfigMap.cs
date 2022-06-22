using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefGameWorldGroupConfigMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefGameWorldGroupConfig>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefGameWorldGroupConfig> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefGameWorldGroup_Config", "dbo");

            // key
            builder.HasNoKey();

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

            builder.Property(t => t.GroupCodeName128)
                .IsRequired()
                .HasColumnName("GroupCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ValueCodeName128)
                .IsRequired()
                .HasColumnName("ValueCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("Value")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefGameWorldGroup_Config";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string GroupCodeName128 = "GroupCodeName128";
            public const string ValueCodeName128 = "ValueCodeName128";
            public const string Value = "Value";
            public const string Type = "Type";
        }
        #endregion
    }
}
