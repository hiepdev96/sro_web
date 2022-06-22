using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class GuildMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.Guild>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.Guild> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Guild", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.Lvl)
                .IsRequired()
                .HasColumnName("Lvl")
                .HasColumnType("tinyint");

            builder.Property(t => t.GatheredSP)
                .IsRequired()
                .HasColumnName("GatheredSP")
                .HasColumnType("int");

            builder.Property(t => t.FoundationDate)
                .IsRequired()
                .HasColumnName("FoundationDate")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.Alliance)
                .HasColumnName("Alliance")
                .HasColumnType("int");

            builder.Property(t => t.MasterCommentTitle)
                .HasColumnName("MasterCommentTitle")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.MasterComment)
                .HasColumnName("MasterComment")
                .HasColumnType("varchar(2049)")
                .HasMaxLength(2049);

            builder.Property(t => t.Booty)
                .HasColumnName("Booty")
                .HasColumnType("int");

            builder.Property(t => t.Gold)
                .IsRequired()
                .HasColumnName("Gold")
                .HasColumnType("bigint");

            builder.Property(t => t.LastCrestRev)
                .IsRequired()
                .HasColumnName("LastCrestRev")
                .HasColumnType("int");

            builder.Property(t => t.CurCrestRev)
                .IsRequired()
                .HasColumnName("CurCrestRev")
                .HasColumnType("int");

            builder.Property(t => t.MercenaryAttr)
                .IsRequired()
                .HasColumnName("MercenaryAttr")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.AllianceAlliedClans)
                .WithMany(t => t.AllianceGuilds)
                .HasForeignKey(d => d.Alliance)
                .HasConstraintName("FK__Guild__AlliedClans");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Guild";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Name = "Name";
            public const string Lvl = "Lvl";
            public const string GatheredSP = "GatheredSP";
            public const string FoundationDate = "FoundationDate";
            public const string Alliance = "Alliance";
            public const string MasterCommentTitle = "MasterCommentTitle";
            public const string MasterComment = "MasterComment";
            public const string Booty = "Booty";
            public const string Gold = "Gold";
            public const string LastCrestRev = "LastCrestRev";
            public const string CurCrestRev = "CurCrestRev";
            public const string MercenaryAttr = "MercenaryAttr";
        }
        #endregion
    }
}
