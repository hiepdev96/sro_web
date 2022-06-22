using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefObjCharExtraSkillMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefObjCharExtraSkill", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill1)
                .HasColumnName("ExtraSkill_1")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill2)
                .HasColumnName("ExtraSkill_2")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill3)
                .HasColumnName("ExtraSkill_3")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill4)
                .HasColumnName("ExtraSkill_4")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill5)
                .HasColumnName("ExtraSkill_5")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill6)
                .HasColumnName("ExtraSkill_6")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill7)
                .HasColumnName("ExtraSkill_7")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill8)
                .HasColumnName("ExtraSkill_8")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill9)
                .HasColumnName("ExtraSkill_9")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill10)
                .HasColumnName("ExtraSkill_10")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill11)
                .HasColumnName("ExtraSkill_11")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill12)
                .HasColumnName("ExtraSkill_12")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill13)
                .HasColumnName("ExtraSkill_13")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill14)
                .HasColumnName("ExtraSkill_14")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill15)
                .HasColumnName("ExtraSkill_15")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill16)
                .HasColumnName("ExtraSkill_16")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill17)
                .HasColumnName("ExtraSkill_17")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill18)
                .HasColumnName("ExtraSkill_18")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill19)
                .HasColumnName("ExtraSkill_19")
                .HasColumnType("int");

            builder.Property(t => t.ExtraSkill20)
                .HasColumnName("ExtraSkill_20")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefObjCharExtraSkill";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string CharID = "CharID";
            public const string ExtraSkill1 = "ExtraSkill_1";
            public const string ExtraSkill2 = "ExtraSkill_2";
            public const string ExtraSkill3 = "ExtraSkill_3";
            public const string ExtraSkill4 = "ExtraSkill_4";
            public const string ExtraSkill5 = "ExtraSkill_5";
            public const string ExtraSkill6 = "ExtraSkill_6";
            public const string ExtraSkill7 = "ExtraSkill_7";
            public const string ExtraSkill8 = "ExtraSkill_8";
            public const string ExtraSkill9 = "ExtraSkill_9";
            public const string ExtraSkill10 = "ExtraSkill_10";
            public const string ExtraSkill11 = "ExtraSkill_11";
            public const string ExtraSkill12 = "ExtraSkill_12";
            public const string ExtraSkill13 = "ExtraSkill_13";
            public const string ExtraSkill14 = "ExtraSkill_14";
            public const string ExtraSkill15 = "ExtraSkill_15";
            public const string ExtraSkill16 = "ExtraSkill_16";
            public const string ExtraSkill17 = "ExtraSkill_17";
            public const string ExtraSkill18 = "ExtraSkill_18";
            public const string ExtraSkill19 = "ExtraSkill_19";
            public const string ExtraSkill20 = "ExtraSkill_20";
        }
        #endregion
    }
}
