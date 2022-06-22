using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDropClassSelRecoverMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDropClassSelRecover>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDropClassSelRecover> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDropClassSel_Recover", "dbo");

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

            builder.Property(t => t.ProbGroup3)
                .IsRequired()
                .HasColumnName("ProbGroup3")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup4)
                .IsRequired()
                .HasColumnName("ProbGroup4")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup5)
                .IsRequired()
                .HasColumnName("ProbGroup5")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup6)
                .IsRequired()
                .HasColumnName("ProbGroup6")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup7)
                .IsRequired()
                .HasColumnName("ProbGroup7")
                .HasColumnType("real");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDropClassSel_Recover";
        }

        public struct Columns
        {
            public const string MonLevel = "MonLevel";
            public const string ProbGroup1 = "ProbGroup1";
            public const string ProbGroup2 = "ProbGroup2";
            public const string ProbGroup3 = "ProbGroup3";
            public const string ProbGroup4 = "ProbGroup4";
            public const string ProbGroup5 = "ProbGroup5";
            public const string ProbGroup6 = "ProbGroup6";
            public const string ProbGroup7 = "ProbGroup7";
        }
        #endregion
    }
}
