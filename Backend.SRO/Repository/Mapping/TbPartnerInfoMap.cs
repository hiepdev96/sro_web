using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TbPartnerInfoMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.TbPartnerInfo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.TbPartnerInfo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tb_partnerInfo", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.PartnerID)
                .IsRequired()
                .HasColumnName("partnerID")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.PartnerName)
                .HasColumnName("partnerName")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.PartnerPass)
                .HasColumnName("partnerPass")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Balance)
                .HasColumnName("balance")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.Udate)
                .HasColumnName("udate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "tb_partnerInfo";
        }

        public struct Columns
        {
            public const string PartnerID = "partnerID";
            public const string PartnerName = "partnerName";
            public const string PartnerPass = "partnerPass";
            public const string Balance = "balance";
            public const string Udate = "udate";
        }
        #endregion
    }
}
