using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class DeletedCharMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.DeletedChar>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.DeletedChar> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_DeletedChar", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.UserJID)
                .IsRequired()
                .HasColumnName("UserJID")
                .HasColumnType("int");

            builder.Property(t => t.DeletedDate)
                .IsRequired()
                .HasColumnName("DeletedDate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_DeletedChar";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string UserJID = "UserJID";
            public const string DeletedDate = "DeletedDate";
        }
        #endregion
    }
}
