using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TimedJobForPetMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TimedJobForPet>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TimedJobForPet> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_TimedJobForPet", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.Category)
                .IsRequired()
                .HasColumnName("Category")
                .HasColumnType("tinyint");

            builder.Property(t => t.JobID)
                .IsRequired()
                .HasColumnName("JobID")
                .HasColumnType("int");

            builder.Property(t => t.TimeToKeep)
                .IsRequired()
                .HasColumnName("TimeToKeep")
                .HasColumnType("int");

            builder.Property(t => t.Data1)
                .HasColumnName("Data1")
                .HasColumnType("int");

            builder.Property(t => t.Data2)
                .HasColumnName("Data2")
                .HasColumnType("int");

            builder.Property(t => t.Data3)
                .HasColumnName("Data3")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.Data4)
                .HasColumnName("Data4")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.Data5)
                .HasColumnName("Data5")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.Data6)
                .HasColumnName("Data6")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.Data7)
                .HasColumnName("Data7")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.Data8)
                .HasColumnName("Data8")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.Serial64)
                .IsRequired()
                .HasColumnName("Serial64")
                .HasColumnType("bigint");

            builder.Property(t => t.Jid)
                .HasColumnName("JID")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_TimedJobForPet";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string CharID = "CharID";
            public const string Category = "Category";
            public const string JobID = "JobID";
            public const string TimeToKeep = "TimeToKeep";
            public const string Data1 = "Data1";
            public const string Data2 = "Data2";
            public const string Data3 = "Data3";
            public const string Data4 = "Data4";
            public const string Data5 = "Data5";
            public const string Data6 = "Data6";
            public const string Data7 = "Data7";
            public const string Data8 = "Data8";
            public const string Serial64 = "Serial64";
            public const string Jid = "JID";
        }
        #endregion
    }
}
