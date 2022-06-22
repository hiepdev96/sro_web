using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class ShardMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.Shard>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.Shard> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Shard", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NID)
                .IsRequired()
                .HasColumnName("nID")
                .HasColumnType("smallint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NFarmID)
                .IsRequired()
                .HasColumnName("nFarmID")
                .HasColumnType("tinyint");

            builder.Property(t => t.NContentID)
                .IsRequired()
                .HasColumnName("nContentID")
                .HasColumnType("tinyint");

            builder.Property(t => t.SzName)
                .IsRequired()
                .HasColumnName("szName")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.SzDesc)
                .IsRequired()
                .HasColumnName("szDesc")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.SzDBConfig)
                .IsRequired()
                .HasColumnName("szDBConfig")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.NMaxUser)
                .IsRequired()
                .HasColumnName("nMaxUser")
                .HasColumnType("smallint")
                .HasDefaultValueSql("((1000))");

            builder.Property(t => t.NStartupServerID)
                .IsRequired()
                .HasColumnName("nStartupServerID")
                .HasColumnType("smallint");

            builder.Property(t => t.NStatus)
                .IsRequired()
                .HasColumnName("nStatus")
                .HasColumnType("tinyint");

            builder.Property(t => t.NCurrentUserRatio)
                .IsRequired()
                .HasColumnName("nCurrentUserRatio")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Shard";
        }

        public struct Columns
        {
            public const string NID = "nID";
            public const string NFarmID = "nFarmID";
            public const string NContentID = "nContentID";
            public const string SzName = "szName";
            public const string SzDesc = "szDesc";
            public const string SzDBConfig = "szDBConfig";
            public const string NMaxUser = "nMaxUser";
            public const string NStartupServerID = "nStartupServerID";
            public const string NStatus = "nStatus";
            public const string NCurrentUserRatio = "nCurrentUserRatio";
        }
        #endregion
    }
}
