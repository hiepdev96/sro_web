using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefCustomizingReservedItemDropForMonsterMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefCustomizingReservedItemDropForMonster>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefCustomizingReservedItemDropForMonster> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefCustomizingReservedItemDropForMonster", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.RefMonsterID)
                .IsRequired()
                .HasColumnName("RefMonsterID")
                .HasColumnType("int");

            builder.Property(t => t.Rarity)
                .IsRequired()
                .HasColumnName("Rarity")
                .HasColumnType("tinyint");

            builder.Property(t => t.Command)
                .IsRequired()
                .HasColumnName("Command")
                .HasColumnType("int");

            builder.Property(t => t.DropGroupType)
                .IsRequired()
                .HasColumnName("DropGroupType")
                .HasColumnType("tinyint");

            builder.Property(t => t.Param1)
                .HasColumnName("Param1")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.Param2)
                .HasColumnName("Param2")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.Param3)
                .HasColumnName("Param3")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.Param4)
                .HasColumnName("Param4")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.Param5)
                .HasColumnName("Param5")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            // relationships
            builder.HasOne(t => t.RefMonsterRefObjCommon)
                .WithMany(t => t.RefMonsterRefCustomizingReservedItemDropForMonsters)
                .HasForeignKey(d => d.RefMonsterID)
                .HasConstraintName("FK__RefCustomizingReservedItemDropForMonster__RefObjCommon");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefCustomizingReservedItemDropForMonster";
        }

        public struct Columns
        {
            public const string RefMonsterID = "RefMonsterID";
            public const string Rarity = "Rarity";
            public const string Command = "Command";
            public const string DropGroupType = "DropGroupType";
            public const string Param1 = "Param1";
            public const string Param2 = "Param2";
            public const string Param3 = "Param3";
            public const string Param4 = "Param4";
            public const string Param5 = "Param5";
        }
        #endregion
    }
}
