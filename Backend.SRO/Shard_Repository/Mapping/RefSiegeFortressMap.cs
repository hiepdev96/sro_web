using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeFortressMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeFortress>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeFortress> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeFortress", "dbo");

            // key
            builder.HasKey(t => t.FortressID);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.NameID128)
                .IsRequired()
                .HasColumnName("NameID128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.LinkedTeleportCodeName)
                .IsRequired()
                .HasColumnName("LinkedTeleportCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Scale)
                .IsRequired()
                .HasColumnName("Scale")
                .HasColumnType("tinyint");

            builder.Property(t => t.MaxAdmission)
                .IsRequired()
                .HasColumnName("MaxAdmission")
                .HasColumnType("smallint");

            builder.Property(t => t.MaxGuard)
                .IsRequired()
                .HasColumnName("MaxGuard")
                .HasColumnType("tinyint");

            builder.Property(t => t.MaxBarricade)
                .IsRequired()
                .HasColumnName("MaxBarricade")
                .HasColumnType("tinyint");

            builder.Property(t => t.TaxTargets)
                .IsRequired()
                .HasColumnName("TaxTargets")
                .HasColumnType("smallint");

            builder.Property(t => t.RequestFee)
                .IsRequired()
                .HasColumnName("RequestFee")
                .HasColumnType("int");

            builder.Property(t => t.CrestPath128)
                .IsRequired()
                .HasColumnName("CrestPath128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RequestNPCName128)
                .IsRequired()
                .HasColumnName("RequestNPCName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeFortress";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string FortressID = "FortressID";
            public const string CodeName128 = "CodeName128";
            public const string Name = "Name";
            public const string NameID128 = "NameID128";
            public const string LinkedTeleportCodeName = "LinkedTeleportCodeName";
            public const string Scale = "Scale";
            public const string MaxAdmission = "MaxAdmission";
            public const string MaxGuard = "MaxGuard";
            public const string MaxBarricade = "MaxBarricade";
            public const string TaxTargets = "TaxTargets";
            public const string RequestFee = "RequestFee";
            public const string CrestPath128 = "CrestPath128";
            public const string RequestNPCName128 = "RequestNPCName128";
        }
        #endregion
    }
}
