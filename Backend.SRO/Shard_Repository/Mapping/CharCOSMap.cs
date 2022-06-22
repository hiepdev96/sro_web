using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharCOSMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharCOS>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharCOS> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharCOS", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.OwnerCharID)
                .IsRequired()
                .HasColumnName("OwnerCharID")
                .HasColumnType("int");

            builder.Property(t => t.RefCharID)
                .IsRequired()
                .HasColumnName("RefCharID")
                .HasColumnType("int");

            builder.Property(t => t.Hp)
                .IsRequired()
                .HasColumnName("HP")
                .HasColumnType("int");

            builder.Property(t => t.Mp)
                .IsRequired()
                .HasColumnName("MP")
                .HasColumnType("int");

            builder.Property(t => t.KeeperNPC)
                .IsRequired()
                .HasColumnName("KeeperNPC")
                .HasColumnType("int");

            builder.Property(t => t.State)
                .IsRequired()
                .HasColumnName("State")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharName)
                .HasColumnName("CharName")
                .HasColumnType("varchar(16)")
                .HasMaxLength(16);

            builder.Property(t => t.Lvl)
                .IsRequired()
                .HasColumnName("Lvl")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.ExpOffset)
                .IsRequired()
                .HasColumnName("ExpOffset")
                .HasColumnType("bigint");

            builder.Property(t => t.Hgp)
                .IsRequired()
                .HasColumnName("HGP")
                .HasColumnType("smallint");

            builder.Property(t => t.PetOption)
                .IsRequired()
                .HasColumnName("PetOption")
                .HasColumnType("int");

            builder.Property(t => t.RentEndTime)
                .HasColumnName("RentEndTime")
                .HasColumnType("smalldatetime");

            // relationships
            builder.HasOne(t => t.OwnerChar)
                .WithMany(t => t.OwnerCharCOs)
                .HasForeignKey(d => d.OwnerCharID)
                .HasConstraintName("FK__CharCOS__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharCOS";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string OwnerCharID = "OwnerCharID";
            public const string RefCharID = "RefCharID";
            public const string Hp = "HP";
            public const string Mp = "MP";
            public const string KeeperNPC = "KeeperNPC";
            public const string State = "State";
            public const string CharName = "CharName";
            public const string Lvl = "Lvl";
            public const string ExpOffset = "ExpOffset";
            public const string Hgp = "HGP";
            public const string PetOption = "PetOption";
            public const string RentEndTime = "RentEndTime";
        }
        #endregion
    }
}
