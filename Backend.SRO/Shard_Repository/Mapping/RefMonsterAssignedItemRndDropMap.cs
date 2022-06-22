using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefMonsterAssignedItemRndDropMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemRndDrop>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemRndDrop> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefMonster_AssignedItemRndDrop", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.RefMonsterID)
                .IsRequired()
                .HasColumnName("RefMonsterID")
                .HasColumnType("int");

            builder.Property(t => t.RefItemGroupID)
                .IsRequired()
                .HasColumnName("RefItemGroupID")
                .HasColumnType("int");

            builder.Property(t => t.ItemGroupCodeName128)
                .IsRequired()
                .HasColumnName("ItemGroupCodeName128")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Overlap)
                .IsRequired()
                .HasColumnName("Overlap")
                .HasColumnType("tinyint");

            builder.Property(t => t.DropAmountMin)
                .IsRequired()
                .HasColumnName("DropAmountMin")
                .HasColumnType("tinyint");

            builder.Property(t => t.DropAmountMax)
                .IsRequired()
                .HasColumnName("DropAmountMax")
                .HasColumnType("tinyint");

            builder.Property(t => t.DropRatio)
                .IsRequired()
                .HasColumnName("DropRatio")
                .HasColumnType("real");

            builder.Property(t => t.Param1)
                .IsRequired()
                .HasColumnName("param1")
                .HasColumnType("int");

            builder.Property(t => t.Param2)
                .IsRequired()
                .HasColumnName("param2")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.RefMonsterRefObjCommon)
                .WithMany(t => t.RefMonsterRefMonsterAssignedItemRndDrops)
                .HasForeignKey(d => d.RefMonsterID)
                .HasConstraintName("FK__RefMonster_AssignedItemRndDrop__RefObjCommon");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefMonster_AssignedItemRndDrop";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string RefMonsterID = "RefMonsterID";
            public const string RefItemGroupID = "RefItemGroupID";
            public const string ItemGroupCodeName128 = "ItemGroupCodeName128";
            public const string Overlap = "Overlap";
            public const string DropAmountMin = "DropAmountMin";
            public const string DropAmountMax = "DropAmountMax";
            public const string DropRatio = "DropRatio";
            public const string Param1 = "param1";
            public const string Param2 = "param2";
        }
        #endregion
    }
}
