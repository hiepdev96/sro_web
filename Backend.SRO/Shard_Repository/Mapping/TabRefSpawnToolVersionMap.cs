using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TabRefSpawnToolVersionMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Tab_RefSpawnToolVersion", "dbo");

            // key
            builder.HasKey(t => t.DwRefDataVersion);

            // properties
            builder.Property(t => t.DwRefDataVersion)
                .IsRequired()
                .HasColumnName("dwRefDataVersion")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SzVersionDescString)
                .HasColumnName("szVersionDescString")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Tab_RefSpawnToolVersion";
        }

        public struct Columns
        {
            public const string DwRefDataVersion = "dwRefDataVersion";
            public const string SzVersionDescString = "szVersionDescString";
        }
        #endregion
    }
}
