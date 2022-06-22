using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class UserBalanceNhatMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.UserBalanceNhat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.UserBalanceNhat> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_UserBalance_Nhat", "dbo");

            // key
            builder.HasKey(t => t.Jid);

            // properties
            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.Balance)
                .IsRequired()
                .HasColumnName("Balance")
                .HasColumnType("numeric(18,0)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_UserBalance_Nhat";
        }

        public struct Columns
        {
            public const string Jid = "JID";
            public const string Balance = "Balance";
        }
        #endregion
    }
}
