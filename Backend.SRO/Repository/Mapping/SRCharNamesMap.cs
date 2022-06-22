using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SRCharNamesMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SRCharNames>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SRCharNames> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SR_CharNames", "dbo");

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
                .HasColumnType("smallint");

            builder.Property(t => t.CharID1)
                .IsRequired()
                .HasColumnName("CharID_1")
                .HasColumnType("varchar(17)")
                .HasMaxLength(17);

            builder.Property(t => t.CharID2)
                .HasColumnName("CharID_2")
                .HasColumnType("varchar(17)")
                .HasMaxLength(17);

            builder.Property(t => t.CharID3)
                .HasColumnName("CharID_3")
                .HasColumnType("varchar(17)")
                .HasMaxLength(17);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SR_CharNames";
        }

        public struct Columns
        {
            public const string UserJID = "UserJID";
            public const string ShardID = "ShardID";
            public const string CharID1 = "CharID_1";
            public const string CharID2 = "CharID_2";
            public const string CharID3 = "CharID_3";
        }
        #endregion
    }
}
