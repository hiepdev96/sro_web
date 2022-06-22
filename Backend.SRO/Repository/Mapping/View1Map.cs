using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class View1Map
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.View1>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.View1> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("VIEW1", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("float");

            builder.Property(t => t.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SumSilk)
                .HasColumnName("Sum_Silk")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "VIEW1";
        }

        public struct Columns
        {
            public const string ItemId = "ITEM_ID";
            public const string ItemName = "ITEM_NAME";
            public const string SumSilk = "Sum_Silk";
        }
        #endregion
    }
}
