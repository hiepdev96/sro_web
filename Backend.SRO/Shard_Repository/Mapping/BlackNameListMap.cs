using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class BlackNameListMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.BlackNameList>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.BlackNameList> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_BlackNameList", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BlacklistName)
                .HasColumnName("BlacklistName")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_BlackNameList";
        }

        public struct Columns
        {
            public const string BlacklistName = "BlacklistName";
        }
        #endregion
    }
}
