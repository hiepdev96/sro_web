using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefUIStringMtMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefUIStringMt>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefUIStringMt> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefUIString_Mt", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
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
                .HasColumnType("varchar(513)")
                .HasMaxLength(513);

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
            public const string Name = "_RefUIString_Mt";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string GroupCodeName128 = "GroupCodeName128";
            public const string ValueCodeName128 = "ValueCodeName128";
            public const string Value = "Value";
            public const string Type = "Type";
        }
        #endregion
    }
}
