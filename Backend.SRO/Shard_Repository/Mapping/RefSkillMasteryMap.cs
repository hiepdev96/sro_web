using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSkillMasteryMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSkillMastery>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSkillMastery> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSkillMastery", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("Code")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Weapon)
                .IsRequired()
                .HasColumnName("Weapon")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSkillMastery";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Code = "Code";
            public const string Weapon = "Weapon";
        }
        #endregion
    }
}
