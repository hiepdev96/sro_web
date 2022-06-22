using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeLvlSummonMonsterMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeLvlSummonMonster", "dbo");

            // key
            builder.HasKey(t => t.RefObjID);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.RefObjID)
                .IsRequired()
                .HasColumnName("RefObjID")
                .HasColumnType("int");

            builder.Property(t => t.RefOrgObjID)
                .IsRequired()
                .HasColumnName("RefOrgObjID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeLvlSummonMonster";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string RefObjID = "RefObjID";
            public const string RefOrgObjID = "RefOrgObjID";
        }
        #endregion
    }
}
