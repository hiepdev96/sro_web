using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class GPHistoryMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.GPHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.GPHistory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_GPHistory", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.GuildID)
                .IsRequired()
                .HasColumnName("GuildID")
                .HasColumnType("int");

            builder.Property(t => t.UsedTime)
                .HasColumnName("UsedTime")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.CharName)
                .IsRequired()
                .HasColumnName("CharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.UsedGP)
                .IsRequired()
                .HasColumnName("UsedGP")
                .HasColumnType("int");

            builder.Property(t => t.Reason)
                .IsRequired()
                .HasColumnName("Reason")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_GPHistory";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string GuildID = "GuildID";
            public const string UsedTime = "UsedTime";
            public const string CharName = "CharName";
            public const string UsedGP = "UsedGP";
            public const string Reason = "Reason";
        }
        #endregion
    }
}
