using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class QuaySoEpointMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.QuaySoEpoint>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.QuaySoEpoint> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("QuaySoEpoint", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserCash)
                .HasColumnName("UserCash")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Server)
                .HasColumnName("Server")
                .HasColumnType("int");

            builder.Property(t => t.CharID)
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.CharName)
                .HasColumnName("CharName")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SPOwn)
                .HasColumnName("SP_Own")
                .HasColumnType("int");

            builder.Property(t => t.SPBefore)
                .HasColumnName("SP_Before")
                .HasColumnType("int");

            builder.Property(t => t.SPAfter)
                .HasColumnName("SP_After")
                .HasColumnType("int");

            builder.Property(t => t.Regdate)
                .HasColumnName("Regdate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.SourcePoint)
                .HasColumnName("SourcePoint")
                .HasColumnType("char(2)")
                .HasMaxLength(2);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "QuaySoEpoint";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string UserCash = "UserCash";
            public const string Server = "Server";
            public const string CharID = "CharID";
            public const string CharName = "CharName";
            public const string SPOwn = "SP_Own";
            public const string SPBefore = "SP_Before";
            public const string SPAfter = "SP_After";
            public const string Regdate = "Regdate";
            public const string SourcePoint = "SourcePoint";
        }
        #endregion
    }
}
