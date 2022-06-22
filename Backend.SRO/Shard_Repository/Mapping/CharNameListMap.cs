using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharNameListMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharNameList>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharNameList> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharNameList", "dbo");

            // key
            builder.HasKey(t => new { t.CharName16, t.CharID });

            // properties
            builder.Property(t => t.CharName16)
                .IsRequired()
                .HasColumnName("CharName16")
                .HasColumnType("varchar(17)")
                .HasMaxLength(17);

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharNameList";
        }

        public struct Columns
        {
            public const string CharName16 = "CharName16";
            public const string CharID = "CharID";
        }
        #endregion
    }
}
