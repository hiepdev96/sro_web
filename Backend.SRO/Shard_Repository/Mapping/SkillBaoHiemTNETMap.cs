using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class SkillBaoHiemTNETMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.SkillBaoHiemTNET>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.SkillBaoHiemTNET> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Skill_BaoHiem_TNET", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.CharName)
                .HasColumnName("CharName")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SkillBaoHiem)
                .HasColumnName("SkillBaoHiem")
                .HasColumnType("int");

            builder.Property(t => t.Regdate)
                .HasColumnName("Regdate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.LastModified)
                .HasColumnName("LastModified")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Skill_BaoHiem_TNET";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string CharName = "CharName";
            public const string SkillBaoHiem = "SkillBaoHiem";
            public const string Regdate = "Regdate";
            public const string LastModified = "LastModified";
        }
        #endregion
    }
}
