using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTeleLinkMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTeleLink>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTeleLink> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTeleLink", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.OwnerTeleport)
                .IsRequired()
                .HasColumnName("OwnerTeleport")
                .HasColumnType("int");

            builder.Property(t => t.TargetTeleport)
                .IsRequired()
                .HasColumnName("TargetTeleport")
                .HasColumnType("int");

            builder.Property(t => t.Fee)
                .IsRequired()
                .HasColumnName("Fee")
                .HasColumnType("int");

            builder.Property(t => t.RestrictBindMethod)
                .IsRequired()
                .HasColumnName("RestrictBindMethod")
                .HasColumnType("tinyint");

            builder.Property(t => t.RunTimeTeleportMethod)
                .IsRequired()
                .HasColumnName("RunTimeTeleportMethod")
                .HasColumnType("tinyint");

            builder.Property(t => t.CheckResult)
                .IsRequired()
                .HasColumnName("CheckResult")
                .HasColumnType("tinyint");

            builder.Property(t => t.Restrict1)
                .IsRequired()
                .HasColumnName("Restrict1")
                .HasColumnType("int");

            builder.Property(t => t.Data11)
                .HasColumnName("Data1_1")
                .HasColumnType("int");

            builder.Property(t => t.Data12)
                .HasColumnName("Data1_2")
                .HasColumnType("int");

            builder.Property(t => t.Restrict2)
                .IsRequired()
                .HasColumnName("Restrict2")
                .HasColumnType("int");

            builder.Property(t => t.Data21)
                .HasColumnName("Data2_1")
                .HasColumnType("int");

            builder.Property(t => t.Data22)
                .HasColumnName("Data2_2")
                .HasColumnType("int");

            builder.Property(t => t.Restrict3)
                .IsRequired()
                .HasColumnName("Restrict3")
                .HasColumnType("int");

            builder.Property(t => t.Data31)
                .HasColumnName("Data3_1")
                .HasColumnType("int");

            builder.Property(t => t.Data32)
                .HasColumnName("Data3_2")
                .HasColumnType("int");

            builder.Property(t => t.Restrict4)
                .IsRequired()
                .HasColumnName("Restrict4")
                .HasColumnType("int");

            builder.Property(t => t.Data41)
                .HasColumnName("Data4_1")
                .HasColumnType("int");

            builder.Property(t => t.Data42)
                .HasColumnName("Data4_2")
                .HasColumnType("int");

            builder.Property(t => t.Restrict5)
                .IsRequired()
                .HasColumnName("Restrict5")
                .HasColumnType("int");

            builder.Property(t => t.Data51)
                .HasColumnName("Data5_1")
                .HasColumnType("int");

            builder.Property(t => t.Data52)
                .HasColumnName("Data5_2")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTeleLink";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string OwnerTeleport = "OwnerTeleport";
            public const string TargetTeleport = "TargetTeleport";
            public const string Fee = "Fee";
            public const string RestrictBindMethod = "RestrictBindMethod";
            public const string RunTimeTeleportMethod = "RunTimeTeleportMethod";
            public const string CheckResult = "CheckResult";
            public const string Restrict1 = "Restrict1";
            public const string Data11 = "Data1_1";
            public const string Data12 = "Data1_2";
            public const string Restrict2 = "Restrict2";
            public const string Data21 = "Data2_1";
            public const string Data22 = "Data2_2";
            public const string Restrict3 = "Restrict3";
            public const string Data31 = "Data3_1";
            public const string Data32 = "Data3_2";
            public const string Restrict4 = "Restrict4";
            public const string Data41 = "Data4_1";
            public const string Data42 = "Data4_2";
            public const string Restrict5 = "Restrict5";
            public const string Data51 = "Data5_1";
            public const string Data52 = "Data5_2";
        }
        #endregion
    }
}
