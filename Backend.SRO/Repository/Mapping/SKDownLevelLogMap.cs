using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKDownLevelLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKDownLevelLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKDownLevelLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_DownLevelLog", "dbo");

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

            builder.Property(t => t.Package)
                .HasColumnName("package")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Newlevel)
                .HasColumnName("newlevel")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Server)
                .HasColumnName("server")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Timedown)
                .HasColumnName("timedown")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_DownLevelLog";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Jid = "JID";
            public const string Struserid = "struserid";
            public const string Charname = "charname";
            public const string Package = "package";
            public const string Newlevel = "newlevel";
            public const string Server = "server";
            public const string Timedown = "timedown";
        }
        #endregion
    }
}
