using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TbPaygateTransMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.TbPaygateTrans>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.TbPaygateTrans> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tb_paygate_trans", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.TransID)
                .IsRequired()
                .HasColumnName("trans_ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TransDate)
                .HasColumnName("trans_date")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.TransType)
                .HasColumnName("trans_type")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.BankId)
                .HasColumnName("bank_id")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.AccountId)
                .HasColumnName("account_id")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.OrderNo)
                .HasColumnName("order_no")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.MoneyValue)
                .HasColumnName("moneyValue")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.BeforeMoney)
                .HasColumnName("beforeMoney")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.AfterMoney)
                .HasColumnName("afterMoney")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.PGTransID)
                .HasColumnName("PG_TransID")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "tb_paygate_trans";
        }

        public struct Columns
        {
            public const string TransID = "trans_ID";
            public const string TransDate = "trans_date";
            public const string TransType = "trans_type";
            public const string BankId = "bank_id";
            public const string AccountId = "account_id";
            public const string OrderNo = "order_no";
            public const string MoneyValue = "moneyValue";
            public const string BeforeMoney = "beforeMoney";
            public const string AfterMoney = "afterMoney";
            public const string PGTransID = "PG_TransID";
        }
        #endregion
    }
}
