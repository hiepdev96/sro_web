using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefObjCharMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefObjChar>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefObjChar> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefObjChar", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Lvl)
                .IsRequired()
                .HasColumnName("Lvl")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharGender)
                .IsRequired()
                .HasColumnName("CharGender")
                .HasColumnType("tinyint");

            builder.Property(t => t.MaxHP)
                .IsRequired()
                .HasColumnName("MaxHP")
                .HasColumnType("int");

            builder.Property(t => t.MaxMP)
                .IsRequired()
                .HasColumnName("MaxMP")
                .HasColumnType("int");

            builder.Property(t => t.ResistFrozen)
                .IsRequired()
                .HasColumnName("ResistFrozen")
                .HasColumnType("int");

            builder.Property(t => t.ResistFrostbite)
                .IsRequired()
                .HasColumnName("ResistFrostbite")
                .HasColumnType("int");

            builder.Property(t => t.ResistBurn)
                .IsRequired()
                .HasColumnName("ResistBurn")
                .HasColumnType("int");

            builder.Property(t => t.ResistEShock)
                .IsRequired()
                .HasColumnName("ResistEShock")
                .HasColumnType("int");

            builder.Property(t => t.ResistPoison)
                .IsRequired()
                .HasColumnName("ResistPoison")
                .HasColumnType("int");

            builder.Property(t => t.ResistZombie)
                .IsRequired()
                .HasColumnName("ResistZombie")
                .HasColumnType("int");

            builder.Property(t => t.ResistSleep)
                .IsRequired()
                .HasColumnName("ResistSleep")
                .HasColumnType("int");

            builder.Property(t => t.ResistRoot)
                .IsRequired()
                .HasColumnName("ResistRoot")
                .HasColumnType("int");

            builder.Property(t => t.ResistSlow)
                .IsRequired()
                .HasColumnName("ResistSlow")
                .HasColumnType("int");

            builder.Property(t => t.ResistFear)
                .IsRequired()
                .HasColumnName("ResistFear")
                .HasColumnType("int");

            builder.Property(t => t.ResistMyopia)
                .IsRequired()
                .HasColumnName("ResistMyopia")
                .HasColumnType("int");

            builder.Property(t => t.ResistBlood)
                .IsRequired()
                .HasColumnName("ResistBlood")
                .HasColumnType("int");

            builder.Property(t => t.ResistStone)
                .IsRequired()
                .HasColumnName("ResistStone")
                .HasColumnType("int");

            builder.Property(t => t.ResistDark)
                .IsRequired()
                .HasColumnName("ResistDark")
                .HasColumnType("int");

            builder.Property(t => t.ResistStun)
                .IsRequired()
                .HasColumnName("ResistStun")
                .HasColumnType("int");

            builder.Property(t => t.ResistDisea)
                .IsRequired()
                .HasColumnName("ResistDisea")
                .HasColumnType("int");

            builder.Property(t => t.ResistChaos)
                .IsRequired()
                .HasColumnName("ResistChaos")
                .HasColumnType("int");

            builder.Property(t => t.ResistCsePD)
                .IsRequired()
                .HasColumnName("ResistCsePD")
                .HasColumnType("int");

            builder.Property(t => t.ResistCseMD)
                .IsRequired()
                .HasColumnName("ResistCseMD")
                .HasColumnType("int");

            builder.Property(t => t.ResistCseSTR)
                .IsRequired()
                .HasColumnName("ResistCseSTR")
                .HasColumnType("int");

            builder.Property(t => t.ResistCseINT)
                .IsRequired()
                .HasColumnName("ResistCseINT")
                .HasColumnType("int");

            builder.Property(t => t.ResistCseHP)
                .IsRequired()
                .HasColumnName("ResistCseHP")
                .HasColumnType("int");

            builder.Property(t => t.ResistCseMP)
                .IsRequired()
                .HasColumnName("ResistCseMP")
                .HasColumnType("int");

            builder.Property(t => t.Resist24)
                .IsRequired()
                .HasColumnName("Resist24")
                .HasColumnType("int");

            builder.Property(t => t.ResistBomb)
                .IsRequired()
                .HasColumnName("ResistBomb")
                .HasColumnType("int");

            builder.Property(t => t.Resist26)
                .IsRequired()
                .HasColumnName("Resist26")
                .HasColumnType("int");

            builder.Property(t => t.Resist27)
                .IsRequired()
                .HasColumnName("Resist27")
                .HasColumnType("int");

            builder.Property(t => t.Resist28)
                .IsRequired()
                .HasColumnName("Resist28")
                .HasColumnType("int");

            builder.Property(t => t.Resist29)
                .IsRequired()
                .HasColumnName("Resist29")
                .HasColumnType("int");

            builder.Property(t => t.Resist30)
                .IsRequired()
                .HasColumnName("Resist30")
                .HasColumnType("int");

            builder.Property(t => t.Resist31)
                .IsRequired()
                .HasColumnName("Resist31")
                .HasColumnType("int");

            builder.Property(t => t.Resist32)
                .IsRequired()
                .HasColumnName("Resist32")
                .HasColumnType("int");

            builder.Property(t => t.InventorySize)
                .IsRequired()
                .HasColumnName("InventorySize")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanStoreTID1)
                .IsRequired()
                .HasColumnName("CanStore_TID1")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanStoreTID2)
                .IsRequired()
                .HasColumnName("CanStore_TID2")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanStoreTID3)
                .IsRequired()
                .HasColumnName("CanStore_TID3")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanStoreTID4)
                .IsRequired()
                .HasColumnName("CanStore_TID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanBeVehicle)
                .IsRequired()
                .HasColumnName("CanBeVehicle")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanControl)
                .IsRequired()
                .HasColumnName("CanControl")
                .HasColumnType("tinyint");

            builder.Property(t => t.DamagePortion)
                .IsRequired()
                .HasColumnName("DamagePortion")
                .HasColumnType("tinyint");

            builder.Property(t => t.MaxPassenger)
                .IsRequired()
                .HasColumnName("MaxPassenger")
                .HasColumnType("smallint");

            builder.Property(t => t.AssocTactics)
                .IsRequired()
                .HasColumnName("AssocTactics")
                .HasColumnType("int");

            builder.Property(t => t.Pd)
                .IsRequired()
                .HasColumnName("PD")
                .HasColumnType("int");

            builder.Property(t => t.Md)
                .IsRequired()
                .HasColumnName("MD")
                .HasColumnType("int");

            builder.Property(t => t.Par)
                .IsRequired()
                .HasColumnName("PAR")
                .HasColumnType("int");

            builder.Property(t => t.Mar)
                .IsRequired()
                .HasColumnName("MAR")
                .HasColumnType("int");

            builder.Property(t => t.Er)
                .IsRequired()
                .HasColumnName("ER")
                .HasColumnType("int");

            builder.Property(t => t.Br)
                .IsRequired()
                .HasColumnName("BR")
                .HasColumnType("int");

            builder.Property(t => t.Hr)
                .IsRequired()
                .HasColumnName("HR")
                .HasColumnType("int");

            builder.Property(t => t.Chr)
                .IsRequired()
                .HasColumnName("CHR")
                .HasColumnType("int");

            builder.Property(t => t.ExpToGive)
                .IsRequired()
                .HasColumnName("ExpToGive")
                .HasColumnType("int");

            builder.Property(t => t.CreepType)
                .IsRequired()
                .HasColumnName("CreepType")
                .HasColumnType("int");

            builder.Property(t => t.Knockdown)
                .IsRequired()
                .HasColumnName("Knockdown")
                .HasColumnType("tinyint");

            builder.Property(t => t.KORecoverTime)
                .IsRequired()
                .HasColumnName("KO_RecoverTime")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill1)
                .HasColumnName("DefaultSkill_1")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill2)
                .HasColumnName("DefaultSkill_2")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill3)
                .HasColumnName("DefaultSkill_3")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill4)
                .HasColumnName("DefaultSkill_4")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill5)
                .HasColumnName("DefaultSkill_5")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill6)
                .HasColumnName("DefaultSkill_6")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill7)
                .HasColumnName("DefaultSkill_7")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill8)
                .HasColumnName("DefaultSkill_8")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill9)
                .HasColumnName("DefaultSkill_9")
                .HasColumnType("int");

            builder.Property(t => t.DefaultSkill10)
                .HasColumnName("DefaultSkill_10")
                .HasColumnType("int");

            builder.Property(t => t.TextureType)
                .HasColumnName("TextureType")
                .HasColumnType("tinyint");

            builder.Property(t => t.Except1)
                .HasColumnName("Except_1")
                .HasColumnType("int");

            builder.Property(t => t.Except2)
                .HasColumnName("Except_2")
                .HasColumnType("int");

            builder.Property(t => t.Except3)
                .HasColumnName("Except_3")
                .HasColumnType("int");

            builder.Property(t => t.Except4)
                .HasColumnName("Except_4")
                .HasColumnType("int");

            builder.Property(t => t.Except5)
                .HasColumnName("Except_5")
                .HasColumnType("int");

            builder.Property(t => t.Except6)
                .HasColumnName("Except_6")
                .HasColumnType("int");

            builder.Property(t => t.Except7)
                .HasColumnName("Except_7")
                .HasColumnType("int");

            builder.Property(t => t.Except8)
                .HasColumnName("Except_8")
                .HasColumnType("int");

            builder.Property(t => t.Except9)
                .HasColumnName("Except_9")
                .HasColumnType("int");

            builder.Property(t => t.Except10)
                .HasColumnName("Except_10")
                .HasColumnType("int");

            builder.Property(t => t.Link)
                .HasColumnName("Link")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefObjChar";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Lvl = "Lvl";
            public const string CharGender = "CharGender";
            public const string MaxHP = "MaxHP";
            public const string MaxMP = "MaxMP";
            public const string ResistFrozen = "ResistFrozen";
            public const string ResistFrostbite = "ResistFrostbite";
            public const string ResistBurn = "ResistBurn";
            public const string ResistEShock = "ResistEShock";
            public const string ResistPoison = "ResistPoison";
            public const string ResistZombie = "ResistZombie";
            public const string ResistSleep = "ResistSleep";
            public const string ResistRoot = "ResistRoot";
            public const string ResistSlow = "ResistSlow";
            public const string ResistFear = "ResistFear";
            public const string ResistMyopia = "ResistMyopia";
            public const string ResistBlood = "ResistBlood";
            public const string ResistStone = "ResistStone";
            public const string ResistDark = "ResistDark";
            public const string ResistStun = "ResistStun";
            public const string ResistDisea = "ResistDisea";
            public const string ResistChaos = "ResistChaos";
            public const string ResistCsePD = "ResistCsePD";
            public const string ResistCseMD = "ResistCseMD";
            public const string ResistCseSTR = "ResistCseSTR";
            public const string ResistCseINT = "ResistCseINT";
            public const string ResistCseHP = "ResistCseHP";
            public const string ResistCseMP = "ResistCseMP";
            public const string Resist24 = "Resist24";
            public const string ResistBomb = "ResistBomb";
            public const string Resist26 = "Resist26";
            public const string Resist27 = "Resist27";
            public const string Resist28 = "Resist28";
            public const string Resist29 = "Resist29";
            public const string Resist30 = "Resist30";
            public const string Resist31 = "Resist31";
            public const string Resist32 = "Resist32";
            public const string InventorySize = "InventorySize";
            public const string CanStoreTID1 = "CanStore_TID1";
            public const string CanStoreTID2 = "CanStore_TID2";
            public const string CanStoreTID3 = "CanStore_TID3";
            public const string CanStoreTID4 = "CanStore_TID4";
            public const string CanBeVehicle = "CanBeVehicle";
            public const string CanControl = "CanControl";
            public const string DamagePortion = "DamagePortion";
            public const string MaxPassenger = "MaxPassenger";
            public const string AssocTactics = "AssocTactics";
            public const string Pd = "PD";
            public const string Md = "MD";
            public const string Par = "PAR";
            public const string Mar = "MAR";
            public const string Er = "ER";
            public const string Br = "BR";
            public const string Hr = "HR";
            public const string Chr = "CHR";
            public const string ExpToGive = "ExpToGive";
            public const string CreepType = "CreepType";
            public const string Knockdown = "Knockdown";
            public const string KORecoverTime = "KO_RecoverTime";
            public const string DefaultSkill1 = "DefaultSkill_1";
            public const string DefaultSkill2 = "DefaultSkill_2";
            public const string DefaultSkill3 = "DefaultSkill_3";
            public const string DefaultSkill4 = "DefaultSkill_4";
            public const string DefaultSkill5 = "DefaultSkill_5";
            public const string DefaultSkill6 = "DefaultSkill_6";
            public const string DefaultSkill7 = "DefaultSkill_7";
            public const string DefaultSkill8 = "DefaultSkill_8";
            public const string DefaultSkill9 = "DefaultSkill_9";
            public const string DefaultSkill10 = "DefaultSkill_10";
            public const string TextureType = "TextureType";
            public const string Except1 = "Except_1";
            public const string Except2 = "Except_2";
            public const string Except3 = "Except_3";
            public const string Except4 = "Except_4";
            public const string Except5 = "Except_5";
            public const string Except6 = "Except_6";
            public const string Except7 = "Except_7";
            public const string Except8 = "Except_8";
            public const string Except9 = "Except_9";
            public const string Except10 = "Except_10";
            public const string Link = "Link";
        }
        #endregion
    }
}
