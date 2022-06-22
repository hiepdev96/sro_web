using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class WriteOutResetPlayTimeMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.WriteOutResetPlayTime>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.WriteOutResetPlayTime> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_WriteOutResetPlayTime", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.LatestResetTime)
                .IsRequired()
                .HasColumnName("LatestResetTime")
                .HasColumnType("int")
                .HasDefaultValueSql("((1))");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_WriteOutResetPlayTime";
        }

        public struct Columns
        {
            public const string LatestResetTime = "LatestResetTime";
        }
        #endregion
    }
}
