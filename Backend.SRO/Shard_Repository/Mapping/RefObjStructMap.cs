using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefObjStructMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefObjStruct>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefObjStruct> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefObjStruct", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DummyData)
                .IsRequired()
                .HasColumnName("Dummy_Data")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefObjStruct";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string DummyData = "Dummy_Data";
        }
        #endregion
    }
}
