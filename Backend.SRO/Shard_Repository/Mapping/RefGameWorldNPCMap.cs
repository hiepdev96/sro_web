using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefGameWorldNPCMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefGameWorldNPC>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefGameWorldNPC> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefGameWorldNPC", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.WorldCodeName128)
                .IsRequired()
                .HasColumnName("WorldCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.NPCCodeName128)
                .IsRequired()
                .HasColumnName("NPCCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RegionID)
                .IsRequired()
                .HasColumnName("RegionID")
                .HasColumnType("smallint");

            builder.Property(t => t.PosX)
                .IsRequired()
                .HasColumnName("PosX")
                .HasColumnType("smallint");

            builder.Property(t => t.PosY)
                .IsRequired()
                .HasColumnName("PosY")
                .HasColumnType("smallint");

            builder.Property(t => t.PosZ)
                .IsRequired()
                .HasColumnName("PosZ")
                .HasColumnType("smallint");

            builder.Property(t => t.Param1)
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Param2)
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Param3)
                .HasColumnName("Param3")
                .HasColumnType("int");

            builder.Property(t => t.Param4)
                .HasColumnName("Param4")
                .HasColumnType("int");

            builder.Property(t => t.Param5)
                .HasColumnName("Param5")
                .HasColumnType("int");

            builder.Property(t => t.Param6)
                .HasColumnName("Param6")
                .HasColumnType("int");

            builder.Property(t => t.Param7)
                .HasColumnName("Param7")
                .HasColumnType("int");

            builder.Property(t => t.Param8)
                .HasColumnName("Param8")
                .HasColumnType("int");

            builder.Property(t => t.Param9)
                .HasColumnName("Param9")
                .HasColumnType("int");

            builder.Property(t => t.Param10)
                .HasColumnName("Param10")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefGameWorldNPC";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string WorldCodeName128 = "WorldCodeName128";
            public const string NPCCodeName128 = "NPCCodeName128";
            public const string RegionID = "RegionID";
            public const string PosX = "PosX";
            public const string PosY = "PosY";
            public const string PosZ = "PosZ";
            public const string Param1 = "Param1";
            public const string Param2 = "Param2";
            public const string Param3 = "Param3";
            public const string Param4 = "Param4";
            public const string Param5 = "Param5";
            public const string Param6 = "Param6";
            public const string Param7 = "Param7";
            public const string Param8 = "Param8";
            public const string Param9 = "Param9";
            public const string Param10 = "Param10";
        }
        #endregion
    }
}
