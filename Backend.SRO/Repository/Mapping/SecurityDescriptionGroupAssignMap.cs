using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SecurityDescriptionGroupAssignMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SecurityDescriptionGroupAssign>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SecurityDescriptionGroupAssign> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SecurityDescriptionGroupAssign", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.NGroupID)
                .IsRequired()
                .HasColumnName("nGroupID")
                .HasColumnType("tinyint");

            builder.Property(t => t.NDescriptionID)
                .IsRequired()
                .HasColumnName("nDescriptionID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SecurityDescriptionGroupAssign";
        }

        public struct Columns
        {
            public const string NGroupID = "nGroupID";
            public const string NDescriptionID = "nDescriptionID";
        }
        #endregion
    }
}
