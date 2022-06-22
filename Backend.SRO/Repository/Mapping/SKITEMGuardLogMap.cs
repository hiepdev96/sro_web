using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKITEMGuardLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKITEMGuardLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKITEMGuardLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_ITEM_GuardLog", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.AutoID)
                .IsRequired()
                .HasColumnName("autoID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Serial64)
                .HasColumnName("serial64")
                .HasColumnType("bigint");

            builder.Property(t => t.Gremain)
                .HasColumnName("gremain")
                .HasColumnType("int");

            builder.Property(t => t.ShardID)
                .HasColumnName("shardID")
                .HasColumnType("int");

            builder.Property(t => t.OptionLvl)
                .HasColumnName("optionLvl")
                .HasColumnType("int");

            builder.Property(t => t.LastGuard)
                .HasColumnName("LastGuard")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_ITEM_GuardLog";
        }

        public struct Columns
        {
            public const string AutoID = "autoID";
            public const string Serial64 = "serial64";
            public const string Gremain = "gremain";
            public const string ShardID = "shardID";
            public const string OptionLvl = "optionLvl";
            public const string LastGuard = "LastGuard";
        }
        #endregion
    }
}
