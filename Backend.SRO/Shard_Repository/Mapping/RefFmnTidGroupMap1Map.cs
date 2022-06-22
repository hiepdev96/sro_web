using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefFmnTidGroupMap1Map
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefFmnTidGroupMap1>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefFmnTidGroupMap1> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefFmnTidGroupMap", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.TidGroupID)
                .IsRequired()
                .HasColumnName("TidGroupID")
                .HasColumnType("int");

            builder.Property(t => t.TypeID1)
                .IsRequired()
                .HasColumnName("TypeID1")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID2)
                .IsRequired()
                .HasColumnName("TypeID2")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID3)
                .IsRequired()
                .HasColumnName("TypeID3")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID4)
                .IsRequired()
                .HasColumnName("TypeID4")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefFmnTidGroupMap";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string TidGroupID = "TidGroupID";
            public const string TypeID1 = "TypeID1";
            public const string TypeID2 = "TypeID2";
            public const string TypeID3 = "TypeID3";
            public const string TypeID4 = "TypeID4";
        }
        #endregion
    }
}
