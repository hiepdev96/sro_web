using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefSkill
    {
        public RefSkill()
        {
            #region Generated Constructor
            RefBlessBuffRefSiegeBlessBuffs = new HashSet<RefSiegeBlessBuff>();
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Id { get; set; }

        public int GroupID { get; set; }

        public string BasicCode { get; set; }

        public string BasicName { get; set; }

        public string BasicGroup { get; set; }

        public int BasicOriginal { get; set; }

        public byte BasicLevel { get; set; }

        public byte BasicActivity { get; set; }

        public int BasicChainCode { get; set; }

        public int BasicRecycleCost { get; set; }

        public int ActionPreparingTime { get; set; }

        public int ActionCastingTime { get; set; }

        public int ActionActionDuration { get; set; }

        public int ActionReuseDelay { get; set; }

        public int ActionCoolTime { get; set; }

        public int ActionFlyingSpeed { get; set; }

        public byte ActionInterruptable { get; set; }

        public int ActionOverlap { get; set; }

        public byte ActionAutoAttackType { get; set; }

        public byte ActionInTown { get; set; }

        public short ActionRange { get; set; }

        public byte TargetRequired { get; set; }

        public byte TargetTypeAnimal { get; set; }

        public byte TargetTypeLand { get; set; }

        public byte TargetTypeBuilding { get; set; }

        public byte TargetGroupSelf { get; set; }

        public byte TargetGroupAlly { get; set; }

        public byte TargetGroupParty { get; set; }

        public byte TargetGroupEnemyM { get; set; }

        public byte TargetGroupEnemyP { get; set; }

        public byte TargetGroupNeutral { get; set; }

        public byte TargetGroupDontCare { get; set; }

        public byte TargetEtcSelectDeadBody { get; set; }

        public int ReqCommonMastery1 { get; set; }

        public int ReqCommonMastery2 { get; set; }

        public byte ReqCommonMasteryLevel1 { get; set; }

        public byte ReqCommonMasteryLevel2 { get; set; }

        public short ReqCommonStr { get; set; }

        public short ReqCommonInt { get; set; }

        public int ReqLearnSkill1 { get; set; }

        public int ReqLearnSkill2 { get; set; }

        public int ReqLearnSkill3 { get; set; }

        public byte ReqLearnSkillLevel1 { get; set; }

        public byte ReqLearnSkillLevel2 { get; set; }

        public byte ReqLearnSkillLevel3 { get; set; }

        public int ReqLearnSP { get; set; }

        public byte ReqLearnRace { get; set; }

        public byte ReqRestriction1 { get; set; }

        public byte ReqRestriction2 { get; set; }

        public byte ReqCastWeapon1 { get; set; }

        public byte ReqCastWeapon2 { get; set; }

        public short ConsumeHP { get; set; }

        public short ConsumeMP { get; set; }

        public short ConsumeHPRatio { get; set; }

        public short ConsumeMPRatio { get; set; }

        public byte ConsumeWHAN { get; set; }

        public byte UISkillTab { get; set; }

        public byte UISkillPage { get; set; }

        public byte UISkillColumn { get; set; }

        public byte UISkillRow { get; set; }

        public string UIIconFile { get; set; }

        public string UISkillName { get; set; }

        public string UISkillToolTip { get; set; }

        public string UISkillToolTipDesc { get; set; }

        public string UISkillStudyDesc { get; set; }

        public short AIAttackChance { get; set; }

        public byte AISkillType { get; set; }

        public int Param1 { get; set; }

        public int Param2 { get; set; }

        public int Param3 { get; set; }

        public int Param4 { get; set; }

        public int Param5 { get; set; }

        public int Param6 { get; set; }

        public int Param7 { get; set; }

        public int Param8 { get; set; }

        public int Param9 { get; set; }

        public int Param10 { get; set; }

        public int Param11 { get; set; }

        public int Param12 { get; set; }

        public int Param13 { get; set; }

        public int Param14 { get; set; }

        public int Param15 { get; set; }

        public int Param16 { get; set; }

        public int Param17 { get; set; }

        public int Param18 { get; set; }

        public int Param19 { get; set; }

        public int Param20 { get; set; }

        public int Param21 { get; set; }

        public int Param22 { get; set; }

        public int Param23 { get; set; }

        public int Param24 { get; set; }

        public int Param25 { get; set; }

        public int? Param26 { get; set; }

        public int? Param27 { get; set; }

        public int? Param28 { get; set; }

        public int? Param29 { get; set; }

        public int? Param30 { get; set; }

        public int? Param31 { get; set; }

        public int? Param32 { get; set; }

        public int? Param33 { get; set; }

        public int? Param34 { get; set; }

        public int? Param35 { get; set; }

        public int? Param36 { get; set; }

        public int? Param37 { get; set; }

        public int? Param38 { get; set; }

        public int? Param39 { get; set; }

        public int? Param40 { get; set; }

        public int? Param41 { get; set; }

        public int? Param42 { get; set; }

        public int? Param43 { get; set; }

        public int? Param44 { get; set; }

        public int? Param45 { get; set; }

        public int? Param46 { get; set; }

        public int? Param47 { get; set; }

        public int? Param48 { get; set; }

        public int? Param49 { get; set; }

        public int? Param50 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<RefSiegeBlessBuff> RefBlessBuffRefSiegeBlessBuffs { get; set; }

        #endregion

    }
}
