using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Mapping
{
    public partial class LogEventSiegeFortressMap
        : IEntityTypeConfiguration<VsroLog.Log_Repository.Entities.LogEventSiegeFortress>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroLog.Log_Repository.Entities.LogEventSiegeFortress> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_LogEventSiegeFortress", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.EventTime)
                .IsRequired()
                .HasColumnName("EventTime")
                .HasColumnType("datetime");

            builder.Property(t => t.EventID)
                .IsRequired()
                .HasColumnName("EventID")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.Data1)
                .IsRequired()
                .HasColumnName("Data1")
                .HasColumnType("int");

            builder.Property(t => t.Data2)
                .IsRequired()
                .HasColumnName("Data2")
                .HasColumnType("int");

            builder.Property(t => t.StrDesc)
                .HasColumnName("strDesc")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_LogEventSiegeFortress";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string FortressID = "FortressID";
            public const string EventTime = "EventTime";
            public const string EventID = "EventID";
            public const string CharID = "CharID";
            public const string Data1 = "Data1";
            public const string Data2 = "Data2";
            public const string StrDesc = "strDesc";
        }
        #endregion
    }
}
