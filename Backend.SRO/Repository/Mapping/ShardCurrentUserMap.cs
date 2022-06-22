using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class ShardCurrentUserMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.ShardCurrentUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.ShardCurrentUser> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ShardCurrentUser", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NID)
                .IsRequired()
                .HasColumnName("nID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NShardID)
                .IsRequired()
                .HasColumnName("nShardID")
                .HasColumnType("int");

            builder.Property(t => t.NUserCount)
                .IsRequired()
                .HasColumnName("nUserCount")
                .HasColumnType("int");

            builder.Property(t => t.DLogDate)
                .IsRequired()
                .HasColumnName("dLogDate")
                .HasColumnType("smalldatetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ShardCurrentUser";
        }

        public struct Columns
        {
            public const string NID = "nID";
            public const string NShardID = "nShardID";
            public const string NUserCount = "nUserCount";
            public const string DLogDate = "dLogDate";
        }
        #endregion
    }
}
