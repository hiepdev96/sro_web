using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeBlessBuffMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeBlessBuff", "dbo");

            // key
            builder.HasKey(t => t.BlessID);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.BlessID)
                .IsRequired()
                .HasColumnName("BlessID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.RefBlessBuffID)
                .IsRequired()
                .HasColumnName("RefBlessBuffID")
                .HasColumnType("int");

            builder.Property(t => t.NeedGold)
                .HasColumnName("NeedGold")
                .HasColumnType("bigint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.NeedGP)
                .HasColumnName("NeedGP")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            // relationships
            builder.HasOne(t => t.RefSiegeFortress)
                .WithMany(t => t.RefSiegeBlessBuffs)
                .HasForeignKey(d => d.FortressID)
                .HasConstraintName("FK__FortressID");

            builder.HasOne(t => t.RefBlessBuffRefSkill)
                .WithMany(t => t.RefBlessBuffRefSiegeBlessBuffs)
                .HasForeignKey(d => d.RefBlessBuffID)
                .HasConstraintName("FK__RefBlessBuffID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeBlessBuff";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string BlessID = "BlessID";
            public const string FortressID = "FortressID";
            public const string RefBlessBuffID = "RefBlessBuffID";
            public const string NeedGold = "NeedGold";
            public const string NeedGP = "NeedGP";
        }
        #endregion
    }
}
