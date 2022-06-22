using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefObjItemMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefObjItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefObjItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefObjItem", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MaxStack)
                .IsRequired()
                .HasColumnName("MaxStack")
                .HasColumnType("int");

            builder.Property(t => t.ReqGender)
                .IsRequired()
                .HasColumnName("ReqGender")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqStr)
                .IsRequired()
                .HasColumnName("ReqStr")
                .HasColumnType("int");

            builder.Property(t => t.ReqInt)
                .IsRequired()
                .HasColumnName("ReqInt")
                .HasColumnType("int");

            builder.Property(t => t.ItemClass)
                .IsRequired()
                .HasColumnName("ItemClass")
                .HasColumnType("tinyint");

            builder.Property(t => t.SetID)
                .IsRequired()
                .HasColumnName("SetID")
                .HasColumnType("int");

            builder.Property(t => t.DurL)
                .IsRequired()
                .HasColumnName("Dur_L")
                .HasColumnType("real");

            builder.Property(t => t.DurU)
                .IsRequired()
                .HasColumnName("Dur_U")
                .HasColumnType("real");

            builder.Property(t => t.PdL)
                .IsRequired()
                .HasColumnName("PD_L")
                .HasColumnType("real");

            builder.Property(t => t.PdU)
                .IsRequired()
                .HasColumnName("PD_U")
                .HasColumnType("real");

            builder.Property(t => t.PDInc)
                .IsRequired()
                .HasColumnName("PDInc")
                .HasColumnType("real");

            builder.Property(t => t.ErL)
                .IsRequired()
                .HasColumnName("ER_L")
                .HasColumnType("real");

            builder.Property(t => t.ErU)
                .IsRequired()
                .HasColumnName("ER_U")
                .HasColumnType("real");

            builder.Property(t => t.ERInc)
                .IsRequired()
                .HasColumnName("ERInc")
                .HasColumnType("real");

            builder.Property(t => t.ParL)
                .IsRequired()
                .HasColumnName("PAR_L")
                .HasColumnType("real");

            builder.Property(t => t.ParU)
                .IsRequired()
                .HasColumnName("PAR_U")
                .HasColumnType("real");

            builder.Property(t => t.PARInc)
                .IsRequired()
                .HasColumnName("PARInc")
                .HasColumnType("real");

            builder.Property(t => t.BrL)
                .IsRequired()
                .HasColumnName("BR_L")
                .HasColumnType("real");

            builder.Property(t => t.BrU)
                .IsRequired()
                .HasColumnName("BR_U")
                .HasColumnType("real");

            builder.Property(t => t.MdL)
                .IsRequired()
                .HasColumnName("MD_L")
                .HasColumnType("real");

            builder.Property(t => t.MdU)
                .IsRequired()
                .HasColumnName("MD_U")
                .HasColumnType("real");

            builder.Property(t => t.MDInc)
                .IsRequired()
                .HasColumnName("MDInc")
                .HasColumnType("real");

            builder.Property(t => t.MarL)
                .IsRequired()
                .HasColumnName("MAR_L")
                .HasColumnType("real");

            builder.Property(t => t.MarU)
                .IsRequired()
                .HasColumnName("MAR_U")
                .HasColumnType("real");

            builder.Property(t => t.MARInc)
                .IsRequired()
                .HasColumnName("MARInc")
                .HasColumnType("real");

            builder.Property(t => t.PDStrL)
                .IsRequired()
                .HasColumnName("PDStr_L")
                .HasColumnType("real");

            builder.Property(t => t.PDStrU)
                .IsRequired()
                .HasColumnName("PDStr_U")
                .HasColumnType("real");

            builder.Property(t => t.MDIntL)
                .IsRequired()
                .HasColumnName("MDInt_L")
                .HasColumnType("real");

            builder.Property(t => t.MDIntU)
                .IsRequired()
                .HasColumnName("MDInt_U")
                .HasColumnType("real");

            builder.Property(t => t.Quivered)
                .IsRequired()
                .HasColumnName("Quivered")
                .HasColumnType("tinyint");

            builder.Property(t => t.Ammo1TID4)
                .IsRequired()
                .HasColumnName("Ammo1_TID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.Ammo2TID4)
                .IsRequired()
                .HasColumnName("Ammo2_TID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.Ammo3TID4)
                .IsRequired()
                .HasColumnName("Ammo3_TID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.Ammo4TID4)
                .IsRequired()
                .HasColumnName("Ammo4_TID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.Ammo5TID4)
                .IsRequired()
                .HasColumnName("Ammo5_TID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.SpeedClass)
                .IsRequired()
                .HasColumnName("SpeedClass")
                .HasColumnType("tinyint");

            builder.Property(t => t.TwoHanded)
                .IsRequired()
                .HasColumnName("TwoHanded")
                .HasColumnType("tinyint");

            builder.Property(t => t.Range)
                .IsRequired()
                .HasColumnName("Range")
                .HasColumnType("smallint");

            builder.Property(t => t.PAttackMinL)
                .IsRequired()
                .HasColumnName("PAttackMin_L")
                .HasColumnType("real");

            builder.Property(t => t.PAttackMinU)
                .IsRequired()
                .HasColumnName("PAttackMin_U")
                .HasColumnType("real");

            builder.Property(t => t.PAttackMaxL)
                .IsRequired()
                .HasColumnName("PAttackMax_L")
                .HasColumnType("real");

            builder.Property(t => t.PAttackMaxU)
                .IsRequired()
                .HasColumnName("PAttackMax_U")
                .HasColumnType("real");

            builder.Property(t => t.PAttackInc)
                .IsRequired()
                .HasColumnName("PAttackInc")
                .HasColumnType("real");

            builder.Property(t => t.MAttackMinL)
                .IsRequired()
                .HasColumnName("MAttackMin_L")
                .HasColumnType("real");

            builder.Property(t => t.MAttackMinU)
                .IsRequired()
                .HasColumnName("MAttackMin_U")
                .HasColumnType("real");

            builder.Property(t => t.MAttackMaxL)
                .IsRequired()
                .HasColumnName("MAttackMax_L")
                .HasColumnType("real");

            builder.Property(t => t.MAttackMaxU)
                .IsRequired()
                .HasColumnName("MAttackMax_U")
                .HasColumnType("real");

            builder.Property(t => t.MAttackInc)
                .IsRequired()
                .HasColumnName("MAttackInc")
                .HasColumnType("real");

            builder.Property(t => t.PAStrMinL)
                .IsRequired()
                .HasColumnName("PAStrMin_L")
                .HasColumnType("real");

            builder.Property(t => t.PAStrMinU)
                .IsRequired()
                .HasColumnName("PAStrMin_U")
                .HasColumnType("real");

            builder.Property(t => t.PAStrMaxL)
                .IsRequired()
                .HasColumnName("PAStrMax_L")
                .HasColumnType("real");

            builder.Property(t => t.PAStrMaxU)
                .IsRequired()
                .HasColumnName("PAStrMax_U")
                .HasColumnType("real");

            builder.Property(t => t.MAIntMinL)
                .IsRequired()
                .HasColumnName("MAInt_Min_L")
                .HasColumnType("real");

            builder.Property(t => t.MAIntMinU)
                .IsRequired()
                .HasColumnName("MAInt_Min_U")
                .HasColumnType("real");

            builder.Property(t => t.MAIntMaxL)
                .IsRequired()
                .HasColumnName("MAInt_Max_L")
                .HasColumnType("real");

            builder.Property(t => t.MAIntMaxU)
                .IsRequired()
                .HasColumnName("MAInt_Max_U")
                .HasColumnType("real");

            builder.Property(t => t.HrL)
                .IsRequired()
                .HasColumnName("HR_L")
                .HasColumnType("real");

            builder.Property(t => t.HrU)
                .IsRequired()
                .HasColumnName("HR_U")
                .HasColumnType("real");

            builder.Property(t => t.HRInc)
                .IsRequired()
                .HasColumnName("HRInc")
                .HasColumnType("real");

            builder.Property(t => t.ChrL)
                .IsRequired()
                .HasColumnName("CHR_L")
                .HasColumnType("real");

            builder.Property(t => t.ChrU)
                .IsRequired()
                .HasColumnName("CHR_U")
                .HasColumnType("real");

            builder.Property(t => t.Param1)
                .IsRequired()
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Desc1128)
                .IsRequired()
                .HasColumnName("Desc1_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param2)
                .IsRequired()
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Desc2128)
                .IsRequired()
                .HasColumnName("Desc2_128")
                .HasColumnType("char(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param3)
                .IsRequired()
                .HasColumnName("Param3")
                .HasColumnType("int");

            builder.Property(t => t.Desc3128)
                .IsRequired()
                .HasColumnName("Desc3_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param4)
                .IsRequired()
                .HasColumnName("Param4")
                .HasColumnType("int");

            builder.Property(t => t.Desc4128)
                .IsRequired()
                .HasColumnName("Desc4_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param5)
                .IsRequired()
                .HasColumnName("Param5")
                .HasColumnType("int");

            builder.Property(t => t.Desc5128)
                .IsRequired()
                .HasColumnName("Desc5_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param6)
                .IsRequired()
                .HasColumnName("Param6")
                .HasColumnType("int");

            builder.Property(t => t.Desc6128)
                .IsRequired()
                .HasColumnName("Desc6_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param7)
                .IsRequired()
                .HasColumnName("Param7")
                .HasColumnType("int");

            builder.Property(t => t.Desc7128)
                .IsRequired()
                .HasColumnName("Desc7_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param8)
                .IsRequired()
                .HasColumnName("Param8")
                .HasColumnType("int");

            builder.Property(t => t.Desc8128)
                .IsRequired()
                .HasColumnName("Desc8_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param9)
                .IsRequired()
                .HasColumnName("Param9")
                .HasColumnType("int");

            builder.Property(t => t.Desc9128)
                .IsRequired()
                .HasColumnName("Desc9_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param10)
                .IsRequired()
                .HasColumnName("Param10")
                .HasColumnType("int");

            builder.Property(t => t.Desc10128)
                .IsRequired()
                .HasColumnName("Desc10_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param11)
                .IsRequired()
                .HasColumnName("Param11")
                .HasColumnType("int");

            builder.Property(t => t.Desc11128)
                .IsRequired()
                .HasColumnName("Desc11_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param12)
                .IsRequired()
                .HasColumnName("Param12")
                .HasColumnType("int");

            builder.Property(t => t.Desc12128)
                .IsRequired()
                .HasColumnName("Desc12_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param13)
                .IsRequired()
                .HasColumnName("Param13")
                .HasColumnType("int");

            builder.Property(t => t.Desc13128)
                .IsRequired()
                .HasColumnName("Desc13_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param14)
                .IsRequired()
                .HasColumnName("Param14")
                .HasColumnType("int");

            builder.Property(t => t.Desc14128)
                .IsRequired()
                .HasColumnName("Desc14_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param15)
                .IsRequired()
                .HasColumnName("Param15")
                .HasColumnType("int");

            builder.Property(t => t.Desc15128)
                .IsRequired()
                .HasColumnName("Desc15_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param16)
                .IsRequired()
                .HasColumnName("Param16")
                .HasColumnType("int");

            builder.Property(t => t.Desc16128)
                .IsRequired()
                .HasColumnName("Desc16_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param17)
                .IsRequired()
                .HasColumnName("Param17")
                .HasColumnType("int");

            builder.Property(t => t.Desc17128)
                .IsRequired()
                .HasColumnName("Desc17_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param18)
                .IsRequired()
                .HasColumnName("Param18")
                .HasColumnType("int");

            builder.Property(t => t.Desc18128)
                .IsRequired()
                .HasColumnName("Desc18_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param19)
                .IsRequired()
                .HasColumnName("Param19")
                .HasColumnType("int");

            builder.Property(t => t.Desc19128)
                .IsRequired()
                .HasColumnName("Desc19_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param20)
                .IsRequired()
                .HasColumnName("Param20")
                .HasColumnType("int");

            builder.Property(t => t.Desc20128)
                .IsRequired()
                .HasColumnName("Desc20_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.MaxMagicOptCount)
                .IsRequired()
                .HasColumnName("MaxMagicOptCount")
                .HasColumnType("tinyint");

            builder.Property(t => t.ChildItemCount)
                .IsRequired()
                .HasColumnName("ChildItemCount")
                .HasColumnType("tinyint");

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
            public const string Name = "_RefObjItem";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string MaxStack = "MaxStack";
            public const string ReqGender = "ReqGender";
            public const string ReqStr = "ReqStr";
            public const string ReqInt = "ReqInt";
            public const string ItemClass = "ItemClass";
            public const string SetID = "SetID";
            public const string DurL = "Dur_L";
            public const string DurU = "Dur_U";
            public const string PdL = "PD_L";
            public const string PdU = "PD_U";
            public const string PDInc = "PDInc";
            public const string ErL = "ER_L";
            public const string ErU = "ER_U";
            public const string ERInc = "ERInc";
            public const string ParL = "PAR_L";
            public const string ParU = "PAR_U";
            public const string PARInc = "PARInc";
            public const string BrL = "BR_L";
            public const string BrU = "BR_U";
            public const string MdL = "MD_L";
            public const string MdU = "MD_U";
            public const string MDInc = "MDInc";
            public const string MarL = "MAR_L";
            public const string MarU = "MAR_U";
            public const string MARInc = "MARInc";
            public const string PDStrL = "PDStr_L";
            public const string PDStrU = "PDStr_U";
            public const string MDIntL = "MDInt_L";
            public const string MDIntU = "MDInt_U";
            public const string Quivered = "Quivered";
            public const string Ammo1TID4 = "Ammo1_TID4";
            public const string Ammo2TID4 = "Ammo2_TID4";
            public const string Ammo3TID4 = "Ammo3_TID4";
            public const string Ammo4TID4 = "Ammo4_TID4";
            public const string Ammo5TID4 = "Ammo5_TID4";
            public const string SpeedClass = "SpeedClass";
            public const string TwoHanded = "TwoHanded";
            public const string Range = "Range";
            public const string PAttackMinL = "PAttackMin_L";
            public const string PAttackMinU = "PAttackMin_U";
            public const string PAttackMaxL = "PAttackMax_L";
            public const string PAttackMaxU = "PAttackMax_U";
            public const string PAttackInc = "PAttackInc";
            public const string MAttackMinL = "MAttackMin_L";
            public const string MAttackMinU = "MAttackMin_U";
            public const string MAttackMaxL = "MAttackMax_L";
            public const string MAttackMaxU = "MAttackMax_U";
            public const string MAttackInc = "MAttackInc";
            public const string PAStrMinL = "PAStrMin_L";
            public const string PAStrMinU = "PAStrMin_U";
            public const string PAStrMaxL = "PAStrMax_L";
            public const string PAStrMaxU = "PAStrMax_U";
            public const string MAIntMinL = "MAInt_Min_L";
            public const string MAIntMinU = "MAInt_Min_U";
            public const string MAIntMaxL = "MAInt_Max_L";
            public const string MAIntMaxU = "MAInt_Max_U";
            public const string HrL = "HR_L";
            public const string HrU = "HR_U";
            public const string HRInc = "HRInc";
            public const string ChrL = "CHR_L";
            public const string ChrU = "CHR_U";
            public const string Param1 = "Param1";
            public const string Desc1128 = "Desc1_128";
            public const string Param2 = "Param2";
            public const string Desc2128 = "Desc2_128";
            public const string Param3 = "Param3";
            public const string Desc3128 = "Desc3_128";
            public const string Param4 = "Param4";
            public const string Desc4128 = "Desc4_128";
            public const string Param5 = "Param5";
            public const string Desc5128 = "Desc5_128";
            public const string Param6 = "Param6";
            public const string Desc6128 = "Desc6_128";
            public const string Param7 = "Param7";
            public const string Desc7128 = "Desc7_128";
            public const string Param8 = "Param8";
            public const string Desc8128 = "Desc8_128";
            public const string Param9 = "Param9";
            public const string Desc9128 = "Desc9_128";
            public const string Param10 = "Param10";
            public const string Desc10128 = "Desc10_128";
            public const string Param11 = "Param11";
            public const string Desc11128 = "Desc11_128";
            public const string Param12 = "Param12";
            public const string Desc12128 = "Desc12_128";
            public const string Param13 = "Param13";
            public const string Desc13128 = "Desc13_128";
            public const string Param14 = "Param14";
            public const string Desc14128 = "Desc14_128";
            public const string Param15 = "Param15";
            public const string Desc15128 = "Desc15_128";
            public const string Param16 = "Param16";
            public const string Desc16128 = "Desc16_128";
            public const string Param17 = "Param17";
            public const string Desc17128 = "Desc17_128";
            public const string Param18 = "Param18";
            public const string Desc18128 = "Desc18_128";
            public const string Param19 = "Param19";
            public const string Desc19128 = "Desc19_128";
            public const string Param20 = "Param20";
            public const string Desc20128 = "Desc20_128";
            public const string MaxMagicOptCount = "MaxMagicOptCount";
            public const string ChildItemCount = "ChildItemCount";
            public const string Link = "Link";
        }
        #endregion
    }
}
