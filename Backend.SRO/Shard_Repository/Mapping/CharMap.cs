using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.Char>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.Char> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Char", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Deleted)
                .IsRequired()
                .HasColumnName("Deleted")
                .HasColumnType("tinyint");

            builder.Property(t => t.RefObjID)
                .IsRequired()
                .HasColumnName("RefObjID")
                .HasColumnType("int");

            builder.Property(t => t.CharName16)
                .IsRequired()
                .HasColumnName("CharName16")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.NickName16)
                .IsRequired()
                .HasColumnName("NickName16")
                .HasColumnType("varchar(17)")
                .HasMaxLength(17)
                .HasDefaultValueSql("('')");

            builder.Property(t => t.Scale)
                .IsRequired()
                .HasColumnName("Scale")
                .HasColumnType("tinyint");

            builder.Property(t => t.CurLevel)
                .IsRequired()
                .HasColumnName("CurLevel")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.MaxLevel)
                .IsRequired()
                .HasColumnName("MaxLevel")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.ExpOffset)
                .IsRequired()
                .HasColumnName("ExpOffset")
                .HasColumnType("bigint");

            builder.Property(t => t.SExpOffset)
                .IsRequired()
                .HasColumnName("SExpOffset")
                .HasColumnType("int");

            builder.Property(t => t.Strength)
                .IsRequired()
                .HasColumnName("Strength")
                .HasColumnType("smallint");

            builder.Property(t => t.Intellect)
                .IsRequired()
                .HasColumnName("Intellect")
                .HasColumnType("smallint");

            builder.Property(t => t.RemainGold)
                .IsRequired()
                .HasColumnName("RemainGold")
                .HasColumnType("bigint");

            builder.Property(t => t.RemainSkillPoint)
                .IsRequired()
                .HasColumnName("RemainSkillPoint")
                .HasColumnType("int");

            builder.Property(t => t.RemainStatPoint)
                .IsRequired()
                .HasColumnName("RemainStatPoint")
                .HasColumnType("smallint");

            builder.Property(t => t.RemainHwanCount)
                .IsRequired()
                .HasColumnName("RemainHwanCount")
                .HasColumnType("tinyint");

            builder.Property(t => t.GatheredExpPoint)
                .IsRequired()
                .HasColumnName("GatheredExpPoint")
                .HasColumnType("int");

            builder.Property(t => t.Hp)
                .IsRequired()
                .HasColumnName("HP")
                .HasColumnType("int")
                .HasDefaultValueSql("((200))");

            builder.Property(t => t.Mp)
                .IsRequired()
                .HasColumnName("MP")
                .HasColumnType("int")
                .HasDefaultValueSql("((200))");

            builder.Property(t => t.LatestRegion)
                .IsRequired()
                .HasColumnName("LatestRegion")
                .HasColumnType("smallint");

            builder.Property(t => t.PosX)
                .IsRequired()
                .HasColumnName("PosX")
                .HasColumnType("real");

            builder.Property(t => t.PosY)
                .IsRequired()
                .HasColumnName("PosY")
                .HasColumnType("real");

            builder.Property(t => t.PosZ)
                .IsRequired()
                .HasColumnName("PosZ")
                .HasColumnType("real");

            builder.Property(t => t.AppointedTeleport)
                .IsRequired()
                .HasColumnName("AppointedTeleport")
                .HasColumnType("int");

            builder.Property(t => t.AutoInvestExp)
                .IsRequired()
                .HasColumnName("AutoInvestExp")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.InventorySize)
                .IsRequired()
                .HasColumnName("InventorySize")
                .HasColumnType("int");

            builder.Property(t => t.DailyPK)
                .IsRequired()
                .HasColumnName("DailyPK")
                .HasColumnType("tinyint");

            builder.Property(t => t.TotalPK)
                .IsRequired()
                .HasColumnName("TotalPK")
                .HasColumnType("smallint");

            builder.Property(t => t.PKPenaltyPoint)
                .IsRequired()
                .HasColumnName("PKPenaltyPoint")
                .HasColumnType("int");

            builder.Property(t => t.Tpp)
                .IsRequired()
                .HasColumnName("TPP")
                .HasColumnType("int");

            builder.Property(t => t.PenaltyForfeit)
                .IsRequired()
                .HasColumnName("PenaltyForfeit")
                .HasColumnType("int");

            builder.Property(t => t.JobPenaltyTime)
                .IsRequired()
                .HasColumnName("JobPenaltyTime")
                .HasColumnType("int");

            builder.Property(t => t.JobLvlTrader)
                .IsRequired()
                .HasColumnName("JobLvl_Trader")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.TraderExp)
                .IsRequired()
                .HasColumnName("Trader_Exp")
                .HasColumnType("int");

            builder.Property(t => t.JobLvlHunter)
                .IsRequired()
                .HasColumnName("JobLvl_Hunter")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.HunterExp)
                .IsRequired()
                .HasColumnName("Hunter_Exp")
                .HasColumnType("int");

            builder.Property(t => t.JobLvlRobber)
                .IsRequired()
                .HasColumnName("JobLvl_Robber")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.RobberExp)
                .IsRequired()
                .HasColumnName("Robber_Exp")
                .HasColumnType("int");

            builder.Property(t => t.GuildID)
                .HasColumnName("GuildID")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.LastLogout)
                .IsRequired()
                .HasColumnName("LastLogout")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.TelRegion)
                .IsRequired()
                .HasColumnName("TelRegion")
                .HasColumnType("smallint");

            builder.Property(t => t.TelPosX)
                .IsRequired()
                .HasColumnName("TelPosX")
                .HasColumnType("real");

            builder.Property(t => t.TelPosY)
                .IsRequired()
                .HasColumnName("TelPosY")
                .HasColumnType("real");

            builder.Property(t => t.TelPosZ)
                .IsRequired()
                .HasColumnName("TelPosZ")
                .HasColumnType("real");

            builder.Property(t => t.DiedRegion)
                .IsRequired()
                .HasColumnName("DiedRegion")
                .HasColumnType("smallint");

            builder.Property(t => t.DiedPosX)
                .IsRequired()
                .HasColumnName("DiedPosX")
                .HasColumnType("real");

            builder.Property(t => t.DiedPosY)
                .IsRequired()
                .HasColumnName("DiedPosY")
                .HasColumnType("real");

            builder.Property(t => t.DiedPosZ)
                .IsRequired()
                .HasColumnName("DiedPosZ")
                .HasColumnType("real");

            builder.Property(t => t.WorldID)
                .IsRequired()
                .HasColumnName("WorldID")
                .HasColumnType("smallint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.TelWorldID)
                .IsRequired()
                .HasColumnName("TelWorldID")
                .HasColumnType("smallint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.DiedWorldID)
                .IsRequired()
                .HasColumnName("DiedWorldID")
                .HasColumnType("smallint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.HwanLevel)
                .IsRequired()
                .HasColumnName("HwanLevel")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Char";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string Deleted = "Deleted";
            public const string RefObjID = "RefObjID";
            public const string CharName16 = "CharName16";
            public const string NickName16 = "NickName16";
            public const string Scale = "Scale";
            public const string CurLevel = "CurLevel";
            public const string MaxLevel = "MaxLevel";
            public const string ExpOffset = "ExpOffset";
            public const string SExpOffset = "SExpOffset";
            public const string Strength = "Strength";
            public const string Intellect = "Intellect";
            public const string RemainGold = "RemainGold";
            public const string RemainSkillPoint = "RemainSkillPoint";
            public const string RemainStatPoint = "RemainStatPoint";
            public const string RemainHwanCount = "RemainHwanCount";
            public const string GatheredExpPoint = "GatheredExpPoint";
            public const string Hp = "HP";
            public const string Mp = "MP";
            public const string LatestRegion = "LatestRegion";
            public const string PosX = "PosX";
            public const string PosY = "PosY";
            public const string PosZ = "PosZ";
            public const string AppointedTeleport = "AppointedTeleport";
            public const string AutoInvestExp = "AutoInvestExp";
            public const string InventorySize = "InventorySize";
            public const string DailyPK = "DailyPK";
            public const string TotalPK = "TotalPK";
            public const string PKPenaltyPoint = "PKPenaltyPoint";
            public const string Tpp = "TPP";
            public const string PenaltyForfeit = "PenaltyForfeit";
            public const string JobPenaltyTime = "JobPenaltyTime";
            public const string JobLvlTrader = "JobLvl_Trader";
            public const string TraderExp = "Trader_Exp";
            public const string JobLvlHunter = "JobLvl_Hunter";
            public const string HunterExp = "Hunter_Exp";
            public const string JobLvlRobber = "JobLvl_Robber";
            public const string RobberExp = "Robber_Exp";
            public const string GuildID = "GuildID";
            public const string LastLogout = "LastLogout";
            public const string TelRegion = "TelRegion";
            public const string TelPosX = "TelPosX";
            public const string TelPosY = "TelPosY";
            public const string TelPosZ = "TelPosZ";
            public const string DiedRegion = "DiedRegion";
            public const string DiedPosX = "DiedPosX";
            public const string DiedPosY = "DiedPosY";
            public const string DiedPosZ = "DiedPosZ";
            public const string WorldID = "WorldID";
            public const string TelWorldID = "TelWorldID";
            public const string DiedWorldID = "DiedWorldID";
            public const string HwanLevel = "HwanLevel";
        }
        #endregion
    }
}
