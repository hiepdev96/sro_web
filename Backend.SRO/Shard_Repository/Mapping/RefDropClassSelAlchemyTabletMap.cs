using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDropClassSelAlchemyTabletMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDropClassSelAlchemyTablet>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDropClassSelAlchemyTablet> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDropClassSel_Alchemy_Tablet", "dbo");

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

            builder.Property(t => t.ProbGroup8)
                .IsRequired()
                .HasColumnName("ProbGroup8")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup9)
                .IsRequired()
                .HasColumnName("ProbGroup9")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup10)
                .IsRequired()
                .HasColumnName("ProbGroup10")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup11)
                .IsRequired()
                .HasColumnName("ProbGroup11")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup12)
                .IsRequired()
                .HasColumnName("ProbGroup12")
                .HasColumnType("real");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDropClassSel_Alchemy_Tablet";
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
            public const string ProbGroup8 = "ProbGroup8";
            public const string ProbGroup9 = "ProbGroup9";
            public const string ProbGroup10 = "ProbGroup10";
            public const string ProbGroup11 = "ProbGroup11";
            public const string ProbGroup12 = "ProbGroup12";
        }
        #endregion
    }
}
