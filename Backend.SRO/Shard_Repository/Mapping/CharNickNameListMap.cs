using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharNickNameListMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharNickNameList>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharNickNameList> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharNickNameList", "dbo");

            // key
            builder.HasKey(t => new { t.NickName16, t.CharID });

            // properties
            builder.Property(t => t.NickName16)
                .IsRequired()
                .HasColumnName("NickName16")
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
            public const string Name = "_CharNickNameList";
        }

        public struct Columns
        {
            public const string NickName16 = "NickName16";
            public const string CharID = "CharID";
        }
        #endregion
    }
}
