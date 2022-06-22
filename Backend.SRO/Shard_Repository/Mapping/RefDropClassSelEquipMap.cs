using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDropClassSelEquipMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDropClassSelEquip>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDropClassSelEquip> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDropClassSel_Equip", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.MonLevel)
                .IsRequired()
                .HasColumnName("MonLevel")
                .HasColumnType("int");

            builder.Property(t => t.ProbGroup1)
                .IsRequired()
                .HasColumnName("ProbGroup1")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup2)
                .IsRequired()
                .HasColumnName("ProbGroup2")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup3)
                .IsRequired()
                .HasColumnName("ProbGroup3")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup4)
                .IsRequired()
                .HasColumnName("ProbGroup4")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup5)
                .IsRequired()
                .HasColumnName("ProbGroup5")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup6)
                .IsRequired()
                .HasColumnName("ProbGroup6")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup7)
                .IsRequired()
                .HasColumnName("ProbGroup7")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup8)
                .IsRequired()
                .HasColumnName("ProbGroup8")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup9)
                .IsRequired()
                .HasColumnName("ProbGroup9")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup10)
                .IsRequired()
                .HasColumnName("ProbGroup10")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup11)
                .IsRequired()
                .HasColumnName("ProbGroup11")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup12)
                .IsRequired()
                .HasColumnName("ProbGroup12")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup13)
                .IsRequired()
                .HasColumnName("ProbGroup13")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup14)
                .IsRequired()
                .HasColumnName("ProbGroup14")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup15)
                .IsRequired()
                .HasColumnName("ProbGroup15")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup16)
                .IsRequired()
                .HasColumnName("ProbGroup16")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup17)
                .IsRequired()
                .HasColumnName("ProbGroup17")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup18)
                .IsRequired()
                .HasColumnName("ProbGroup18")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup19)
                .IsRequired()
                .HasColumnName("ProbGroup19")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup20)
                .IsRequired()
                .HasColumnName("ProbGroup20")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup21)
                .IsRequired()
                .HasColumnName("ProbGroup21")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup22)
                .IsRequired()
                .HasColumnName("ProbGroup22")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup23)
                .IsRequired()
                .HasColumnName("ProbGroup23")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup24)
                .IsRequired()
                .HasColumnName("ProbGroup24")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup25)
                .IsRequired()
                .HasColumnName("ProbGroup25")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup26)
                .IsRequired()
                .HasColumnName("ProbGroup26")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup27)
                .IsRequired()
                .HasColumnName("ProbGroup27")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup28)
                .IsRequired()
                .HasColumnName("ProbGroup28")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup29)
                .IsRequired()
                .HasColumnName("ProbGroup29")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup30)
                .IsRequired()
                .HasColumnName("ProbGroup30")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup31)
                .IsRequired()
                .HasColumnName("ProbGroup31")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup32)
                .IsRequired()
                .HasColumnName("ProbGroup32")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup33)
                .IsRequired()
                .HasColumnName("ProbGroup33")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup34)
                .IsRequired()
                .HasColumnName("ProbGroup34")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup35)
                .IsRequired()
                .HasColumnName("ProbGroup35")
                .HasColumnType("real");

            builder.Property(t => t.ProbGroup36)
                .IsRequired()
                .HasColumnName("ProbGroup36")
                .HasColumnType("real");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDropClassSel_Equip";
        }

        public struct Columns
        {
            public const string MonLevel = "MonLevel";
            public const string ProbGroup1 = "ProbGroup1";
            public const string ProbGroup2 = "ProbGroup2";
            public const string ProbGroup3 = "ProbGroup3";
            public const string ProbGroup4 = "ProbGroup4";
            public const string ProbGroup5 = "ProbGroup5";
            public const string ProbGroup6 = "ProbGroup6";
            public const string ProbGroup7 = "ProbGroup7";
            public const string ProbGroup8 = "ProbGroup8";
            public const string ProbGroup9 = "ProbGroup9";
            public const string ProbGroup10 = "ProbGroup10";
            public const string ProbGroup11 = "ProbGroup11";
            public const string ProbGroup12 = "ProbGroup12";
            public const string ProbGroup13 = "ProbGroup13";
            public const string ProbGroup14 = "ProbGroup14";
            public const string ProbGroup15 = "ProbGroup15";
            public const string ProbGroup16 = "ProbGroup16";
            public const string ProbGroup17 = "ProbGroup17";
            public const string ProbGroup18 = "ProbGroup18";
            public const string ProbGroup19 = "ProbGroup19";
            public const string ProbGroup20 = "ProbGroup20";
            public const string ProbGroup21 = "ProbGroup21";
            public const string ProbGroup22 = "ProbGroup22";
            public const string ProbGroup23 = "ProbGroup23";
            public const string ProbGroup24 = "ProbGroup24";
            public const string ProbGroup25 = "ProbGroup25";
            public const string ProbGroup26 = "ProbGroup26";
            public const string ProbGroup27 = "ProbGroup27";
            public const string ProbGroup28 = "ProbGroup28";
            public const string ProbGroup29 = "ProbGroup29";
            public const string ProbGroup30 = "ProbGroup30";
            public const string ProbGroup31 = "ProbGroup31";
            public const string ProbGroup32 = "ProbGroup32";
            public const string ProbGroup33 = "ProbGroup33";
            public const string ProbGroup34 = "ProbGroup34";
            public const string ProbGroup35 = "ProbGroup35";
            public const string ProbGroup36 = "ProbGroup36";
        }
        #endregion
    }
}
