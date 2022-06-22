using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class LogSEEKNDESTROYITEMFASTMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.LogSEEKNDESTROYITEMFAST>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.LogSEEKNDESTROYITEMFAST> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Log_SEEK_N_DESTROY_ITEM_FAST", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.DeletedTime)
                .HasColumnName("DeletedTime")
                .HasColumnType("datetime");

            builder.Property(t => t.OwnerType)
                .HasColumnName("OwnerType")
                .HasColumnType("tinyint");

            builder.Property(t => t.OwnerID)
                .HasColumnName("OwnerID")
                .HasColumnType("int");

            builder.Property(t => t.Id64)
                .HasColumnName("ID64")
                .HasColumnType("bigint");

            builder.Property(t => t.CodeName)
                .HasColumnName("CodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OptLevel)
                .HasColumnName("OptLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.Variance)
                .HasColumnName("Variance")
                .HasColumnType("bigint");

            builder.Property(t => t.Data)
                .HasColumnName("Data")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Log_SEEK_N_DESTROY_ITEM_FAST";
        }

        public struct Columns
        {
            public const string DeletedTime = "DeletedTime";
            public const string OwnerType = "OwnerType";
            public const string OwnerID = "OwnerID";
            public const string Id64 = "ID64";
            public const string CodeName = "CodeName";
            public const string OptLevel = "OptLevel";
            public const string Variance = "Variance";
            public const string Data = "Data";
        }
        #endregion
    }
}
