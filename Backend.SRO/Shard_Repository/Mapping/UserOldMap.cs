using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class UserOldMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.UserOld>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.UserOld> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_UserOld", "dbo");

            // key
            builder.HasKey(t => t.UserJID);

            // properties
            builder.Property(t => t.UserJID)
                .IsRequired()
                .HasColumnName("UserJID")
                .HasColumnType("int");

            builder.Property(t => t.CharID1)
                .IsRequired()
                .HasColumnName("CharID1")
                .HasColumnType("int");

            builder.Property(t => t.CharID2)
                .IsRequired()
                .HasColumnName("CharID2")
                .HasColumnType("int");

            builder.Property(t => t.CharID3)
                .IsRequired()
                .HasColumnName("CharID3")
                .HasColumnType("int");

            builder.Property(t => t.Gold)
                .IsRequired()
                .HasColumnName("Gold")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_UserOld";
        }

        public struct Columns
        {
            public const string UserJID = "UserJID";
            public const string CharID1 = "CharID1";
            public const string CharID2 = "CharID2";
            public const string CharID3 = "CharID3";
            public const string Gold = "Gold";
        }
        #endregion
    }
}
