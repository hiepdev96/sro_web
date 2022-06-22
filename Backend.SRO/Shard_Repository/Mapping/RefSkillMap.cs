using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSkillMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSkill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSkill> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSkill", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.GroupID)
                .IsRequired()
                .HasColumnName("GroupID")
                .HasColumnType("int");

            builder.Property(t => t.BasicCode)
                .IsRequired()
                .HasColumnName("Basic_Code")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.BasicName)
                .IsRequired()
                .HasColumnName("Basic_Name")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.BasicGroup)
                .IsRequired()
                .HasColumnName("Basic_Group")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.BasicOriginal)
                .IsRequired()
                .HasColumnName("Basic_Original")
                .HasColumnType("int");

            builder.Property(t => t.BasicLevel)
                .IsRequired()
                .HasColumnName("Basic_Level")
                .HasColumnType("tinyint");

            builder.Property(t => t.BasicActivity)
                .IsRequired()
                .HasColumnName("Basic_Activity")
                .HasColumnType("tinyint");

            builder.Property(t => t.BasicChainCode)
                .IsRequired()
                .HasColumnName("Basic_ChainCode")
                .HasColumnType("int");

            builder.Property(t => t.BasicRecycleCost)
                .IsRequired()
                .HasColumnName("Basic_RecycleCost")
                .HasColumnType("int");

            builder.Property(t => t.ActionPreparingTime)
                .IsRequired()
                .HasColumnName("Action_PreparingTime")
                .HasColumnType("int");

            builder.Property(t => t.ActionCastingTime)
                .IsRequired()
                .HasColumnName("Action_CastingTime")
                .HasColumnType("int");

            builder.Property(t => t.ActionActionDuration)
                .IsRequired()
                .HasColumnName("Action_ActionDuration")
                .HasColumnType("int");

            builder.Property(t => t.ActionReuseDelay)
                .IsRequired()
                .HasColumnName("Action_ReuseDelay")
                .HasColumnType("int");

            builder.Property(t => t.ActionCoolTime)
                .IsRequired()
                .HasColumnName("Action_CoolTime")
                .HasColumnType("int");

            builder.Property(t => t.ActionFlyingSpeed)
                .IsRequired()
                .HasColumnName("Action_FlyingSpeed")
                .HasColumnType("int");

            builder.Property(t => t.ActionInterruptable)
                .IsRequired()
                .HasColumnName("Action_Interruptable")
                .HasColumnType("tinyint");

            builder.Property(t => t.ActionOverlap)
                .IsRequired()
                .HasColumnName("Action_Overlap")
                .HasColumnType("int");

            builder.Property(t => t.ActionAutoAttackType)
                .IsRequired()
                .HasColumnName("Action_AutoAttackType")
                .HasColumnType("tinyint");

            builder.Property(t => t.ActionInTown)
                .IsRequired()
                .HasColumnName("Action_InTown")
                .HasColumnType("tinyint");

            builder.Property(t => t.ActionRange)
                .IsRequired()
                .HasColumnName("Action_Range")
                .HasColumnType("smallint");

            builder.Property(t => t.TargetRequired)
                .IsRequired()
                .HasColumnName("Target_Required")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetTypeAnimal)
                .IsRequired()
                .HasColumnName("TargetType_Animal")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetTypeLand)
                .IsRequired()
                .HasColumnName("TargetType_Land")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetTypeBuilding)
                .IsRequired()
                .HasColumnName("TargetType_Building")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetGroupSelf)
                .IsRequired()
                .HasColumnName("TargetGroup_Self")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetGroupAlly)
                .IsRequired()
                .HasColumnName("TargetGroup_Ally")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetGroupParty)
                .IsRequired()
                .HasColumnName("TargetGroup_Party")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetGroupEnemyM)
                .IsRequired()
                .HasColumnName("TargetGroup_Enemy_M")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetGroupEnemyP)
                .IsRequired()
                .HasColumnName("TargetGroup_Enemy_P")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetGroupNeutral)
                .IsRequired()
                .HasColumnName("TargetGroup_Neutral")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetGroupDontCare)
                .IsRequired()
                .HasColumnName("TargetGroup_DontCare")
                .HasColumnType("tinyint");

            builder.Property(t => t.TargetEtcSelectDeadBody)
                .IsRequired()
                .HasColumnName("TargetEtc_SelectDeadBody")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqCommonMastery1)
                .IsRequired()
                .HasColumnName("ReqCommon_Mastery1")
                .HasColumnType("int");

            builder.Property(t => t.ReqCommonMastery2)
                .IsRequired()
                .HasColumnName("ReqCommon_Mastery2")
                .HasColumnType("int");

            builder.Property(t => t.ReqCommonMasteryLevel1)
                .IsRequired()
                .HasColumnName("ReqCommon_MasteryLevel1")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqCommonMasteryLevel2)
                .IsRequired()
                .HasColumnName("ReqCommon_MasteryLevel2")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqCommonStr)
                .IsRequired()
                .HasColumnName("ReqCommon_Str")
                .HasColumnType("smallint");

            builder.Property(t => t.ReqCommonInt)
                .IsRequired()
                .HasColumnName("ReqCommon_Int")
                .HasColumnType("smallint");

            builder.Property(t => t.ReqLearnSkill1)
                .IsRequired()
                .HasColumnName("ReqLearn_Skill1")
                .HasColumnType("int");

            builder.Property(t => t.ReqLearnSkill2)
                .IsRequired()
                .HasColumnName("ReqLearn_Skill2")
                .HasColumnType("int");

            builder.Property(t => t.ReqLearnSkill3)
                .IsRequired()
                .HasColumnName("ReqLearn_Skill3")
                .HasColumnType("int");

            builder.Property(t => t.ReqLearnSkillLevel1)
                .IsRequired()
                .HasColumnName("ReqLearn_SkillLevel1")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqLearnSkillLevel2)
                .IsRequired()
                .HasColumnName("ReqLearn_SkillLevel2")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqLearnSkillLevel3)
                .IsRequired()
                .HasColumnName("ReqLearn_SkillLevel3")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqLearnSP)
                .IsRequired()
                .HasColumnName("ReqLearn_SP")
                .HasColumnType("int");

            builder.Property(t => t.ReqLearnRace)
                .IsRequired()
                .HasColumnName("ReqLearn_Race")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqRestriction1)
                .IsRequired()
                .HasColumnName("Req_Restriction1")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqRestriction2)
                .IsRequired()
                .HasColumnName("Req_Restriction2")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqCastWeapon1)
                .IsRequired()
                .HasColumnName("ReqCast_Weapon1")
                .HasColumnType("tinyint");

            builder.Property(t => t.ReqCastWeapon2)
                .IsRequired()
                .HasColumnName("ReqCast_Weapon2")
                .HasColumnType("tinyint");

            builder.Property(t => t.ConsumeHP)
                .IsRequired()
                .HasColumnName("Consume_HP")
                .HasColumnType("smallint");

            builder.Property(t => t.ConsumeMP)
                .IsRequired()
                .HasColumnName("Consume_MP")
                .HasColumnType("smallint");

            builder.Property(t => t.ConsumeHPRatio)
                .IsRequired()
                .HasColumnName("Consume_HPRatio")
                .HasColumnType("smallint");

            builder.Property(t => t.ConsumeMPRatio)
                .IsRequired()
                .HasColumnName("Consume_MPRatio")
                .HasColumnType("smallint");

            builder.Property(t => t.ConsumeWHAN)
                .IsRequired()
                .HasColumnName("Consume_WHAN")
                .HasColumnType("tinyint");

            builder.Property(t => t.UISkillTab)
                .IsRequired()
                .HasColumnName("UI_SkillTab")
                .HasColumnType("tinyint");

            builder.Property(t => t.UISkillPage)
                .IsRequired()
                .HasColumnName("UI_SkillPage")
                .HasColumnType("tinyint");

            builder.Property(t => t.UISkillColumn)
                .IsRequired()
                .HasColumnName("UI_SkillColumn")
                .HasColumnType("tinyint");

            builder.Property(t => t.UISkillRow)
                .IsRequired()
                .HasColumnName("UI_SkillRow")
                .HasColumnType("tinyint");

            builder.Property(t => t.UIIconFile)
                .IsRequired()
                .HasColumnName("UI_IconFile")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.UISkillName)
                .IsRequired()
                .HasColumnName("UI_SkillName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.UISkillToolTip)
                .IsRequired()
                .HasColumnName("UI_SkillToolTip")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.UISkillToolTipDesc)
                .IsRequired()
                .HasColumnName("UI_SkillToolTip_Desc")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.UISkillStudyDesc)
                .IsRequired()
                .HasColumnName("UI_SkillStudy_Desc")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.AIAttackChance)
                .IsRequired()
                .HasColumnName("AI_AttackChance")
                .HasColumnType("smallint");

            builder.Property(t => t.AISkillType)
                .IsRequired()
                .HasColumnName("AI_SkillType")
                .HasColumnType("tinyint");

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

            builder.Property(t => t.Param17)
                .IsRequired()
                .HasColumnName("Param17")
                .HasColumnType("int");

            builder.Property(t => t.Param18)
                .IsRequired()
                .HasColumnName("Param18")
                .HasColumnType("int");

            builder.Property(t => t.Param19)
                .IsRequired()
                .HasColumnName("Param19")
                .HasColumnType("int");

            builder.Property(t => t.Param20)
                .IsRequired()
                .HasColumnName("Param20")
                .HasColumnType("int");

            builder.Property(t => t.Param21)
                .IsRequired()
                .HasColumnName("Param21")
                .HasColumnType("int");

            builder.Property(t => t.Param22)
                .IsRequired()
                .HasColumnName("Param22")
                .HasColumnType("int");

            builder.Property(t => t.Param23)
                .IsRequired()
                .HasColumnName("Param23")
                .HasColumnType("int");

            builder.Property(t => t.Param24)
                .IsRequired()
                .HasColumnName("Param24")
                .HasColumnType("int");

            builder.Property(t => t.Param25)
                .IsRequired()
                .HasColumnName("Param25")
                .HasColumnType("int");

            builder.Property(t => t.Param26)
                .HasColumnName("Param26")
                .HasColumnType("int");

            builder.Property(t => t.Param27)
                .HasColumnName("Param27")
                .HasColumnType("int");

            builder.Property(t => t.Param28)
                .HasColumnName("Param28")
                .HasColumnType("int");

            builder.Property(t => t.Param29)
                .HasColumnName("Param29")
                .HasColumnType("int");

            builder.Property(t => t.Param30)
                .HasColumnName("Param30")
                .HasColumnType("int");

            builder.Property(t => t.Param31)
                .HasColumnName("Param31")
                .HasColumnType("int");

            builder.Property(t => t.Param32)
                .HasColumnName("Param32")
                .HasColumnType("int");

            builder.Property(t => t.Param33)
                .HasColumnName("Param33")
                .HasColumnType("int");

            builder.Property(t => t.Param34)
                .HasColumnName("Param34")
                .HasColumnType("int");

            builder.Property(t => t.Param35)
                .HasColumnName("Param35")
                .HasColumnType("int");

            builder.Property(t => t.Param36)
                .HasColumnName("Param36")
                .HasColumnType("int");

            builder.Property(t => t.Param37)
                .HasColumnName("Param37")
                .HasColumnType("int");

            builder.Property(t => t.Param38)
                .HasColumnName("Param38")
                .HasColumnType("int");

            builder.Property(t => t.Param39)
                .HasColumnName("Param39")
                .HasColumnType("int");

            builder.Property(t => t.Param40)
                .HasColumnName("Param40")
                .HasColumnType("int");

            builder.Property(t => t.Param41)
                .HasColumnName("Param41")
                .HasColumnType("int");

            builder.Property(t => t.Param42)
                .HasColumnName("Param42")
                .HasColumnType("int");

            builder.Property(t => t.Param43)
                .HasColumnName("Param43")
                .HasColumnType("int");

            builder.Property(t => t.Param44)
                .HasColumnName("Param44")
                .HasColumnType("int");

            builder.Property(t => t.Param45)
                .HasColumnName("Param45")
                .HasColumnType("int");

            builder.Property(t => t.Param46)
                .HasColumnName("Param46")
                .HasColumnType("int");

            builder.Property(t => t.Param47)
                .HasColumnName("Param47")
                .HasColumnType("int");

            builder.Property(t => t.Param48)
                .HasColumnName("Param48")
                .HasColumnType("int");

            builder.Property(t => t.Param49)
                .HasColumnName("Param49")
                .HasColumnType("int");

            builder.Property(t => t.Param50)
                .HasColumnName("Param50")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSkill";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string GroupID = "GroupID";
            public const string BasicCode = "Basic_Code";
            public const string BasicName = "Basic_Name";
            public const string BasicGroup = "Basic_Group";
            public const string BasicOriginal = "Basic_Original";
            public const string BasicLevel = "Basic_Level";
            public const string BasicActivity = "Basic_Activity";
            public const string BasicChainCode = "Basic_ChainCode";
            public const string BasicRecycleCost = "Basic_RecycleCost";
            public const string ActionPreparingTime = "Action_PreparingTime";
            public const string ActionCastingTime = "Action_CastingTime";
            public const string ActionActionDuration = "Action_ActionDuration";
            public const string ActionReuseDelay = "Action_ReuseDelay";
            public const string ActionCoolTime = "Action_CoolTime";
            public const string ActionFlyingSpeed = "Action_FlyingSpeed";
            public const string ActionInterruptable = "Action_Interruptable";
            public const string ActionOverlap = "Action_Overlap";
            public const string ActionAutoAttackType = "Action_AutoAttackType";
            public const string ActionInTown = "Action_InTown";
            public const string ActionRange = "Action_Range";
            public const string TargetRequired = "Target_Required";
            public const string TargetTypeAnimal = "TargetType_Animal";
            public const string TargetTypeLand = "TargetType_Land";
            public const string TargetTypeBuilding = "TargetType_Building";
            public const string TargetGroupSelf = "TargetGroup_Self";
            public const string TargetGroupAlly = "TargetGroup_Ally";
            public const string TargetGroupParty = "TargetGroup_Party";
            public const string TargetGroupEnemyM = "TargetGroup_Enemy_M";
            public const string TargetGroupEnemyP = "TargetGroup_Enemy_P";
            public const string TargetGroupNeutral = "TargetGroup_Neutral";
            public const string TargetGroupDontCare = "TargetGroup_DontCare";
            public const string TargetEtcSelectDeadBody = "TargetEtc_SelectDeadBody";
            public const string ReqCommonMastery1 = "ReqCommon_Mastery1";
            public const string ReqCommonMastery2 = "ReqCommon_Mastery2";
            public const string ReqCommonMasteryLevel1 = "ReqCommon_MasteryLevel1";
            public const string ReqCommonMasteryLevel2 = "ReqCommon_MasteryLevel2";
            public const string ReqCommonStr = "ReqCommon_Str";
            public const string ReqCommonInt = "ReqCommon_Int";
            public const string ReqLearnSkill1 = "ReqLearn_Skill1";
            public const string ReqLearnSkill2 = "ReqLearn_Skill2";
            public const string ReqLearnSkill3 = "ReqLearn_Skill3";
            public const string ReqLearnSkillLevel1 = "ReqLearn_SkillLevel1";
            public const string ReqLearnSkillLevel2 = "ReqLearn_SkillLevel2";
            public const string ReqLearnSkillLevel3 = "ReqLearn_SkillLevel3";
            public const string ReqLearnSP = "ReqLearn_SP";
            public const string ReqLearnRace = "ReqLearn_Race";
            public const string ReqRestriction1 = "Req_Restriction1";
            public const string ReqRestriction2 = "Req_Restriction2";
            public const string ReqCastWeapon1 = "ReqCast_Weapon1";
            public const string ReqCastWeapon2 = "ReqCast_Weapon2";
            public const string ConsumeHP = "Consume_HP";
            public const string ConsumeMP = "Consume_MP";
            public const string ConsumeHPRatio = "Consume_HPRatio";
            public const string ConsumeMPRatio = "Consume_MPRatio";
            public const string ConsumeWHAN = "Consume_WHAN";
            public const string UISkillTab = "UI_SkillTab";
            public const string UISkillPage = "UI_SkillPage";
            public const string UISkillColumn = "UI_SkillColumn";
            public const string UISkillRow = "UI_SkillRow";
            public const string UIIconFile = "UI_IconFile";
            public const string UISkillName = "UI_SkillName";
            public const string UISkillToolTip = "UI_SkillToolTip";
            public const string UISkillToolTipDesc = "UI_SkillToolTip_Desc";
            public const string UISkillStudyDesc = "UI_SkillStudy_Desc";
            public const string AIAttackChance = "AI_AttackChance";
            public const string AISkillType = "AI_SkillType";
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
            public const string Param17 = "Param17";
            public const string Param18 = "Param18";
            public const string Param19 = "Param19";
            public const string Param20 = "Param20";
            public const string Param21 = "Param21";
            public const string Param22 = "Param22";
            public const string Param23 = "Param23";
            public const string Param24 = "Param24";
            public const string Param25 = "Param25";
            public const string Param26 = "Param26";
            public const string Param27 = "Param27";
            public const string Param28 = "Param28";
            public const string Param29 = "Param29";
            public const string Param30 = "Param30";
            public const string Param31 = "Param31";
            public const string Param32 = "Param32";
            public const string Param33 = "Param33";
            public const string Param34 = "Param34";
            public const string Param35 = "Param35";
            public const string Param36 = "Param36";
            public const string Param37 = "Param37";
            public const string Param38 = "Param38";
            public const string Param39 = "Param39";
            public const string Param40 = "Param40";
            public const string Param41 = "Param41";
            public const string Param42 = "Param42";
            public const string Param43 = "Param43";
            public const string Param44 = "Param44";
            public const string Param45 = "Param45";
            public const string Param46 = "Param46";
            public const string Param47 = "Param47";
            public const string Param48 = "Param48";
            public const string Param49 = "Param49";
            public const string Param50 = "Param50";
        }
        #endregion
    }
}
