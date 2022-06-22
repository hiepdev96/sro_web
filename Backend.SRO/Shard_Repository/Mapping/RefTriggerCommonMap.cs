using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerCommonMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerCommon>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerCommon> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerCommon", "dbo");

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

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ObjName128)
                .IsRequired()
                .HasColumnName("ObjName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Tid1)
                .IsRequired()
                .HasColumnName("TID1")
                .HasColumnType("smallint");

            builder.Property(t => t.Tid2)
                .IsRequired()
                .HasColumnName("TID2")
                .HasColumnType("smallint");

            builder.Property(t => t.Tid3)
                .IsRequired()
                .HasColumnName("TID3")
                .HasColumnType("smallint");

            builder.Property(t => t.Tid4)
                .IsRequired()
                .HasColumnName("TID4")
                .HasColumnType("smallint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerCommon";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string ObjName128 = "ObjName128";
            public const string Tid1 = "TID1";
            public const string Tid2 = "TID2";
            public const string Tid3 = "TID3";
            public const string Tid4 = "TID4";
        }
        #endregion
    }
}
