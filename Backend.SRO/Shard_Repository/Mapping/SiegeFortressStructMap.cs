using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class SiegeFortressStructMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.SiegeFortressStruct>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.SiegeFortressStruct> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_SiegeFortressStruct", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.OwnerGuildID)
                .IsRequired()
                .HasColumnName("OwnerGuildID")
                .HasColumnType("int");

            builder.Property(t => t.RefEventStructID)
                .IsRequired()
                .HasColumnName("RefEventStructID")
                .HasColumnType("int");

            builder.Property(t => t.RefObjID)
                .IsRequired()
                .HasColumnName("RefObjID")
                .HasColumnType("int");

            builder.Property(t => t.Hp)
                .IsRequired()
                .HasColumnName("HP")
                .HasColumnType("int");

            builder.Property(t => t.MakeDate)
                .IsRequired()
                .HasColumnName("MakeDate")
                .HasColumnType("datetime");

            builder.Property(t => t.State)
                .IsRequired()
                .HasColumnName("State")
                .HasColumnType("smallint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_SiegeFortressStruct";
        }

        public struct Columns
        {
            public const string FortressID = "FortressID";
            public const string OwnerGuildID = "OwnerGuildID";
            public const string RefEventStructID = "RefEventStructID";
            public const string RefObjID = "RefObjID";
            public const string Hp = "HP";
            public const string MakeDate = "MakeDate";
            public const string State = "State";
        }
        #endregion
    }
}
