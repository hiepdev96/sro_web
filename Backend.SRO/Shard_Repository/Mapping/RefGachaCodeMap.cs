using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefGachaCodeMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefGachaCode>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefGachaCode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefGachaCode", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.GachaSetID)
                .IsRequired()
                .HasColumnName("GachaSetID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefGachaCode";
        }

        public struct Columns
        {
            public const string CodeName128 = "CodeName128";
            public const string GachaSetID = "GachaSetID";
        }
        #endregion
    }
}
