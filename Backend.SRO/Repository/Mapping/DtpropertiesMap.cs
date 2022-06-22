using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class DtpropertiesMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.Dtproperties>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.Dtproperties> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("dtproperties", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Objectid)
                .HasColumnName("objectid")
                .HasColumnType("int");

            builder.Property(t => t.Property)
                .IsRequired()
                .HasColumnName("property")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.Value)
                .HasColumnName("value")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Uvalue)
                .HasColumnName("uvalue")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Lvalue)
                .HasColumnName("lvalue")
                .HasColumnType("image");

            builder.Property(t => t.Version)
                .IsRequired()
                .HasColumnName("version")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "dtproperties";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Objectid = "objectid";
            public const string Property = "property";
            public const string Value = "value";
            public const string Uvalue = "uvalue";
            public const string Lvalue = "lvalue";
            public const string Version = "version";
        }
        #endregion
    }
}
