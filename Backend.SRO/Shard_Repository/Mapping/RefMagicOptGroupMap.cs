using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefMagicOptGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefMagicOptGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefMagicOptGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefMagicOptGroup", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.LinkID)
                .IsRequired()
                .HasColumnName("LinkID")
                .HasColumnType("int");

            builder.Property(t => t.MagicType)
                .IsRequired()
                .HasColumnName("MagicType")
                .HasColumnType("tinyint");

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.MOptID)
                .IsRequired()
                .HasColumnName("MOptID")
                .HasColumnType("int");

            builder.Property(t => t.MOptLevel)
                .IsRequired()
                .HasColumnName("MOptLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("Value")
                .HasColumnType("int");

            builder.Property(t => t.Param1)
                .IsRequired()
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Param1Desc)
                .IsRequired()
                .HasColumnName("Param1_Desc")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param2)
                .IsRequired()
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Param2Desc)
                .IsRequired()
                .HasColumnName("Param2_Desc")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefMagicOptGroup";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string LinkID = "LinkID";
            public const string MagicType = "MagicType";
            public const string CodeName128 = "CodeName128";
            public const string MOptID = "MOptID";
            public const string MOptLevel = "MOptLevel";
            public const string Value = "Value";
            public const string Param1 = "Param1";
            public const string Param1Desc = "Param1_Desc";
            public const string Param2 = "Param2";
            public const string Param2Desc = "Param2_Desc";
        }
        #endregion
    }
}
