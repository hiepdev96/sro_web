using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefMagicOptAssignMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefMagicOptAssign>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefMagicOptAssign> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefMagicOptAssign", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.Race)
                .IsRequired()
                .HasColumnName("Race")
                .HasColumnType("tinyint");

            builder.Property(t => t.Tid3)
                .IsRequired()
                .HasColumnName("TID3")
                .HasColumnType("tinyint");

            builder.Property(t => t.Tid4)
                .IsRequired()
                .HasColumnName("TID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.AvailMOpt1)
                .IsRequired()
                .HasColumnName("AvailMOpt1")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt2)
                .IsRequired()
                .HasColumnName("AvailMOpt2")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt3)
                .IsRequired()
                .HasColumnName("AvailMOpt3")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt4)
                .IsRequired()
                .HasColumnName("AvailMOpt4")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt5)
                .IsRequired()
                .HasColumnName("AvailMOpt5")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt6)
                .IsRequired()
                .HasColumnName("AvailMOpt6")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt7)
                .IsRequired()
                .HasColumnName("AvailMOpt7")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt8)
                .IsRequired()
                .HasColumnName("AvailMOpt8")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt9)
                .IsRequired()
                .HasColumnName("AvailMOpt9")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt10)
                .IsRequired()
                .HasColumnName("AvailMOpt10")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt11)
                .IsRequired()
                .HasColumnName("AvailMOpt11")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt12)
                .IsRequired()
                .HasColumnName("AvailMOpt12")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt13)
                .IsRequired()
                .HasColumnName("AvailMOpt13")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt14)
                .IsRequired()
                .HasColumnName("AvailMOpt14")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt15)
                .IsRequired()
                .HasColumnName("AvailMOpt15")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt16)
                .IsRequired()
                .HasColumnName("AvailMOpt16")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt17)
                .IsRequired()
                .HasColumnName("AvailMOpt17")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt18)
                .IsRequired()
                .HasColumnName("AvailMOpt18")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt19)
                .IsRequired()
                .HasColumnName("AvailMOpt19")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt20)
                .IsRequired()
                .HasColumnName("AvailMOpt20")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt21)
                .IsRequired()
                .HasColumnName("AvailMOpt21")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt22)
                .IsRequired()
                .HasColumnName("AvailMOpt22")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt23)
                .IsRequired()
                .HasColumnName("AvailMOpt23")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt24)
                .IsRequired()
                .HasColumnName("AvailMOpt24")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AvailMOpt25)
                .IsRequired()
                .HasColumnName("AvailMOpt25")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefMagicOptAssign";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Race = "Race";
            public const string Tid3 = "TID3";
            public const string Tid4 = "TID4";
            public const string AvailMOpt1 = "AvailMOpt1";
            public const string AvailMOpt2 = "AvailMOpt2";
            public const string AvailMOpt3 = "AvailMOpt3";
            public const string AvailMOpt4 = "AvailMOpt4";
            public const string AvailMOpt5 = "AvailMOpt5";
            public const string AvailMOpt6 = "AvailMOpt6";
            public const string AvailMOpt7 = "AvailMOpt7";
            public const string AvailMOpt8 = "AvailMOpt8";
            public const string AvailMOpt9 = "AvailMOpt9";
            public const string AvailMOpt10 = "AvailMOpt10";
            public const string AvailMOpt11 = "AvailMOpt11";
            public const string AvailMOpt12 = "AvailMOpt12";
            public const string AvailMOpt13 = "AvailMOpt13";
            public const string AvailMOpt14 = "AvailMOpt14";
            public const string AvailMOpt15 = "AvailMOpt15";
            public const string AvailMOpt16 = "AvailMOpt16";
            public const string AvailMOpt17 = "AvailMOpt17";
            public const string AvailMOpt18 = "AvailMOpt18";
            public const string AvailMOpt19 = "AvailMOpt19";
            public const string AvailMOpt20 = "AvailMOpt20";
            public const string AvailMOpt21 = "AvailMOpt21";
            public const string AvailMOpt22 = "AvailMOpt22";
            public const string AvailMOpt23 = "AvailMOpt23";
            public const string AvailMOpt24 = "AvailMOpt24";
            public const string AvailMOpt25 = "AvailMOpt25";
        }
        #endregion
    }
}
