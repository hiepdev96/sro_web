using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefFmnTidGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefFmnTidGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefFmnTidGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefFmnTidGroup", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.TidGroupID)
                .IsRequired()
                .HasColumnName("TidGroupID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TidGroupName)
                .IsRequired()
                .HasColumnName("TidGroupName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefFmnTidGroup";
        }

        public struct Columns
        {
            public const string TidGroupID = "TidGroupID";
            public const string TidGroupName = "TidGroupName";
        }
        #endregion
    }
}
