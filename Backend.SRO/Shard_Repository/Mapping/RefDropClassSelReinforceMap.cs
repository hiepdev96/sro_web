using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDropClassSelReinforceMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDropClassSelReinforce>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDropClassSelReinforce> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDropClassSel_Reinforce", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.MonLevel)
                .IsRequired()
                .HasColumnName("MonLevel")
                .HasColumnType("int");

            builder.Property(t => t.ProbGroup1)
                .IsRequired()
                .HasColumnName("ProbGroup1")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup2)
                .IsRequired()
                .HasColumnName("ProbGroup2")
                .HasColumnType("real");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDropClassSel_Reinforce";
        }

        public struct Columns
        {
            public const string MonLevel = "MonLevel";
            public const string ProbGroup1 = "ProbGroup1";
            public const string ProbGroup2 = "ProbGroup2";
        }
        #endregion
    }
}
