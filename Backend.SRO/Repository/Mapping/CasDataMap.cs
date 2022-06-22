using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class CasDataMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.CasData>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.CasData> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CasData", "dbo");

            // key
            builder.HasKey(t => t.NSerial);

            // properties
            builder.Property(t => t.NSerial)
                .IsRequired()
                .HasColumnName("nSerial")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NCategory)
                .IsRequired()
                .HasColumnName("nCategory")
                .HasColumnType("tinyint");

            builder.Property(t => t.DReportDate)
                .IsRequired()
                .HasColumnName("dReportDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.WShardID)
                .IsRequired()
                .HasColumnName("wShardID")
                .HasColumnType("smallint");

            builder.Property(t => t.DwUserJID)
                .IsRequired()
                .HasColumnName("dwUserJID")
                .HasColumnType("int");

            builder.Property(t => t.SzCharName)
                .IsRequired()
                .HasColumnName("szCharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.SzTgtCharName)
                .HasColumnName("szTgtCharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.SzMailAddress)
                .IsRequired()
                .HasColumnName("szMailAddress")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.SzStatement)
                .IsRequired()
                .HasColumnName("szStatement")
                .HasColumnType("varchar(512)")
                .HasMaxLength(512);

            builder.Property(t => t.NStatus)
                .IsRequired()
                .HasColumnName("nStatus")
                .HasColumnType("tinyint");

            builder.Property(t => t.DProcessDate)
                .HasColumnName("dProcessDate")
                .HasColumnType("datetime");

            builder.Property(t => t.SzProcessedGM)
                .HasColumnName("szProcessedGM")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SzMemo)
                .HasColumnName("szMemo")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.SzAnswer)
                .HasColumnName("szAnswer")
                .HasColumnType("varchar(1024)")
                .HasMaxLength(1024);

            builder.Property(t => t.BtUserChecked)
                .IsRequired()
                .HasColumnName("btUserChecked")
                .HasColumnType("tinyint");

            builder.Property(t => t.SzChatLog)
                .IsRequired()
                .HasColumnName("szChatLog")
                .HasColumnType("varchar(4000)")
                .HasMaxLength(4000);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CasData";
        }

        public struct Columns
        {
            public const string NSerial = "nSerial";
            public const string NCategory = "nCategory";
            public const string DReportDate = "dReportDate";
            public const string WShardID = "wShardID";
            public const string DwUserJID = "dwUserJID";
            public const string SzCharName = "szCharName";
            public const string SzTgtCharName = "szTgtCharName";
            public const string SzMailAddress = "szMailAddress";
            public const string SzStatement = "szStatement";
            public const string NStatus = "nStatus";
            public const string DProcessDate = "dProcessDate";
            public const string SzProcessedGM = "szProcessedGM";
            public const string SzMemo = "szMemo";
            public const string SzAnswer = "szAnswer";
            public const string BtUserChecked = "btUserChecked";
            public const string SzChatLog = "szChatLog";
        }
        #endregion
    }
}
