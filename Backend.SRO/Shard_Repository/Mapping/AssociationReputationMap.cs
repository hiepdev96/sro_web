using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class AssociationReputationMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.AssociationReputation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.AssociationReputation> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_AssociationReputation", "dbo");

            // key
            builder.HasKey(t => new { t.AssociationCodeName, t.AssociationTypeName });

            // properties
            builder.Property(t => t.AssociationCodeName)
                .IsRequired()
                .HasColumnName("AssociationCodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.AssociationTypeName)
                .IsRequired()
                .HasColumnName("AssociationTypeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Reputation)
                .IsRequired()
                .HasColumnName("Reputation")
                .HasColumnType("int");

            builder.Property(t => t.PriorOccupation)
                .IsRequired()
                .HasColumnName("PriorOccupation")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_AssociationReputation";
        }

        public struct Columns
        {
            public const string AssociationCodeName = "AssociationCodeName";
            public const string AssociationTypeName = "AssociationTypeName";
            public const string Reputation = "Reputation";
            public const string PriorOccupation = "PriorOccupation";
        }
        #endregion
    }
}
