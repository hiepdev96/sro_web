using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class SiegeFortressRequestMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.SiegeFortressRequest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SiegeFortressRequest", "dbo");

            // key
            builder.HasKey(t => new { t.FortressID, t.GuildID });

            // properties
            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.GuildID)
                .IsRequired()
                .HasColumnName("GuildID")
                .HasColumnType("int");

            builder.Property(t => t.RequestType)
                .IsRequired()
                .HasColumnName("RequestType")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.Guild)
                .WithMany(t => t.SiegeFortressRequests)
                .HasForeignKey(d => d.GuildID)
                .HasConstraintName("FK__SiegeFortressRequest__Guild");

            builder.HasOne(t => t.SiegeFortress)
                .WithMany(t => t.SiegeFortressRequests)
                .HasForeignKey(d => d.FortressID)
                .HasConstraintName("FK__SiegeFortressRequest__SiegeFortress");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SiegeFortressRequest";
        }

        public struct Columns
        {
            public const string FortressID = "FortressID";
            public const string GuildID = "GuildID";
            public const string RequestType = "RequestType";
        }
        #endregion
    }
}
