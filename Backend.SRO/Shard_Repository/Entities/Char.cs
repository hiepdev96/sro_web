using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class Char
    {
        public Char()
        {
            #region Generated Constructor
            CharSkillMasteries = new HashSet<CharSkillMastery>();
            CharSkills = new HashSet<CharSkill>();
            Friends = new HashSet<Friend>();
            GuildMembers = new HashSet<GuildMember>();
            Inventories = new HashSet<Inventory>();
            InventoryForAvatars = new HashSet<InventoryForAvatar>();
            Memos = new HashSet<Memo>();
            OwnerCharCOs = new HashSet<CharCOS>();
            TimedJobs = new HashSet<TimedJob>();
            TrainingCampMembers = new HashSet<TrainingCampMember>();
            Users = new HashSet<User>();
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public byte Deleted { get; set; }

        public int RefObjID { get; set; }

        public string CharName16 { get; set; }

        public string NickName16 { get; set; }

        public byte Scale { get; set; }

        public byte CurLevel { get; set; }

        public byte MaxLevel { get; set; }

        public long ExpOffset { get; set; }

        public int SExpOffset { get; set; }

        public short Strength { get; set; }

        public short Intellect { get; set; }

        public long RemainGold { get; set; }

        public int RemainSkillPoint { get; set; }

        public short RemainStatPoint { get; set; }

        public byte RemainHwanCount { get; set; }

        public int GatheredExpPoint { get; set; }

        public int Hp { get; set; }

        public int Mp { get; set; }

        public short LatestRegion { get; set; }

        public float PosX { get; set; }

        public float PosY { get; set; }

        public float PosZ { get; set; }

        public int AppointedTeleport { get; set; }

        public byte AutoInvestExp { get; set; }

        public int InventorySize { get; set; }

        public byte DailyPK { get; set; }

        public short TotalPK { get; set; }

        public int PKPenaltyPoint { get; set; }

        public int Tpp { get; set; }

        public int PenaltyForfeit { get; set; }

        public int JobPenaltyTime { get; set; }

        public byte JobLvlTrader { get; set; }

        public int TraderExp { get; set; }

        public byte JobLvlHunter { get; set; }

        public int HunterExp { get; set; }

        public byte JobLvlRobber { get; set; }

        public int RobberExp { get; set; }

        public int? GuildID { get; set; }

        public DateTime LastLogout { get; set; }

        public short TelRegion { get; set; }

        public float TelPosX { get; set; }

        public float TelPosY { get; set; }

        public float TelPosZ { get; set; }

        public short DiedRegion { get; set; }

        public float DiedPosX { get; set; }

        public float DiedPosY { get; set; }

        public float DiedPosZ { get; set; }

        public short WorldID { get; set; }

        public short TelWorldID { get; set; }

        public short DiedWorldID { get; set; }

        public byte HwanLevel { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CharSkillMastery> CharSkillMasteries { get; set; }

        public virtual ICollection<CharSkill> CharSkills { get; set; }

        public virtual CharTrijob CharTrijob { get; set; }

        public virtual FleaMarketNetwork FleaMarketNetwork { get; set; }

        public virtual Friend Friend { get; set; }

        public virtual ICollection<Friend> Friends { get; set; }

        public virtual ICollection<GuildMember> GuildMembers { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }

        public virtual ICollection<InventoryForAvatar> InventoryForAvatars { get; set; }

        public virtual ICollection<Memo> Memos { get; set; }

        public virtual BlockedWhisperers OwnerBlockedWhisperers { get; set; }

        public virtual ICollection<CharCOS> OwnerCharCOs { get; set; }

        public virtual StaticAvatar StaticAvatar { get; set; }

        public virtual ICollection<TimedJob> TimedJobs { get; set; }

        public virtual ICollection<TrainingCampMember> TrainingCampMembers { get; set; }

        public virtual TrainingCampSubMentorHonorPoint TrainingCampSubMentorHonorPoint { get; set; }

        public virtual ICollection<User> Users { get; set; }

        #endregion

    }
}
