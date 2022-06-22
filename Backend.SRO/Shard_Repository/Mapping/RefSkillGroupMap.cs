using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSkillGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSkillGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSkillGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSkillGroup", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("Code")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSkillGroup";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Code = "Code";
        }
        #endregion
    }
}
