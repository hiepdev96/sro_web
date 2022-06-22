using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class GuildMemberMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.GuildMember>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.GuildMember> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_GuildMember", "dbo");

            // key
            builder.HasKey(t => new { t.GuildID, t.CharID });

            // properties
            builder.Property(t => t.GuildID)
                .IsRequired()
                .HasColumnName("GuildID")
                .HasColumnType("int");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.CharName)
                .IsRequired()
                .HasColumnName("CharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.MemberClass)
                .IsRequired()
                .HasColumnName("MemberClass")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharLevel)
                .IsRequired()
                .HasColumnName("CharLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.GPDonation)
                .IsRequired()
                .HasColumnName("GP_Donation")
                .HasColumnType("int");

            builder.Property(t => t.JoinDate)
                .IsRequired()
                .HasColumnName("JoinDate")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.Permission)
                .HasColumnName("Permission")
                .HasColumnType("int");

            builder.Property(t => t.Contribution)
                .HasColumnName("Contribution")
                .HasColumnType("int");

            builder.Property(t => t.GuildWarKill)
                .HasColumnName("GuildWarKill")
                .HasColumnType("int");

            builder.Property(t => t.GuildWarKilled)
                .HasColumnName("GuildWarKilled")
                .HasColumnType("int");

            builder.Property(t => t.Nickname)
                .HasColumnName("Nickname")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.RefObjID)
                .HasColumnName("RefObjID")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.SiegeAuthority)
                .HasColumnName("SiegeAuthority")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("(0)");

            // relationships
            builder.HasOne(t => t.Char)
                .WithMany(t => t.GuildMembers)
                .HasForeignKey(d => d.CharID)
                .HasConstraintName("FK__GuildMember__Char");

            builder.HasOne(t => t.Guild)
                .WithMany(t => t.GuildMembers)
                .HasForeignKey(d => d.GuildID)
                .HasConstraintName("FK__GuildMember__Guild");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_GuildMember";
        }

        public struct Columns
        {
            public const string GuildID = "GuildID";
            public const string CharID = "CharID";
            public const string CharName = "CharName";
            public const string MemberClass = "MemberClass";
            public const string CharLevel = "CharLevel";
            public const string GPDonation = "GP_Donation";
            public const string JoinDate = "JoinDate";
            public const string Permission = "Permission";
            public const string Contribution = "Contribution";
            public const string GuildWarKill = "GuildWarKill";
            public const string GuildWarKilled = "GuildWarKilled";
            public const string Nickname = "Nickname";
            public const string RefObjID = "RefObjID";
            public const string SiegeAuthority = "SiegeAuthority";
        }
        #endregion
    }
}
