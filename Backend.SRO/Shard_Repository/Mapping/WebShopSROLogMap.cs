using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class WebShopSROLogMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.WebShopSROLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.WebShopSROLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_WebShop_SRO_Log", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.Ip)
                .IsRequired()
                .HasColumnName("IP")
                .HasColumnType("char(16)")
                .HasMaxLength(16);

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.BalanceBeforeBuy)
                .IsRequired()
                .HasColumnName("Balance_Before_Buy")
                .HasColumnType("numeric(18,0)");

            builder.Property(t => t.BalanceAfterBuy)
                .IsRequired()
                .HasColumnName("Balance_After_Buy")
                .HasColumnType("numeric(18,0)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_WebShop_SRO_Log";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Jid = "JID";
            public const string Ip = "IP";
            public const string CodeName128 = "CodeName128";
            public const string BalanceBeforeBuy = "Balance_Before_Buy";
            public const string BalanceAfterBuy = "Balance_After_Buy";
        }
        #endregion
    }
}
