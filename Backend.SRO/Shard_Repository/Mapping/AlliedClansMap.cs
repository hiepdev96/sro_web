using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class AlliedClansMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.AlliedClans>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.AlliedClans> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_AlliedClans", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Ally1)
                .HasColumnName("Ally1")
                .HasColumnType("int");

            builder.Property(t => t.Ally2)
                .HasColumnName("Ally2")
                .HasColumnType("int");

            builder.Property(t => t.Ally3)
                .HasColumnName("Ally3")
                .HasColumnType("int");

            builder.Property(t => t.Ally4)
                .HasColumnName("Ally4")
                .HasColumnType("int");

            builder.Property(t => t.Ally5)
                .HasColumnName("Ally5")
                .HasColumnType("int");

            builder.Property(t => t.Ally6)
                .HasColumnName("Ally6")
                .HasColumnType("int");

            builder.Property(t => t.Ally7)
                .HasColumnName("Ally7")
                .HasColumnType("int");

            builder.Property(t => t.Ally8)
                .HasColumnName("Ally8")
                .HasColumnType("int");

            builder.Property(t => t.FoundationDate)
                .IsRequired()
                .HasColumnName("FoundationDate")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.LastCrestRev)
                .IsRequired()
                .HasColumnName("LastCrestRev")
                .HasColumnType("int");

            builder.Property(t => t.CurCrestRev)
                .IsRequired()
                .HasColumnName("CurCrestRev")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Ally1Guild)
                .WithMany(t => t.Ally1AlliedClans)
                .HasForeignKey(d => d.Ally1)
                .HasConstraintName("FK__AlliedClans__Guild");

            builder.HasOne(t => t.Ally2Guild)
                .WithMany(t => t.Ally2AlliedClans)
                .HasForeignKey(d => d.Ally2)
                .HasConstraintName("FK__AlliedClans__Guild1");

            builder.HasOne(t => t.Ally3Guild)
                .WithMany(t => t.Ally3AlliedClans)
                .HasForeignKey(d => d.Ally3)
                .HasConstraintName("FK__AlliedClans__Guild2");

            builder.HasOne(t => t.Ally4Guild)
                .WithMany(t => t.Ally4AlliedClans)
                .HasForeignKey(d => d.Ally4)
                .HasConstraintName("FK__AlliedClans__Guild3");

            builder.HasOne(t => t.Ally5Guild)
                .WithMany(t => t.Ally5AlliedClans)
                .HasForeignKey(d => d.Ally5)
                .HasConstraintName("FK__AlliedClans__Guild4");

            builder.HasOne(t => t.Ally6Guild)
                .WithMany(t => t.Ally6AlliedClans)
                .HasForeignKey(d => d.Ally6)
                .HasConstraintName("FK__AlliedClans__Guild5");

            builder.HasOne(t => t.Ally7Guild)
                .WithMany(t => t.Ally7AlliedClans)
                .HasForeignKey(d => d.Ally7)
                .HasConstraintName("FK__AlliedClans__Guild6");

            builder.HasOne(t => t.Ally8Guild)
                .WithMany(t => t.Ally8AlliedClans)
                .HasForeignKey(d => d.Ally8)
                .HasConstraintName("FK__AlliedClans__Guild7");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_AlliedClans";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Ally1 = "Ally1";
            public const string Ally2 = "Ally2";
            public const string Ally3 = "Ally3";
            public const string Ally4 = "Ally4";
            public const string Ally5 = "Ally5";
            public const string Ally6 = "Ally6";
            public const string Ally7 = "Ally7";
            public const string Ally8 = "Ally8";
            public const string FoundationDate = "FoundationDate";
            public const string LastCrestRev = "LastCrestRev";
            public const string CurCrestRev = "CurCrestRev";
        }
        #endregion
    }
}
