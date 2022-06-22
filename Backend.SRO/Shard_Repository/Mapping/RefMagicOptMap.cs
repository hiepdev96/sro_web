using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefMagicOptMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefMagicOpt>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefMagicOpt> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefMagicOpt", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("smallint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MOptName128)
                .IsRequired()
                .HasColumnName("MOptName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AttrType)
                .IsRequired()
                .HasColumnName("AttrType")
                .HasColumnType("varchar(8)")
                .HasMaxLength(8);

            builder.Property(t => t.MLevel)
                .IsRequired()
                .HasColumnName("MLevel")
                .HasColumnType("int");

            builder.Property(t => t.Prob)
                .IsRequired()
                .HasColumnName("Prob")
                .HasColumnType("real");

            builder.Property(t => t.Weight)
                .IsRequired()
                .HasColumnName("Weight")
                .HasColumnType("int");

            builder.Property(t => t.Param1)
                .IsRequired()
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Param2)
                .IsRequired()
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Param3)
                .IsRequired()
                .HasColumnName("Param3")
                .HasColumnType("int");

            builder.Property(t => t.Param4)
                .IsRequired()
                .HasColumnName("Param4")
                .HasColumnType("int");

            builder.Property(t => t.Param5)
                .IsRequired()
                .HasColumnName("Param5")
                .HasColumnType("int");

            builder.Property(t => t.Param6)
                .IsRequired()
                .HasColumnName("Param6")
                .HasColumnType("int");

            builder.Property(t => t.Param7)
                .IsRequired()
                .HasColumnName("Param7")
                .HasColumnType("int");

            builder.Property(t => t.Param8)
                .IsRequired()
                .HasColumnName("Param8")
                .HasColumnType("int");

            builder.Property(t => t.Param9)
                .IsRequired()
                .HasColumnName("Param9")
                .HasColumnType("int");

            builder.Property(t => t.Param10)
                .IsRequired()
                .HasColumnName("Param10")
                .HasColumnType("int");

            builder.Property(t => t.Param11)
                .IsRequired()
                .HasColumnName("Param11")
                .HasColumnType("int");

            builder.Property(t => t.Param12)
                .IsRequired()
                .HasColumnName("Param12")
                .HasColumnType("int");

            builder.Property(t => t.Param13)
                .IsRequired()
                .HasColumnName("Param13")
                .HasColumnType("int");

            builder.Property(t => t.Param14)
                .IsRequired()
                .HasColumnName("Param14")
                .HasColumnType("int");

            builder.Property(t => t.Param15)
                .IsRequired()
                .HasColumnName("Param15")
                .HasColumnType("int");

            builder.Property(t => t.Param16)
                .IsRequired()
                .HasColumnName("Param16")
                .HasColumnType("int");

            builder.Property(t => t.ExcFunc1)
                .IsRequired()
                .HasColumnName("ExcFunc1")
                .HasColumnType("int");

            builder.Property(t => t.ExcFunc2)
                .IsRequired()
                .HasColumnName("ExcFunc2")
                .HasColumnType("int");

            builder.Property(t => t.ExcFunc3)
                .IsRequired()
                .HasColumnName("ExcFunc3")
                .HasColumnType("int");

            builder.Property(t => t.ExcFunc4)
                .IsRequired()
                .HasColumnName("ExcFunc4")
                .HasColumnType("int");

            builder.Property(t => t.ExcFunc5)
                .IsRequired()
                .HasColumnName("ExcFunc5")
                .HasColumnType("int");

            builder.Property(t => t.ExcFunc6)
                .IsRequired()
                .HasColumnName("ExcFunc6")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup1)
                .IsRequired()
                .HasColumnName("AvailItemGroup1")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass1)
                .IsRequired()
                .HasColumnName("ReqClass1")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup2)
                .IsRequired()
                .HasColumnName("AvailItemGroup2")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass2)
                .IsRequired()
                .HasColumnName("ReqClass2")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup3)
                .IsRequired()
                .HasColumnName("AvailItemGroup3")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass3)
                .IsRequired()
                .HasColumnName("ReqClass3")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup4)
                .IsRequired()
                .HasColumnName("AvailItemGroup4")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass4)
                .IsRequired()
                .HasColumnName("ReqClass4")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup5)
                .IsRequired()
                .HasColumnName("AvailItemGroup5")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass5)
                .IsRequired()
                .HasColumnName("ReqClass5")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup6)
                .HasColumnName("AvailItemGroup6")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass6)
                .HasColumnName("ReqClass6")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup7)
                .HasColumnName("AvailItemGroup7")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass7)
                .HasColumnName("ReqClass7")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup8)
                .HasColumnName("AvailItemGroup8")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass8)
                .HasColumnName("ReqClass8")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup9)
                .HasColumnName("AvailItemGroup9")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass9)
                .HasColumnName("ReqClass9")
                .HasColumnType("int");

            builder.Property(t => t.AvailItemGroup10)
                .HasColumnName("AvailItemGroup10")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ReqClass10)
                .HasColumnName("ReqClass10")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefMagicOpt";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string MOptName128 = "MOptName128";
            public const string AttrType = "AttrType";
            public const string MLevel = "MLevel";
            public const string Prob = "Prob";
            public const string Weight = "Weight";
            public const string Param1 = "Param1";
            public const string Param2 = "Param2";
            public const string Param3 = "Param3";
            public const string Param4 = "Param4";
            public const string Param5 = "Param5";
            public const string Param6 = "Param6";
            public const string Param7 = "Param7";
            public const string Param8 = "Param8";
            public const string Param9 = "Param9";
            public const string Param10 = "Param10";
            public const string Param11 = "Param11";
            public const string Param12 = "Param12";
            public const string Param13 = "Param13";
            public const string Param14 = "Param14";
            public const string Param15 = "Param15";
            public const string Param16 = "Param16";
            public const string ExcFunc1 = "ExcFunc1";
            public const string ExcFunc2 = "ExcFunc2";
            public const string ExcFunc3 = "ExcFunc3";
            public const string ExcFunc4 = "ExcFunc4";
            public const string ExcFunc5 = "ExcFunc5";
            public const string ExcFunc6 = "ExcFunc6";
            public const string AvailItemGroup1 = "AvailItemGroup1";
            public const string ReqClass1 = "ReqClass1";
            public const string AvailItemGroup2 = "AvailItemGroup2";
            public const string ReqClass2 = "ReqClass2";
            public const string AvailItemGroup3 = "AvailItemGroup3";
            public const string ReqClass3 = "ReqClass3";
            public const string AvailItemGroup4 = "AvailItemGroup4";
            public const string ReqClass4 = "ReqClass4";
            public const string AvailItemGroup5 = "AvailItemGroup5";
            public const string ReqClass5 = "ReqClass5";
            public const string AvailItemGroup6 = "AvailItemGroup6";
            public const string ReqClass6 = "ReqClass6";
            public const string AvailItemGroup7 = "AvailItemGroup7";
            public const string ReqClass7 = "ReqClass7";
            public const string AvailItemGroup8 = "AvailItemGroup8";
            public const string ReqClass8 = "ReqClass8";
            public const string AvailItemGroup9 = "AvailItemGroup9";
            public const string ReqClass9 = "ReqClass9";
            public const string AvailItemGroup10 = "AvailItemGroup10";
            public const string ReqClass10 = "ReqClass10";
        }
        #endregion
    }
}
