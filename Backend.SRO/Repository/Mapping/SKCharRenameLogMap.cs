using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKCharRenameLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKCharRenameLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKCharRenameLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_CharRenameLog", "dbo");

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
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.OldChar)
                .HasColumnName("old_char")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.NewChar)
                .HasColumnName("new_char")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Server)
                .HasColumnName("server")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Timechange)
                .HasColumnName("timechange")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_CharRenameLog";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Jid = "JID";
            public const string Struserid = "struserid";
            public const string OldChar = "old_char";
            public const string NewChar = "new_char";
            public const string Server = "server";
            public const string Timechange = "timechange";
        }
        #endregion
    }
}
