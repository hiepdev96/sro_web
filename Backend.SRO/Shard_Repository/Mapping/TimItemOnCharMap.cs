using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TimItemOnCharMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TimItemOnChar>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TimItemOnChar> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("TimItemOnChar", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.CharName16)
                .IsRequired()
                .HasColumnName("CharName16")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.OptLevel)
                .HasColumnName("OptLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.Variance)
                .HasColumnName("Variance")
                .HasColumnType("bigint");

            builder.Property(t => t.Data)
                .IsRequired()
                .HasColumnName("Data")
                .HasColumnType("int");

            builder.Property(t => t.MagParamNum)
                .IsRequired()
                .HasColumnName("MagParamNum")
                .HasColumnType("tinyint");

            builder.Property(t => t.CreaterName)
                .HasColumnName("CreaterName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.MagParam1)
                .HasColumnName("MagParam1")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam2)
                .HasColumnName("MagParam2")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam3)
                .HasColumnName("MagParam3")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam4)
                .HasColumnName("MagParam4")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam5)
                .HasColumnName("MagParam5")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam6)
                .HasColumnName("MagParam6")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam7)
                .HasColumnName("MagParam7")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam8)
                .HasColumnName("MagParam8")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam9)
                .HasColumnName("MagParam9")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam10)
                .HasColumnName("MagParam10")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam11)
                .HasColumnName("MagParam11")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam12)
                .HasColumnName("MagParam12")
                .HasColumnType("bigint");

            builder.Property(t => t.Serial64)
                .IsRequired()
                .HasColumnName("Serial64")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "TimItemOnChar";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string CharName16 = "CharName16";
            public const string OptLevel = "OptLevel";
            public const string Variance = "Variance";
            public const string Data = "Data";
            public const string MagParamNum = "MagParamNum";
            public const string CreaterName = "CreaterName";
            public const string MagParam1 = "MagParam1";
            public const string MagParam2 = "MagParam2";
            public const string MagParam3 = "MagParam3";
            public const string MagParam4 = "MagParam4";
            public const string MagParam5 = "MagParam5";
            public const string MagParam6 = "MagParam6";
            public const string MagParam7 = "MagParam7";
            public const string MagParam8 = "MagParam8";
            public const string MagParam9 = "MagParam9";
            public const string MagParam10 = "MagParam10";
            public const string MagParam11 = "MagParam11";
            public const string MagParam12 = "MagParam12";
            public const string Serial64 = "Serial64";
        }
        #endregion
    }
}
