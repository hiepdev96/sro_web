using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TmpMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.Tmp>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.Tmp> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tmp", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.UserJID)
                .IsRequired()
                .HasColumnName("UserJID")
                .HasColumnType("int");

            builder.Property(t => t.UserID)
                .IsRequired()
                .HasColumnName("UserID")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("tinyint");

            builder.Property(t => t.SerialNo)
                .IsRequired()
                .HasColumnName("SerialNo")
                .HasColumnType("int");

            builder.Property(t => t.TimeBegin)
                .IsRequired()
                .HasColumnName("timeBegin")
                .HasColumnType("datetime");

            builder.Property(t => t.TimeEnd)
                .IsRequired()
                .HasColumnName("timeEnd")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "tmp";
        }

        public struct Columns
        {
            public const string UserJID = "UserJID";
            public const string UserID = "UserID";
            public const string Type = "Type";
            public const string SerialNo = "SerialNo";
            public const string TimeBegin = "timeBegin";
            public const string TimeEnd = "timeEnd";
        }
        #endregion
    }
}
