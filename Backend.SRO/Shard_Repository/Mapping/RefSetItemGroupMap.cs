using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSetItemGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSetItemGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSetItemGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSetItemGroup", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ObjName128)
                .IsRequired()
                .HasColumnName("ObjName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.NameStrID128)
                .IsRequired()
                .HasColumnName("NameStrID128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.DescStrID128)
                .IsRequired()
                .HasColumnName("DescStrID128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.SetEffectMask)
                .IsRequired()
                .HasColumnName("SetEffectMask")
                .HasColumnType("tinyint");

            builder.Property(t => t.SetMagicMask)
                .IsRequired()
                .HasColumnName("SetMagicMask")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID)
                .IsRequired()
                .HasColumnName("2SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID1)
                .IsRequired()
                .HasColumnName("3SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID2)
                .IsRequired()
                .HasColumnName("4SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID3)
                .IsRequired()
                .HasColumnName("5SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID4)
                .IsRequired()
                .HasColumnName("6SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID5)
                .IsRequired()
                .HasColumnName("7SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID6)
                .IsRequired()
                .HasColumnName("8SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID7)
                .IsRequired()
                .HasColumnName("9SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID8)
                .IsRequired()
                .HasColumnName("10SetMOptGroupID")
                .HasColumnType("int");

            builder.Property(t => t.SetMOptGroupID9)
                .IsRequired()
                .HasColumnName("11SetMOptGroupID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSetItemGroup";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string ObjName128 = "ObjName128";
            public const string NameStrID128 = "NameStrID128";
            public const string DescStrID128 = "DescStrID128";
            public const string SetEffectMask = "SetEffectMask";
            public const string SetMagicMask = "SetMagicMask";
            public const string SetMOptGroupID = "2SetMOptGroupID";
            public const string SetMOptGroupID1 = "3SetMOptGroupID";
            public const string SetMOptGroupID2 = "4SetMOptGroupID";
            public const string SetMOptGroupID3 = "5SetMOptGroupID";
            public const string SetMOptGroupID4 = "6SetMOptGroupID";
            public const string SetMOptGroupID5 = "7SetMOptGroupID";
            public const string SetMOptGroupID6 = "8SetMOptGroupID";
            public const string SetMOptGroupID7 = "9SetMOptGroupID";
            public const string SetMOptGroupID8 = "10SetMOptGroupID";
            public const string SetMOptGroupID9 = "11SetMOptGroupID";
        }
        #endregion
    }
}
