using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class FlagWorldEventParticipantsMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.FlagWorldEventParticipants>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.FlagWorldEventParticipants> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_FlagWorld_EventParticipants", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.LatestAttempt)
                .IsRequired()
                .HasColumnName("LatestAttempt")
                .HasColumnType("datetime");

            builder.Property(t => t.Count)
                .IsRequired()
                .HasColumnName("Count")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_FlagWorld_EventParticipants";
        }

        public struct Columns
        {
            public const string Jid = "JID";
            public const string LatestAttempt = "LatestAttempt";
            public const string Count = "Count";
        }
        #endregion
    }
}
