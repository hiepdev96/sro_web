using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class NoticeMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.Notice>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.Notice> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Notice", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ContentID)
                .IsRequired()
                .HasColumnName("ContentID")
                .HasColumnType("tinyint");

            builder.Property(t => t.Subject)
                .IsRequired()
                .HasColumnName("Subject")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Article)
                .IsRequired()
                .HasColumnName("Article")
                .HasColumnType("varchar(1024)")
                .HasMaxLength(1024);

            builder.Property(t => t.EditDate)
                .IsRequired()
                .HasColumnName("EditDate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Notice";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string ContentID = "ContentID";
            public const string Subject = "Subject";
            public const string Article = "Article";
            public const string EditDate = "EditDate";
        }
        #endregion
    }
}
