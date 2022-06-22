using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VsroAccount.Repository
{
    public partial class VsroAccountContext : DbContext
    {
        public VsroAccountContext(DbContextOptions<VsroAccountContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<VsroAccount.Repository.Entities.BlockedUser> BlockedUsers { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.Books> Books { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.BrutalBlockedIP> BrutalBlockedIPs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.CasData> CasData { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.CasGMChatLog> CasGMChatLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.Dtproperties> Dtproperties { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.LoginLogoutStatistics> LoginLogoutStatistics { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.ModuleVersionFile> ModuleVersionFiles { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.ModuleVersion> ModuleVersions { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.Notice> Notices { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.OldBlockedUser> OldBlockedUsers { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.PrivilegedIP> PrivilegedIPs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.Punishment> Punishments { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.QuaySoEpoint> QuaySoEpoints { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.RefCountryNameAndCode> RefCountryNameAndCodes { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SecurityDescriptionGroupAssign> SecurityDescriptionGroupAssigns { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SecurityDescriptionGroup> SecurityDescriptionGroups { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SecurityDescription> SecurityDescriptions { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.ServiceManagerLog> ServiceManagerLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.ShardCurrentUser> ShardCurrentUsers { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.Shard> Shards { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.ShardService> ShardServices { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SiegeFortressStatus> SiegeFortressStatuses { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKCharRenameLog> SKCharRenameLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKDownLevelLog> SKDownLevelLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKGamebangIp> SKGamebangIps { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKITEMGuardLog> SKITEMGuardLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKItemSaleLog> SKItemSaleLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKPackageItemSaleLog> SKPackageItemSaleLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKPKUpdateLog> SKPKUpdateLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKResetSkillLog> SKResetSkillLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SkShl> SkShls { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKSilkBuyList> SKSilkBuyLists { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKSilkChangeBYWeb> SKSilkChangeBYWebs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKSilkGoods> SKSilkGoods { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKSilk> SKSilks { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SKSubtractSilkVAS> SKSubtractSilkVAs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SMCLog> SMCLogs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SRCharNames> SRCharNames { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.SRShardCharNames> SRShardCharNames { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.TBNet2e> TBNet2es { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.TbPartnerInfo> TbPartnerInfos { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.TbPaygateTrans> TbPaygateTrans { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.TBRefItemName> TBRefItemNames { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.TBUser> TBUsers { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.TestHN> TestHNs { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.Tmp> Tmps { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.TrijobRanking> TrijobRankings { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.TrijobRankingStatus> TrijobRankingStatuses { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.View1> View1s { get; set; }

        public virtual DbSet<VsroAccount.Repository.Entities.WriteOutResetPlayTime> WriteOutResetPlayTimes { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.BlockedUserMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.BooksMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.BrutalBlockedIPMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.CasDataMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.CasGMChatLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.DtpropertiesMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.LoginLogoutStatisticsMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.ModuleVersionFileMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.ModuleVersionMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.NoticeMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.OldBlockedUserMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.PrivilegedIPMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.PunishmentMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.QuaySoEpointMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.RefCountryNameAndCodeMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SecurityDescriptionGroupAssignMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SecurityDescriptionGroupMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SecurityDescriptionMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.ServiceManagerLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.ShardCurrentUserMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.ShardMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.ShardServiceMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SiegeFortressStatusMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKCharRenameLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKDownLevelLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKGamebangIpMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKITEMGuardLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKItemSaleLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKPackageItemSaleLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKPKUpdateLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKResetSkillLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SkShlMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKSilkBuyListMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKSilkChangeBYWebMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKSilkGoodsMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKSilkMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SKSubtractSilkVASMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SMCLogMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SRCharNamesMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.SRShardCharNamesMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TBNet2eMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TbPartnerInfoMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TbPaygateTransMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TBRefItemNameMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TBUserMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TestHNMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TmpMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TrijobRankingMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.TrijobRankingStatusMap());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.View1Map());
            modelBuilder.ApplyConfiguration(new VsroAccount.Repository.Mapping.WriteOutResetPlayTimeMap());
            #endregion
        }
    }
}
