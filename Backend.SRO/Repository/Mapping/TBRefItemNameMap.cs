using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TBRefItemNameMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.TBRefItemName>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.TBRefItemName> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("TB_Ref_ItemName", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("float");

            builder.Property(t => t.ItemSilk)
                .HasColumnName("ITEM_SILK")
                .HasColumnType("float");

            builder.Property(t => t.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ItemNameUk)
                .HasColumnName("ITEM_NAME_UK")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "TB_Ref_ItemName";
        }

        public struct Columns
        {
            public const string ItemId = "ITEM_ID";
            public const string ItemSilk = "ITEM_SILK";
            public const string ItemName = "ITEM_NAME";
            public const string ItemNameUk = "ITEM_NAME_UK";
        }
        #endregion
    }
}
