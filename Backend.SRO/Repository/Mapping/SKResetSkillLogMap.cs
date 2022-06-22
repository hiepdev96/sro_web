using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKResetSkillLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKResetSkillLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKResetSkillLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_ResetSkillLog", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Jid)
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.Struserid)
                .HasColumnName("struserid")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Charname)
                .HasColumnName("charname")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SkillDown)
                .HasColumnName("SkillDown")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.NewSkill)
                .HasColumnName("NewSkill")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SilkDown)
                .HasColumnName("SilkDown")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Server)
                .HasColumnName("server")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.TimeReset)
                .HasColumnName("TimeReset")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_ResetSkillLog";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Jid = "JID";
            public const string Struserid = "struserid";
            public const string Charname = "charname";
            public const string SkillDown = "SkillDown";
            public const string NewSkill = "NewSkill";
            public const string SilkDown = "SilkDown";
            public const string Server = "server";
            public const string TimeReset = "TimeReset";
        }
        #endregion
    }
}
