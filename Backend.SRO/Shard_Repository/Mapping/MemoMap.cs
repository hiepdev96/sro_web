using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class MemoMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.Memo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.Memo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Memo", "dbo");

            // key
            builder.HasKey(t => t.Id64);

            // properties
            builder.Property(t => t.Id64)
                .IsRequired()
                .HasColumnName("ID64")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.FromCharName)
                .IsRequired()
                .HasColumnName("FromCharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.Message)
                .HasColumnName("Message")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("Date")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("tinyint");

            builder.Property(t => t.RefObjID)
                .HasColumnName("RefObjID")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            // relationships
            builder.HasOne(t => t.Char)
                .WithMany(t => t.Memos)
                .HasForeignKey(d => d.CharID)
                .HasConstraintName("FK__Memo__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Memo";
        }

        public struct Columns
        {
            public const string Id64 = "ID64";
            public const string CharID = "CharID";
            public const string FromCharName = "FromCharName";
            public const string Message = "Message";
            public const string Date = "Date";
            public const string Status = "Status";
            public const string RefObjID = "RefObjID";
        }
        #endregion
    }
}
