using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDropOptLvlSelMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDropOptLvlSel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDropOptLvlSel> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDropOptLvlSel", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.OptLevel)
                .IsRequired()
                .HasColumnName("OptLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.Prob)
                .IsRequired()
                .HasColumnName("Prob")
                .HasColumnType("real");

            builder.Property(t => t.ReqOnlineTime)
                .IsRequired()
                .HasColumnName("ReqOnlineTime")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDropOptLvlSel";
        }

        public struct Columns
        {
            public const string OptLevel = "OptLevel";
            public const string Prob = "Prob";
            public const string ReqOnlineTime = "ReqOnlineTime";
        }
        #endregion
    }
}
