using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class FriendMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.Friend>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.Friend> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Friend", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.FriendCharID)
                .IsRequired()
                .HasColumnName("FriendCharID")
                .HasColumnType("int");

            builder.Property(t => t.FriendCharName)
                .IsRequired()
                .HasColumnName("FriendCharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.RefObjID)
                .HasColumnName("RefObjID")
                .HasColumnType("int")
                .HasDefaultValueSql("(0)");

            // relationships
            builder.HasOne(t => t.Char)
                .WithOne(t => t.Friend)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.Friend>(d => d.CharID)
                .HasConstraintName("FK__Friend__Char");

            builder.HasOne(t => t.Char1)
                .WithMany(t => t.Friends)
                .HasForeignKey(d => d.FriendCharID)
                .HasConstraintName("FK__Friend__Char1");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Friend";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string FriendCharID = "FriendCharID";
            public const string FriendCharName = "FriendCharName";
            public const string RefObjID = "RefObjID";
        }
        #endregion
    }
}
