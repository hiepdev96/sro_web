using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefRegionMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefRegion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefRegion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefRegion", "dbo");

            // key
            builder.HasKey(t => t.WRegionID);

            // properties
            builder.Property(t => t.WRegionID)
                .IsRequired()
                .HasColumnName("wRegionID")
                .HasColumnType("smallint");

            builder.Property(t => t.X)
                .IsRequired()
                .HasColumnName("X")
                .HasColumnType("tinyint");

            builder.Property(t => t.Z)
                .IsRequired()
                .HasColumnName("Z")
                .HasColumnType("tinyint");

            builder.Property(t => t.ContinentName)
                .IsRequired()
                .HasColumnName("ContinentName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.AreaName)
                .IsRequired()
                .HasColumnName("AreaName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.IsBattleField)
                .IsRequired()
                .HasColumnName("IsBattleField")
                .HasColumnType("tinyint");

            builder.Property(t => t.Climate)
                .IsRequired()
                .HasColumnName("Climate")
                .HasColumnType("int");

            builder.Property(t => t.MaxCapacity)
                .IsRequired()
                .HasColumnName("MaxCapacity")
                .HasColumnType("int");

            builder.Property(t => t.AssocObjID)
                .IsRequired()
                .HasColumnName("AssocObjID")
                .HasColumnType("int");

            builder.Property(t => t.AssocServer)
                .IsRequired()
                .HasColumnName("AssocServer")
                .HasColumnType("int");

            builder.Property(t => t.AssocFile256)
                .IsRequired()
                .HasColumnName("AssocFile256")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.LinkedRegion1)
                .HasColumnName("LinkedRegion_1")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion2)
                .HasColumnName("LinkedRegion_2")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion3)
                .HasColumnName("LinkedRegion_3")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion4)
                .HasColumnName("LinkedRegion_4")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion5)
                .HasColumnName("LinkedRegion_5")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion6)
                .HasColumnName("LinkedRegion_6")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion7)
                .HasColumnName("LinkedRegion_7")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion8)
                .HasColumnName("LinkedRegion_8")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion9)
                .HasColumnName("LinkedRegion_9")
                .HasColumnType("int");

            builder.Property(t => t.LinkedRegion10)
                .HasColumnName("LinkedRegion_10")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefRegion";
        }

        public struct Columns
        {
            public const string WRegionID = "wRegionID";
            public const string X = "X";
            public const string Z = "Z";
            public const string ContinentName = "ContinentName";
            public const string AreaName = "AreaName";
            public const string IsBattleField = "IsBattleField";
            public const string Climate = "Climate";
            public const string MaxCapacity = "MaxCapacity";
            public const string AssocObjID = "AssocObjID";
            public const string AssocServer = "AssocServer";
            public const string AssocFile256 = "AssocFile256";
            public const string LinkedRegion1 = "LinkedRegion_1";
            public const string LinkedRegion2 = "LinkedRegion_2";
            public const string LinkedRegion3 = "LinkedRegion_3";
            public const string LinkedRegion4 = "LinkedRegion_4";
            public const string LinkedRegion5 = "LinkedRegion_5";
            public const string LinkedRegion6 = "LinkedRegion_6";
            public const string LinkedRegion7 = "LinkedRegion_7";
            public const string LinkedRegion8 = "LinkedRegion_8";
            public const string LinkedRegion9 = "LinkedRegion_9";
            public const string LinkedRegion10 = "LinkedRegion_10";
        }
        #endregion
    }
}
