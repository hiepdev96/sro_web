using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefCharGenMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefCharGen>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefCharGen> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefCharGen", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.RefObjID)
                .IsRequired()
                .HasColumnName("RefObjID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefCharGen";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string RefObjID = "RefObjID";
        }
        #endregion
    }
}
