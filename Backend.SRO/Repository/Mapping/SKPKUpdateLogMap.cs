using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKPKUpdateLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKPKUpdateLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKPKUpdateLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_PK_UpdateLog", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.CharID)
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.CharName)
                .HasColumnName("CharName")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.PackageItemID)
                .IsRequired()
                .HasColumnName("PackageItemID")
                .HasColumnType("int");

            builder.Property(t => t.SilkOwn)
                .HasColumnName("Silk_Own")
                .HasColumnType("int");

            builder.Property(t => t.SilkBefore)
                .HasColumnName("Silk_Before")
                .HasColumnType("int");

            builder.Property(t => t.SilkAfter)
                .HasColumnName("Silk_After")
                .HasColumnType("int");

            builder.Property(t => t.GoldRemain)
                .HasColumnName("Gold_Remain")
                .HasColumnType("bigint");

            builder.Property(t => t.GoldBefore)
                .HasColumnName("Gold_Before")
                .HasColumnType("bigint");

            builder.Property(t => t.GoldAfter)
                .HasColumnName("Gold_After")
                .HasColumnType("bigint");

            builder.Property(t => t.Ip)
                .IsRequired()
                .HasColumnName("IP")
                .HasColumnType("int");

            builder.Property(t => t.RegDate)
                .IsRequired()
                .HasColumnName("RegDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.Serial64)
                .HasColumnName("Serial64")
                .HasColumnType("bigint")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.ShardID)
                .HasColumnName("ShardID")
                .HasColumnType("int");

            builder.Property(t => t.ServiceCode)
                .HasColumnName("ServiceCode")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Strength)
                .HasColumnName("_Strength")
                .HasColumnType("int");

            builder.Property(t => t.Intellect)
                .HasColumnName("_Intellect")
                .HasColumnType("int");

            builder.Property(t => t.CurLevel)
                .HasColumnName("_CurLevel")
                .HasColumnType("int");

            builder.Property(t => t.Statpoint)
                .HasColumnName("_Statpoint")
                .HasColumnType("int");

            builder.Property(t => t.NewName)
                .HasColumnName("_NewName")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.OldPetName)
                .HasColumnName("_OldPetName")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.NewPetName)
                .HasColumnName("_NewPetName")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.NewStatPoint)
                .HasColumnName("_NewStatPoint")
                .HasColumnType("int");

            builder.Property(t => t.NewLevel)
                .HasColumnName("_NewLevel")
                .HasColumnType("int");

            builder.Property(t => t.NewStrength)
                .HasColumnName("_NewStrength")
                .HasColumnType("int");

            builder.Property(t => t.NewIntellect)
                .HasColumnName("_NewIntellect")
                .HasColumnType("int");

            builder.Property(t => t.SkillOwn)
                .HasColumnName("_Skill_Own")
                .HasColumnType("int");

            builder.Property(t => t.SkillBefore)
                .HasColumnName("_Skill_Before")
                .HasColumnType("int");

            builder.Property(t => t.SkillAfter)
                .HasColumnName("_Skill_After")
                .HasColumnType("int");

            builder.Property(t => t.ItemBH)
                .HasColumnName("_Item_BH")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_PK_UpdateLog";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Jid = "JID";
            public const string UserName = "UserName";
            public const string CharID = "CharID";
            public const string CharName = "CharName";
            public const string PackageItemID = "PackageItemID";
            public const string SilkOwn = "Silk_Own";
            public const string SilkBefore = "Silk_Before";
            public const string SilkAfter = "Silk_After";
            public const string GoldRemain = "Gold_Remain";
            public const string GoldBefore = "Gold_Before";
            public const string GoldAfter = "Gold_After";
            public const string Ip = "IP";
            public const string RegDate = "RegDate";
            public const string Serial64 = "Serial64";
            public const string ShardID = "ShardID";
            public const string ServiceCode = "ServiceCode";
            public const string Strength = "_Strength";
            public const string Intellect = "_Intellect";
            public const string CurLevel = "_CurLevel";
            public const string Statpoint = "_Statpoint";
            public const string NewName = "_NewName";
            public const string OldPetName = "_OldPetName";
            public const string NewPetName = "_NewPetName";
            public const string NewStatPoint = "_NewStatPoint";
            public const string NewLevel = "_NewLevel";
            public const string NewStrength = "_NewStrength";
            public const string NewIntellect = "_NewIntellect";
            public const string SkillOwn = "_Skill_Own";
            public const string SkillBefore = "_Skill_Before";
            public const string SkillAfter = "_Skill_After";
            public const string ItemBH = "_Item_BH";
        }
        #endregion
    }
}
