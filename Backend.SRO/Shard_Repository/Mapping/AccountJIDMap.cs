using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class AccountJIDMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.AccountJID>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.AccountJID> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_AccountJID", "dbo");

            // key
            builder.HasKey(t => t.AccountID);

            // properties
            builder.Property(t => t.AccountID)
                .IsRequired()
                .HasColumnName("AccountID")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.Gold)
                .IsRequired()
                .HasColumnName("Gold")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_AccountJID";
        }

        public struct Columns
        {
            public const string AccountID = "AccountID";
            public const string Jid = "JID";
            public const string Gold = "Gold";
        }
        #endregion
    }
}
