using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class SiegeFortressStoneStateMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.SiegeFortressStoneState>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.SiegeFortressStoneState> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SiegeFortressStoneState", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.GuildID)
                .IsRequired()
                .HasColumnName("GuildID")
                .HasColumnType("int");

            builder.Property(t => t.AccumulateDamage)
                .IsRequired()
                .HasColumnName("AccumulateDamage")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.SiegeFortress)
                .WithMany(t => t.SiegeFortressStoneStates)
                .HasForeignKey(d => d.FortressID)
                .HasConstraintName("FK__SiegeFortressStoneState__SiegeFortress");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SiegeFortressStoneState";
        }

        public struct Columns
        {
            public const string FortressID = "FortressID";
            public const string GuildID = "GuildID";
            public const string AccumulateDamage = "AccumulateDamage";
        }
        #endregion
    }
}
