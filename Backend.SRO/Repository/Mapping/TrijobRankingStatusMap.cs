using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TrijobRankingStatusMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.TrijobRankingStatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.TrijobRankingStatus> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("__TrijobRankingStatus__", "dbo");

            // key
            builder.HasKey(t => t.ShardID);

            // properties
            builder.Property(t => t.ShardID)
                .IsRequired()
                .HasColumnName("ShardID")
                .HasColumnType("int");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("tinyint");

            builder.Property(t => t.UpdateTime)
                .IsRequired()
                .HasColumnName("UpdateTime")
                .HasColumnType("smalldatetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "__TrijobRankingStatus__";
        }

        public struct Columns
        {
            public const string ShardID = "ShardID";
            public const string Status = "Status";
            public const string UpdateTime = "UpdateTime";
        }
        #endregion
    }
}
