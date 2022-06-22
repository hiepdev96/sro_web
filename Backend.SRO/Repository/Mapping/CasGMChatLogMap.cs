using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class CasGMChatLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.CasGMChatLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.CasGMChatLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CasGMChatLog", "dbo");

            // key
            builder.HasKey(t => t.NSerial);

            // properties
            builder.Property(t => t.NSerial)
                .IsRequired()
                .HasColumnName("nSerial")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SzGM)
                .IsRequired()
                .HasColumnName("szGM")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.WShardID)
                .IsRequired()
                .HasColumnName("wShardID")
                .HasColumnType("smallint");

            builder.Property(t => t.SzCharName)
                .IsRequired()
                .HasColumnName("szCharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.NCasSerial)
                .IsRequired()
                .HasColumnName("nCasSerial")
                .HasColumnType("int");

            builder.Property(t => t.SzGMChatLog)
                .HasColumnName("szGMChatLog")
                .HasColumnType("varchar(4000)")
                .HasMaxLength(4000);

            builder.Property(t => t.DWritten)
                .IsRequired()
                .HasColumnName("dWritten")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CasGMChatLog";
        }

        public struct Columns
        {
            public const string NSerial = "nSerial";
            public const string SzGM = "szGM";
            public const string WShardID = "wShardID";
            public const string SzCharName = "szCharName";
            public const string NCasSerial = "nCasSerial";
            public const string SzGMChatLog = "szGMChatLog";
            public const string DWritten = "dWritten";
        }
        #endregion
    }
}
