using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefMonsterAssignedItemDropMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemDrop>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemDrop> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefMonster_AssignedItemDrop", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.RefMonsterID)
                .IsRequired()
                .HasColumnName("RefMonsterID")
                .HasColumnType("int");

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.DropGroupType)
                .IsRequired()
                .HasColumnName("DropGroupType")
                .HasColumnType("tinyint");

            builder.Property(t => t.OptLevel)
                .IsRequired()
                .HasColumnName("OptLevel")
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

            builder.Property(t => t.RefMagicOptionID1)
                .HasColumnName("RefMagicOptionID1")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue1)
                .HasColumnName("CustomValue1")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RefMagicOptionID2)
                .HasColumnName("RefMagicOptionID2")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue2)
                .HasColumnName("CustomValue2")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RefMagicOptionID3)
                .HasColumnName("RefMagicOptionID3")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue3)
                .HasColumnName("CustomValue3")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RefMagicOptionID4)
                .HasColumnName("RefMagicOptionID4")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue4)
                .HasColumnName("CustomValue4")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RefMagicOptionID5)
                .HasColumnName("RefMagicOptionID5")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue5)
                .HasColumnName("CustomValue5")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RefMagicOptionID6)
                .HasColumnName("RefMagicOptionID6")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue6)
                .HasColumnName("CustomValue6")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RefMagicOptionID7)
                .HasColumnName("RefMagicOptionID7")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue7)
                .HasColumnName("CustomValue7")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RefMagicOptionID8)
                .HasColumnName("RefMagicOptionID8")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue8)
                .HasColumnName("CustomValue8")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RefMagicOptionID9)
                .HasColumnName("RefMagicOptionID9")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.CustomValue9)
                .HasColumnName("CustomValue9")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.RentCodeName)
                .IsRequired()
                .HasColumnName("RentCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            // relationships
            builder.HasOne(t => t.RefMonsterRefObjCommon)
                .WithMany(t => t.RefMonsterRefMonsterAssignedItemDrops)
                .HasForeignKey(d => d.RefMonsterID)
                .HasConstraintName("FK__RefMonster_AssignedItemDrop__RefObjCommon");

            builder.HasOne(t => t.RefItemRefObjCommon)
                .WithMany(t => t.RefItemRefMonsterAssignedItemDrops)
                .HasForeignKey(d => d.RefItemID)
                .HasConstraintName("FK__RefMonster_AssignedItemDrop__RefObjCommon1");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefMonster_AssignedItemDrop";
        }

        public struct Columns
        {
            public const string RefMonsterID = "RefMonsterID";
            public const string RefItemID = "RefItemID";
            public const string DropGroupType = "DropGroupType";
            public const string OptLevel = "OptLevel";
            public const string DropAmountMin = "DropAmountMin";
            public const string DropAmountMax = "DropAmountMax";
            public const string DropRatio = "DropRatio";
            public const string RefMagicOptionID1 = "RefMagicOptionID1";
            public const string CustomValue1 = "CustomValue1";
            public const string RefMagicOptionID2 = "RefMagicOptionID2";
            public const string CustomValue2 = "CustomValue2";
            public const string RefMagicOptionID3 = "RefMagicOptionID3";
            public const string CustomValue3 = "CustomValue3";
            public const string RefMagicOptionID4 = "RefMagicOptionID4";
            public const string CustomValue4 = "CustomValue4";
            public const string RefMagicOptionID5 = "RefMagicOptionID5";
            public const string CustomValue5 = "CustomValue5";
            public const string RefMagicOptionID6 = "RefMagicOptionID6";
            public const string CustomValue6 = "CustomValue6";
            public const string RefMagicOptionID7 = "RefMagicOptionID7";
            public const string CustomValue7 = "CustomValue7";
            public const string RefMagicOptionID8 = "RefMagicOptionID8";
            public const string CustomValue8 = "CustomValue8";
            public const string RefMagicOptionID9 = "RefMagicOptionID9";
            public const string CustomValue9 = "CustomValue9";
            public const string RentCodeName = "RentCodeName";
        }
        #endregion
    }
}
