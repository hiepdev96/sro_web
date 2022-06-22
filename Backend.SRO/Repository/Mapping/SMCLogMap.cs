using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SMCLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SMCLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SMCLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SMCLog", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.SzUserID)
                .IsRequired()
                .HasColumnName("szUserID")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Catagory)
                .IsRequired()
                .HasColumnName("Catagory")
                .HasColumnType("tinyint");

            builder.Property(t => t.SzLog)
                .IsRequired()
                .HasColumnName("szLog")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.DLogDate)
                .IsRequired()
                .HasColumnName("dLogDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SMCLog";
        }

        public struct Columns
        {
            public const string SzUserID = "szUserID";
            public const string Catagory = "Catagory";
            public const string SzLog = "szLog";
            public const string DLogDate = "dLogDate";
        }
        #endregion
    }
}
