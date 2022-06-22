using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ChestInfoMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ChestInfo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ChestInfo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ChestInfo", "dbo");

            // key
            builder.HasKey(t => t.Jid);

            // properties
            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.ChestSize)
                .IsRequired()
                .HasColumnName("ChestSize")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("(150)");

            // relationships
            builder.HasOne(t => t.AccountJID)
                .WithOne(t => t.ChestInfo)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.ChestInfo>(d => d.Jid)
                .HasConstraintName("FK__ChestInfo__AccountJID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ChestInfo";
        }

        public struct Columns
        {
            public const string Jid = "JID";
            public const string ChestSize = "ChestSize";
        }
        #endregion
    }
}
