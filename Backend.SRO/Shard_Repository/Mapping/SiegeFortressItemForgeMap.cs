using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class SiegeFortressItemForgeMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SiegeFortressItemForge", "dbo");

            // key
            builder.HasKey(t => new { t.FortressID, t.ItemRefID });

            // properties
            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.ItemRefID)
                .IsRequired()
                .HasColumnName("ItemRefID")
                .HasColumnType("int");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("Amount")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(1)");

            builder.Property(t => t.Finished)
                .IsRequired()
                .HasColumnName("Finished")
                .HasColumnType("tinyint");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.FinishDate)
                .IsRequired()
                .HasColumnName("FinishDate")
                .HasColumnType("datetime");

            // relationships
            builder.HasOne(t => t.SiegeFortress)
                .WithMany(t => t.SiegeFortressItemForges)
                .HasForeignKey(d => d.FortressID)
                .HasConstraintName("FK__SiegeFortressItemForge__SiegeFortress");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SiegeFortressItemForge";
        }

        public struct Columns
        {
            public const string FortressID = "FortressID";
            public const string ItemRefID = "ItemRefID";
            public const string Amount = "Amount";
            public const string Finished = "Finished";
            public const string StartDate = "StartDate";
            public const string FinishDate = "FinishDate";
        }
        #endregion
    }
}
