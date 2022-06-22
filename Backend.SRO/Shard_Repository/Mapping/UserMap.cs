using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class UserMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.User> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_User", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.UserJID)
                .IsRequired()
                .HasColumnName("UserJID")
                .HasColumnType("int");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.JAccountJID)
                .WithMany(t => t.JUsers)
                .HasForeignKey(d => d.UserJID)
                .HasConstraintName("FK__User__AccountJID");

            builder.HasOne(t => t.Char)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.CharID)
                .HasConstraintName("FK__User__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_User";
        }

        public struct Columns
        {
            public const string UserJID = "UserJID";
            public const string CharID = "CharID";
        }
        #endregion
    }
}
