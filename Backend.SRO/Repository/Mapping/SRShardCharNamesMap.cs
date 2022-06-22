using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SRShardCharNamesMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SRShardCharNames>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SRShardCharNames> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SR_ShardCharNames", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.UserJID)
                .IsRequired()
                .HasColumnName("UserJID")
                .HasColumnType("int");

            builder.Property(t => t.ShardID)
                .IsRequired()
                .HasColumnName("ShardID")
                .HasColumnType("int");

            builder.Property(t => t.CharName)
                .IsRequired()
                .HasColumnName("CharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SR_ShardCharNames";
        }

        public struct Columns
        {
            public const string UserJID = "UserJID";
            public const string ShardID = "ShardID";
            public const string CharName = "CharName";
        }
        #endregion
    }
}
