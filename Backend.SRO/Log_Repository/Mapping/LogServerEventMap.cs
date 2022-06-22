using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Mapping
{
    public partial class LogServerEventMap
        : IEntityTypeConfiguration<VsroLog.Log_Repository.Entities.LogServerEvent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroLog.Log_Repository.Entities.LogServerEvent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_LogServerEvent", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EventTime)
                .IsRequired()
                .HasColumnName("EventTime")
                .HasColumnType("datetime");

            builder.Property(t => t.ServerEventID)
                .IsRequired()
                .HasColumnName("ServerEventID")
                .HasColumnType("int");

            builder.Property(t => t.LogType)
                .IsRequired()
                .HasColumnName("LogType")
                .HasColumnType("tinyint");

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
            public const string Name = "_LogServerEvent";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string EventTime = "EventTime";
            public const string ServerEventID = "ServerEventID";
            public const string LogType = "LogType";
            public const string StrDesc = "strDesc";
        }
        #endregion
    }
}
