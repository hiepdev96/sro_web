using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefObjCommonMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefObjCommon>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefObjCommon> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefObjCommon", "dbo");

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
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ObjName128)
                .IsRequired()
                .HasColumnName("ObjName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OrgObjCodeName128)
                .IsRequired()
                .HasColumnName("OrgObjCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.NameStrID128)
                .IsRequired()
                .HasColumnName("NameStrID128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.DescStrID128)
                .IsRequired()
                .HasColumnName("DescStrID128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.CashItem)
                .IsRequired()
                .HasColumnName("CashItem")
                .HasColumnType("tinyint");

            builder.Property(t => t.Bionic)
                .IsRequired()
                .HasColumnName("Bionic")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID1)
                .IsRequired()
                .HasColumnName("TypeID1")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID2)
                .IsRequired()
                .HasColumnName("TypeID2")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID3)
                .IsRequired()
                .HasColumnName("TypeID3")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID4)
                .IsRequired()
                .HasColumnName("TypeID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.DecayTime)
                .IsRequired()
                .HasColumnName("DecayTime")
                .HasColumnType("int");

            builder.Property(t => t.Country)
                .IsRequired()
                .HasColumnName("Country")
                .HasColumnType("tinyint");

            builder.Property(t => t.Rarity)
                .IsRequired()
                .HasColumnName("Rarity")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanTrade)
                .IsRequired()
                .HasColumnName("CanTrade")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanSell)
                .IsRequired()
                .HasColumnName("CanSell")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanBuy)
                .IsRequired()
                .HasColumnName("CanBuy")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanBorrow)
                .IsRequired()
                .HasColumnName("CanBorrow")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanDrop)
                .IsRequired()
                .HasColumnName("CanDrop")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanPick)
                .IsRequired()
                .HasColumnName("CanPick")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanRepair)
                .IsRequired()
                .HasColumnName("CanRepair")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanRevive)
                .IsRequired()
                .HasColumnName("CanRevive")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanUse)
                .IsRequired()
                .HasColumnName("CanUse")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanThrow)
                .IsRequired()
                .HasColumnName("CanThrow")
                .HasColumnType("tinyint");

            builder.Property(t => t.Price)
                .IsRequired()
                .HasColumnName("Price")
                .HasColumnType("int");

            builder.Property(t => t.CostRepair)
                .IsRequired()
                .HasColumnName("CostRepair")
                .HasColumnType("int");

            builder.Property(t => t.CostRevive)
                .IsRequired()
                .HasColumnName("CostRevive")
                .HasColumnType("int");

            builder.Property(t => t.CostBorrow)
                .IsRequired()
                .HasColumnName("CostBorrow")
                .HasColumnType("int");

            builder.Property(t => t.KeepingFee)
                .IsRequired()
                .HasColumnName("KeepingFee")
                .HasColumnType("int");

            builder.Property(t => t.SellPrice)
                .IsRequired()
                .HasColumnName("SellPrice")
                .HasColumnType("int");

            builder.Property(t => t.ReqLevelType1)
                .IsRequired()
                .HasColumnName("ReqLevelType1")
                .HasColumnType("int");

            builder.Property(t => t.ReqLevel1)
                .IsRequired()
                .HasColumnName("ReqLevel1")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqLevelType2)
                .IsRequired()
                .HasColumnName("ReqLevelType2")
                .HasColumnType("int");

            builder.Property(t => t.ReqLevel2)
                .IsRequired()
                .HasColumnName("ReqLevel2")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqLevelType3)
                .IsRequired()
                .HasColumnName("ReqLevelType3")
                .HasColumnType("int");

            builder.Property(t => t.ReqLevel3)
                .IsRequired()
                .HasColumnName("ReqLevel3")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqLevelType4)
                .IsRequired()
                .HasColumnName("ReqLevelType4")
                .HasColumnType("int");

            builder.Property(t => t.ReqLevel4)
                .IsRequired()
                .HasColumnName("ReqLevel4")
                .HasColumnType("tinyint");

            builder.Property(t => t.MaxContain)
                .IsRequired()
                .HasColumnName("MaxContain")
                .HasColumnType("int");

            builder.Property(t => t.RegionID)
                .IsRequired()
                .HasColumnName("RegionID")
                .HasColumnType("smallint");

            builder.Property(t => t.Dir)
                .IsRequired()
                .HasColumnName("Dir")
                .HasColumnType("smallint");

            builder.Property(t => t.OffsetX)
                .IsRequired()
                .HasColumnName("OffsetX")
                .HasColumnType("smallint");

            builder.Property(t => t.OffsetY)
                .IsRequired()
                .HasColumnName("OffsetY")
                .HasColumnType("smallint");

            builder.Property(t => t.OffsetZ)
                .IsRequired()
                .HasColumnName("OffsetZ")
                .HasColumnType("smallint");

            builder.Property(t => t.Speed1)
                .IsRequired()
                .HasColumnName("Speed1")
                .HasColumnType("smallint");

            builder.Property(t => t.Speed2)
                .IsRequired()
                .HasColumnName("Speed2")
                .HasColumnType("smallint");

            builder.Property(t => t.Scale)
                .IsRequired()
                .HasColumnName("Scale")
                .HasColumnType("int");

            builder.Property(t => t.BCHeight)
                .IsRequired()
                .HasColumnName("BCHeight")
                .HasColumnType("smallint");

            builder.Property(t => t.BCRadius)
                .IsRequired()
                .HasColumnName("BCRadius")
                .HasColumnType("smallint");

            builder.Property(t => t.EventID)
                .IsRequired()
                .HasColumnName("EventID")
                .HasColumnType("int");

            builder.Property(t => t.AssocFileObj128)
                .IsRequired()
                .HasColumnName("AssocFileObj128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AssocFileDrop128)
                .IsRequired()
                .HasColumnName("AssocFileDrop128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AssocFileIcon128)
                .IsRequired()
                .HasColumnName("AssocFileIcon128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AssocFile1128)
                .IsRequired()
                .HasColumnName("AssocFile1_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AssocFile2128)
                .IsRequired()
                .HasColumnName("AssocFile2_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Link)
                .IsRequired()
                .HasColumnName("Link")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefObjCommon";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string ObjName128 = "ObjName128";
            public const string OrgObjCodeName128 = "OrgObjCodeName128";
            public const string NameStrID128 = "NameStrID128";
            public const string DescStrID128 = "DescStrID128";
            public const string CashItem = "CashItem";
            public const string Bionic = "Bionic";
            public const string TypeID1 = "TypeID1";
            public const string TypeID2 = "TypeID2";
            public const string TypeID3 = "TypeID3";
            public const string TypeID4 = "TypeID4";
            public const string DecayTime = "DecayTime";
            public const string Country = "Country";
            public const string Rarity = "Rarity";
            public const string CanTrade = "CanTrade";
            public const string CanSell = "CanSell";
            public const string CanBuy = "CanBuy";
            public const string CanBorrow = "CanBorrow";
            public const string CanDrop = "CanDrop";
            public const string CanPick = "CanPick";
            public const string CanRepair = "CanRepair";
            public const string CanRevive = "CanRevive";
            public const string CanUse = "CanUse";
            public const string CanThrow = "CanThrow";
            public const string Price = "Price";
            public const string CostRepair = "CostRepair";
            public const string CostRevive = "CostRevive";
            public const string CostBorrow = "CostBorrow";
            public const string KeepingFee = "KeepingFee";
            public const string SellPrice = "SellPrice";
            public const string ReqLevelType1 = "ReqLevelType1";
            public const string ReqLevel1 = "ReqLevel1";
            public const string ReqLevelType2 = "ReqLevelType2";
            public const string ReqLevel2 = "ReqLevel2";
            public const string ReqLevelType3 = "ReqLevelType3";
            public const string ReqLevel3 = "ReqLevel3";
            public const string ReqLevelType4 = "ReqLevelType4";
            public const string ReqLevel4 = "ReqLevel4";
            public const string MaxContain = "MaxContain";
            public const string RegionID = "RegionID";
            public const string Dir = "Dir";
            public const string OffsetX = "OffsetX";
            public const string OffsetY = "OffsetY";
            public const string OffsetZ = "OffsetZ";
            public const string Speed1 = "Speed1";
            public const string Speed2 = "Speed2";
            public const string Scale = "Scale";
            public const string BCHeight = "BCHeight";
            public const string BCRadius = "BCRadius";
            public const string EventID = "EventID";
            public const string AssocFileObj128 = "AssocFileObj128";
            public const string AssocFileDrop128 = "AssocFileDrop128";
            public const string AssocFileIcon128 = "AssocFileIcon128";
            public const string AssocFile1128 = "AssocFile1_128";
            public const string AssocFile2128 = "AssocFile2_128";
            public const string Link = "Link";
        }
        #endregion
    }
}
