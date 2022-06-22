using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class BooksMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.Books>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.Books> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("BOOKS", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Pubdate)
                .IsRequired()
                .HasColumnName("pubdate")
                .HasColumnType("datetime");

            builder.Property(t => t.Synopsis)
                .IsRequired()
                .HasColumnName("synopsis")
                .HasColumnType("varchar(4000)")
                .HasMaxLength(4000);

            builder.Property(t => t.Inprint)
                .IsRequired()
                .HasColumnName("inprint")
                .HasColumnType("bit");

            builder.Property(t => t.SalesCount)
                .IsRequired()
                .HasColumnName("salesCount")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "BOOKS";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Title = "title";
            public const string Pubdate = "pubdate";
            public const string Synopsis = "synopsis";
            public const string Inprint = "inprint";
            public const string SalesCount = "salesCount";
        }
        #endregion
    }
}
