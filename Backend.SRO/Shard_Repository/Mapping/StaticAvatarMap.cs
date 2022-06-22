using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class StaticAvatarMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.StaticAvatar>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.StaticAvatar> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_StaticAvatar", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.Param1)
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Param2)
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Param3)
                .HasColumnName("Param3")
                .HasColumnType("int");

            builder.Property(t => t.Param4)
                .HasColumnName("Param4")
                .HasColumnType("int");

            builder.Property(t => t.Param5)
                .HasColumnName("Param5")
                .HasColumnType("int");

            builder.Property(t => t.Param6)
                .HasColumnName("Param6")
                .HasColumnType("int");

            builder.Property(t => t.Param7)
                .HasColumnName("Param7")
                .HasColumnType("int");

            builder.Property(t => t.Param8)
                .HasColumnName("Param8")
                .HasColumnType("int");

            builder.Property(t => t.Param9)
                .HasColumnName("Param9")
                .HasColumnType("int");

            builder.Property(t => t.Param10)
                .HasColumnName("Param10")
                .HasColumnType("int");

            builder.Property(t => t.Param11)
                .HasColumnName("Param11")
                .HasColumnType("int");

            builder.Property(t => t.Param12)
                .HasColumnName("Param12")
                .HasColumnType("int");

            builder.Property(t => t.Param13)
                .HasColumnName("Param13")
                .HasColumnType("int");

            builder.Property(t => t.Param14)
                .HasColumnName("Param14")
                .HasColumnType("int");

            builder.Property(t => t.Param15)
                .HasColumnName("Param15")
                .HasColumnType("int");

            builder.Property(t => t.Param16)
                .HasColumnName("Param16")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Char)
                .WithOne(t => t.StaticAvatar)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.StaticAvatar>(d => d.CharID)
                .HasConstraintName("FK__StaticAvatar__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_StaticAvatar";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string Param1 = "Param1";
            public const string Param2 = "Param2";
            public const string Param3 = "Param3";
            public const string Param4 = "Param4";
            public const string Param5 = "Param5";
            public const string Param6 = "Param6";
            public const string Param7 = "Param7";
            public const string Param8 = "Param8";
            public const string Param9 = "Param9";
            public const string Param10 = "Param10";
            public const string Param11 = "Param11";
            public const string Param12 = "Param12";
            public const string Param13 = "Param13";
            public const string Param14 = "Param14";
            public const string Param15 = "Param15";
            public const string Param16 = "Param16";
        }
        #endregion
    }
}
