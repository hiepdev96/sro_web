using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class ShardServiceMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.ShardService>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.ShardService> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ShardService", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ShardID)
                .IsRequired()
                .HasColumnName("ShardID")
                .HasColumnType("smallint");

            builder.Property(t => t.ServiceType)
                .IsRequired()
                .HasColumnName("ServiceType")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ShardService";
        }

        public struct Columns
        {
            public const string ShardID = "ShardID";
            public const string ServiceType = "ServiceType";
        }
        #endregion
    }
}
