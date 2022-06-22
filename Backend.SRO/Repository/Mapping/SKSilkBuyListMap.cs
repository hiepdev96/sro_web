using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKSilkBuyListMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKSilkBuyList>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKSilkBuyList> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_SilkBuyList", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BuyNo)
                .IsRequired()
                .HasColumnName("BuyNo")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserJID)
                .IsRequired()
                .HasColumnName("UserJID")
                .HasColumnType("int");

            builder.Property(t => t.SilkType)
                .IsRequired()
                .HasColumnName("Silk_Type")
                .HasColumnType("tinyint");

            builder.Property(t => t.SilkReason)
                .IsRequired()
                .HasColumnName("Silk_Reason")
                .HasColumnType("tinyint");

            builder.Property(t => t.SilkOffset)
                .IsRequired()
                .HasColumnName("Silk_Offset")
                .HasColumnType("int");

            builder.Property(t => t.SilkRemain)
                .IsRequired()
                .HasColumnName("Silk_Remain")
                .HasColumnType("int");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(t => t.BuyQuantity)
                .IsRequired()
                .HasColumnName("BuyQuantity")
                .HasColumnType("int");

            builder.Property(t => t.OrderNumber)
                .IsRequired()
                .HasColumnName("OrderNumber")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.PGCompany)
                .HasColumnName("PGCompany")
                .HasColumnType("tinyint");

            builder.Property(t => t.PayMethod)
                .HasColumnName("PayMethod")
                .HasColumnType("tinyint");

            builder.Property(t => t.PGUniqueNo)
                .HasColumnName("PGUniqueNo")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.AuthNumber)
                .HasColumnName("AuthNumber")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.AuthDate)
                .HasColumnName("AuthDate")
                .HasColumnType("datetime");

            builder.Property(t => t.SubJID)
                .HasColumnName("SubJID")
                .HasColumnType("int");

            builder.Property(t => t.SrID)
                .HasColumnName("srID")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.SlipPaper)
                .IsRequired()
                .HasColumnName("SlipPaper")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.MngID)
                .HasColumnName("MngID")
                .HasColumnType("int");

            builder.Property(t => t.Ip)
                .HasColumnName("IP")
                .HasColumnType("varchar(16)")
                .HasMaxLength(16);

            builder.Property(t => t.RegDate)
                .IsRequired()
                .HasColumnName("RegDate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_SilkBuyList";
        }

        public struct Columns
        {
            public const string BuyNo = "BuyNo";
            public const string UserJID = "UserJID";
            public const string SilkType = "Silk_Type";
            public const string SilkReason = "Silk_Reason";
            public const string SilkOffset = "Silk_Offset";
            public const string SilkRemain = "Silk_Remain";
            public const string Id = "ID";
            public const string BuyQuantity = "BuyQuantity";
            public const string OrderNumber = "OrderNumber";
            public const string PGCompany = "PGCompany";
            public const string PayMethod = "PayMethod";
            public const string PGUniqueNo = "PGUniqueNo";
            public const string AuthNumber = "AuthNumber";
            public const string AuthDate = "AuthDate";
            public const string SubJID = "SubJID";
            public const string SrID = "srID";
            public const string SlipPaper = "SlipPaper";
            public const string MngID = "MngID";
            public const string Ip = "IP";
            public const string RegDate = "RegDate";
        }
        #endregion
    }
}
