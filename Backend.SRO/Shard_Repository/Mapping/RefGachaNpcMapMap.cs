using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefGachaNpcMapMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefGachaNpcMap>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefGachaNpcMap> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefGachaNpcMap", "dbo");

            // key
            builder.HasKey(t => t.NpcId);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.NpcId)
                .IsRequired()
                .HasColumnName("NPC_ID")
                .HasColumnType("int");

            builder.Property(t => t.SelectionGachaID)
                .IsRequired()
                .HasColumnName("SelectionGachaID")
                .HasColumnType("int");

            builder.Property(t => t.WasteGachaID)
                .IsRequired()
                .HasColumnName("WasteGachaID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefGachaNpcMap";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string NpcId = "NPC_ID";
            public const string SelectionGachaID = "SelectionGachaID";
            public const string WasteGachaID = "WasteGachaID";
        }
        #endregion
    }
}
