using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class SiegeFortressObjectMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.SiegeFortressObject>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.SiegeFortressObject> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SiegeFortressObject", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.OwnerGuildID)
                .IsRequired()
                .HasColumnName("OwnerGuildID")
                .HasColumnType("int");

            builder.Property(t => t.RefObjID)
                .IsRequired()
                .HasColumnName("RefObjID")
                .HasColumnType("int");

            builder.Property(t => t.Hp)
                .IsRequired()
                .HasColumnName("HP")
                .HasColumnType("int");

            builder.Property(t => t.Region)
                .IsRequired()
                .HasColumnName("Region")
                .HasColumnType("smallint");

            builder.Property(t => t.PosX)
                .IsRequired()
                .HasColumnName("PosX")
                .HasColumnType("real");

            builder.Property(t => t.PosY)
                .IsRequired()
                .HasColumnName("PosY")
                .HasColumnType("real");

            builder.Property(t => t.PosZ)
                .IsRequired()
                .HasColumnName("PosZ")
                .HasColumnType("real");

            builder.Property(t => t.Direction)
                .IsRequired()
                .HasColumnName("Direction")
                .HasColumnType("real");

            builder.Property(t => t.OwnerLevel)
                .IsRequired()
                .HasColumnName("OwnerLevel")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.SiegeFortress)
                .WithMany(t => t.SiegeFortressObjects)
                .HasForeignKey(d => d.FortressID)
                .HasConstraintName("FK__SiegeFortressObject__SiegeFortress");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SiegeFortressObject";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string FortressID = "FortressID";
            public const string OwnerGuildID = "OwnerGuildID";
            public const string RefObjID = "RefObjID";
            public const string Hp = "HP";
            public const string Region = "Region";
            public const string PosX = "PosX";
            public const string PosY = "PosY";
            public const string PosZ = "PosZ";
            public const string Direction = "Direction";
            public const string OwnerLevel = "OwnerLevel";
        }
        #endregion
    }
}
