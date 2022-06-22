using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class ServiceManagerLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.ServiceManagerLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.ServiceManagerLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ServiceManagerLog", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NUserID)
                .IsRequired()
                .HasColumnName("nUserID")
                .HasColumnType("int");

            builder.Property(t => t.EventTime)
                .IsRequired()
                .HasColumnName("EventTime")
                .HasColumnType("datetime");

            builder.Property(t => t.SzLog)
                .IsRequired()
                .HasColumnName("szLog")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ServiceManagerLog";
        }

        public struct Columns
        {
            public const string NUserID = "nUserID";
            public const string EventTime = "EventTime";
            public const string SzLog = "szLog";
        }
        #endregion
    }
}
