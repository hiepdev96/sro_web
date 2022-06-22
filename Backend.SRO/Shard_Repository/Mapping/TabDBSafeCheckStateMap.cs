using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TabDBSafeCheckStateMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TabDBSafeCheckState>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TabDBSafeCheckState> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Tab_DBSafe_CheckState", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BtCheckIn)
                .HasColumnName("btCheckIn")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Tab_DBSafe_CheckState";
        }

        public struct Columns
        {
            public const string BtCheckIn = "btCheckIn";
        }
        #endregion
    }
}
