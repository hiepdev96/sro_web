using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VsroShard.Shard_Repository
{
    public partial class VsroShardContext : DbContext
    {
        public VsroShardContext(DbContextOptions<VsroShardContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<VsroShard.Shard_Repository.Entities.AccountJID> AccountJIDs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.AlliedClans> AlliedClans { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.AssociationReputation> AssociationReputations { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.BindingOptionWithItem> BindingOptionWithItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.BlackNameList> BlackNameLists { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.BlockedWhisperers> BlockedWhisperers { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharCollectionBook> CharCollectionBooks { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharCOS> CharCOs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharInstanceWorldData> CharInstanceWorldData { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharNameList> CharNameLists { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharNickNameList> CharNickNameLists { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharQuest> CharQuests { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.Char> Chars { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharSkillMastery> CharSkillMasteries { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharSkill> CharSkills { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharTrijob> CharTrijobs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.CharTrijobSafeTrade> CharTrijobSafeTrades { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ChestInfo> ChestInfos { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.Chest> Chests { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ClientConfig> ClientConfigs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.DeletedChar> DeletedChars { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ExploitLog> ExploitLogs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.FlagWorldEventParticipants> FlagWorldEventParticipants { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.FleaMarketNetwork> FleaMarketNetworks { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.Friend> Friends { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.GPHistory> GPHistories { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.GuildChest> GuildChests { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.GuildMember> GuildMembers { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.Guild> Guilds { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.GuildWar> GuildWars { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.InvCOS> InvCOs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.Inventory> Inventories { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.InventoryForAvatar> InventoryForAvatars { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> InventoryForLinkedStorages { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ItemPool> ItemPools { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ItemQuayTNET> ItemQuayTNETs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ItemQuotation> ItemQuotations { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.Items> Items { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.LatestItemSerial> LatestItemSerials { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.LogSEEKNDESTROYITEMFAST> LogSEEKNDESTROYITEMFASTs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.Memo> Memos { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.OldTrijob> OldTrijobs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.OpenMarket> OpenMarkets { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefAbilityByItemOptLevel> RefAbilityByItemOptLevels { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefAccessPermissionOfShop> RefAccessPermissionOfShops { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefAlchemyMerit> RefAlchemyMerits { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefCharDefaultQuest> RefCharDefaultQuests { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefCharDefaultSkillMastery> RefCharDefaultSkillMasteries { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefCharDefaultSkill> RefCharDefaultSkills { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefCharGen> RefCharGens { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefClimate> RefClimates { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefCollectionBookItem> RefCollectionBookItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefCollectionBookTheme> RefCollectionBookThemes { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefConditionToBuyScrapItem> RefConditionToBuyScrapItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefConditionToSellPackageItem> RefConditionToSellPackageItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefConditionToSellScrapItem> RefConditionToSellScrapItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefCustomizingReservedItemDropForMonster> RefCustomizingReservedItemDropForMonsters { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelAlchemyATTRStone> RefDropClassSelAlchemyATTRStones { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelAlchemyMagicStone> RefDropClassSelAlchemyMagicStones { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelAlchemyTablet> RefDropClassSelAlchemyTablets { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelAmmo> RefDropClassSelAmmos { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelCure> RefDropClassSelCures { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelEquip> RefDropClassSelEquips { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelRareEquip> RefDropClassSelRareEquips { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelRecover> RefDropClassSelRecovers { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelReinforce> RefDropClassSelReinforces { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropClassSelScroll> RefDropClassSelScrolls { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropGold> RefDropGolds { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropItemAssign> RefDropItemAssigns { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropItemGroup> RefDropItemGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDropOptLvlSel> RefDropOptLvlSels { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefDummySlot> RefDummySlots { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefEventRewardItems> RefEventRewardItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefEventReward> RefEventRewards { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefEvent> RefEvents { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefEventZone> RefEventZones { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefFmnCategoryTree> RefFmnCategoryTrees { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefFmnTidGroupMap1> RefFmnTidGroupMap1s { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefFmnTidGroup> RefFmnTidGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGachaCode> RefGachaCodes { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGachaItemSet> RefGachaItemSets { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGachaNpcMap> RefGachaNpcMaps { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGameWorldBindGameWorldGroup> RefGameWorldBindGameWorldGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGameWorldBindTriggerCategory> RefGameWorldBindTriggerCategories { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGameWorldConfig> RefGameWorldConfigs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGameWorldGroupConfig> RefGameWorldGroupConfigs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGameWorldGroup> RefGameWorldGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGameWorldNPC> RefGameWorldNPCs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefGameWorld> RefGameWorlds { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefHWANLevel> RefHWANLevels { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefInstanceWorldRegion> RefInstanceWorldRegions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefInstanceWorldStartPos> RefInstanceWorldStartPos { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefLatestItemSerial> RefLatestItemSerials { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefLevel> RefLevels { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefMagicOptAssign> RefMagicOptAssigns { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefMagicOptByItemOptLevel> RefMagicOptByItemOptLevels { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefMagicOptGroup> RefMagicOptGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefMagicOpt> RefMagicOpts { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> RefMappingShopGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> RefMappingShopWithTabs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemDrop> RefMonsterAssignedItemDrops { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemRndDrop> RefMonsterAssignedItemRndDrops { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill> RefObjCharExtraSkills { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefObjChar> RefObjChars { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefObjCommon> RefObjCommons { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefObjItem> RefObjItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefObjStruct> RefObjStructs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefOptionalTeleport> RefOptionalTeleports { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefPackageItem> RefPackageItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem> RefPricePolicyOfItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefQuestRewardItems> RefQuestRewardItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefQuestReward> RefQuestRewards { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefQuest> RefQuests { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefRegionBindAssocServer> RefRegionBindAssocServers { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefRegion> RefRegions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefRentItem> RefRentItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefRewardPolicyToBuyScrapItem> RefRewardPolicyToBuyScrapItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem> RefRewardPolicyToSellPackageItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellScrapItem> RefRewardPolicyToSellScrapItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefScheduleDefine> RefScheduleDefines { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefScrapOfPackageItem> RefScrapOfPackageItems { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefServerEventRewardExpUPForPlayers> RefServerEventRewardExpUPForPlayers { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefServerEventReward> RefServerEventRewards { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefServerEventRewardSpawnMonster> RefServerEventRewardSpawnMonsters { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefServerEvent> RefServerEvents { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSetItemGroup> RefSetItemGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShardContentConfig> RefShardContentConfigs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShopGoods> RefShopGoods { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShopGroup> RefShopGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShopItemGroup> RefShopItemGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShopItemStockPeriod> RefShopItemStockPeriods { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShopObject> RefShopObjects { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShop> RefShops { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShopTabGroup> RefShopTabGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefShopTab> RefShopTabs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> RefSiegeBlessBuffs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeDungeon> RefSiegeDungeons { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank> RefSiegeFortressBattleRanks { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortress> RefSiegeFortresses { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard> RefSiegeFortressGuards { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge> RefSiegeFortressItemForges { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressRewards> RefSiegeFortressRewards { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster> RefSiegeLvlSummonMonsters { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeQuestReward> RefSiegeQuestRewards { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeQuest> RefSiegeQuests { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSiegeStructUpgrade> RefSiegeStructUpgrades { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSkillByItemOptLevel> RefSkillByItemOptLevels { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSkillGroup> RefSkillGroups { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSkillMastery> RefSkillMasteries { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefSkill> RefSkills { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTeleLink> RefTeleLinks { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTeleport1> RefTeleport1s { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTeleport> RefTeleports { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTreatItemOfShop> RefTreatItemOfShops { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerActionParam> RefTriggerActionParams { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerAction> RefTriggerActions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> RefTriggerBindActions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> RefTriggerBindConditions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> RefTriggerBindEvents { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerCategory> RefTriggerCategories { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> RefTriggerCategoryBindTriggers { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerCommon> RefTriggerCommons { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerConditionParam> RefTriggerConditionParams { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerCondition> RefTriggerConditions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerEvent> RefTriggerEvents { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTrigger> RefTriggers { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefTriggerVariable> RefTriggerVariables { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RefUIStringMt> RefUIStringMts { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.RentItemInfo> RentItemInfos { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide> ResultOfPackageItemToMappingWithServerSides { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.Schedule> Schedules { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ServerEventReward> ServerEventRewards { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ServerEvent> ServerEvents { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity> ShopItemStockQuantities { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> SiegeFortressBattleRecords { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.SiegeFortress> SiegeFortresses { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> SiegeFortressItemForges { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressObject> SiegeFortressObjects { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> SiegeFortressRequests { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressStoneState> SiegeFortressStoneStates { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressStruct> SiegeFortressStructs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.SkillBaoHiemTNET> SkillBaoHiemTNETs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.StaticAvatar> StaticAvatars { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabDBSafeCheckState> TabDBSafeCheckStates { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefAISkill> TabRefAISkills { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefHive> TabRefHives { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefNest> TabRefNests { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefRankingHunterActivity> TabRefRankingHunterActivities { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution> TabRefRankingHunterContributions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefRankingRobberActivity> TabRefRankingRobberActivities { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefRankingRobberContribution> TabRefRankingRobberContributions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefRankingTraderActivity> TabRefRankingTraderActivities { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefRankingTraderContribution> TabRefRankingTraderContributions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion> TabRefSpawnToolVersions { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TabRefTactics> TabRefTactics { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TestItemTNET> TestItemTNETs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TimedJobForPet> TimedJobForPets { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TimedJob> TimedJobs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TimItemOnChar> TimItemOnChars { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus> TrainingCampBuffStatuses { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank> TrainingCampHonorRanks { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TrainingCampHonorRankUpdateDate> TrainingCampHonorRankUpdateDates { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TrainingCampMember> TrainingCampMembers { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TrainingCamp> TrainingCamps { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TrainingCampSubMentorHonorPoint> TrainingCampSubMentorHonorPoints { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB> TrijobRanking4WEBs { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.TrijobRewards> TrijobRewards { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.UserBalanceNhat> UserBalanceNhats { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.UserOld> UserOlds { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.User> Users { get; set; }

        public virtual DbSet<VsroShard.Shard_Repository.Entities.WebShopSROLog> WebShopSROLogs { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.AccountJIDMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.AlliedClansMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.AssociationReputationMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.BindingOptionWithItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.BlackNameListMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.BlockedWhisperersMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharCollectionBookMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharCOSMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharInstanceWorldDataMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharNameListMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharNickNameListMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharQuestMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharSkillMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharSkillMasteryMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharTrijobMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.CharTrijobSafeTradeMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ChestInfoMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ChestMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ClientConfigMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.DeletedCharMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ExploitLogMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.FlagWorldEventParticipantsMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.FleaMarketNetworkMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.FriendMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.GPHistoryMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.GuildChestMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.GuildMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.GuildMemberMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.GuildWarMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.InvCOSMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.InventoryForAvatarMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.InventoryForLinkedStorageMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.InventoryMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ItemPoolMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ItemQuayTNETMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ItemQuotationMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ItemsMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.LatestItemSerialMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.LogSEEKNDESTROYITEMFASTMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.MemoMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.OldTrijobMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.OpenMarketMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefAbilityByItemOptLevelMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefAccessPermissionOfShopMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefAlchemyMeritMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefCharDefaultQuestMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefCharDefaultSkillMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefCharDefaultSkillMasteryMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefCharGenMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefClimateMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefCollectionBookItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefCollectionBookThemeMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefConditionToBuyScrapItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefConditionToSellPackageItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefConditionToSellScrapItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefCustomizingReservedItemDropForMonsterMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelAlchemyATTRStoneMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelAlchemyMagicStoneMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelAlchemyTabletMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelAmmoMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelCureMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelEquipMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelRareEquipMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelRecoverMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelReinforceMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropClassSelScrollMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropGoldMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropItemAssignMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropItemGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDropOptLvlSelMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefDummySlotMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefEventMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefEventRewardItemsMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefEventRewardMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefEventZoneMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefFmnCategoryTreeMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefFmnTidGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefFmnTidGroupMap1Map());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGachaCodeMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGachaItemSetMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGachaNpcMapMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGameWorldBindGameWorldGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGameWorldBindTriggerCategoryMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGameWorldConfigMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGameWorldGroupConfigMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGameWorldGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGameWorldMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefGameWorldNPCMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefHWANLevelMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefInstanceWorldRegionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefInstanceWorldStartPosMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefLatestItemSerialMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefLevelMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefMagicOptAssignMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefMagicOptByItemOptLevelMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefMagicOptGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefMagicOptMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefMappingShopGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefMappingShopWithTabMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefMonsterAssignedItemDropMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefMonsterAssignedItemRndDropMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefObjCharExtraSkillMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefObjCharMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefObjCommonMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefObjItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefObjStructMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefOptionalTeleportMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefPackageItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefPricePolicyOfItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefQuestMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefQuestRewardItemsMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefQuestRewardMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefRegionBindAssocServerMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefRegionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefRentItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefRewardPolicyToBuyScrapItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefRewardPolicyToSellPackageItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefRewardPolicyToSellScrapItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefScheduleDefineMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefScrapOfPackageItemMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefServerEventMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefServerEventRewardExpUPForPlayersMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefServerEventRewardMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefServerEventRewardSpawnMonsterMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSetItemGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShardContentConfigMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShopGoodsMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShopGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShopItemGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShopItemStockPeriodMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShopMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShopObjectMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShopTabGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefShopTabMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeBlessBuffMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeDungeonMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeFortressBattleRankMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeFortressGuardMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeFortressItemForgeMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeFortressMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeFortressRewardsMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeLvlSummonMonsterMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeQuestMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeQuestRewardMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSiegeStructUpgradeMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSkillByItemOptLevelMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSkillGroupMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSkillMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefSkillMasteryMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTeleLinkMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTeleport1Map());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTeleportMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTreatItemOfShopMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerActionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerActionParamMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerBindActionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerBindConditionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerBindEventMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerCategoryBindTriggerMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerCategoryMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerCommonMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerConditionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerConditionParamMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerEventMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefTriggerVariableMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RefUIStringMtMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.RentItemInfoMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ResultOfPackageItemToMappingWithServerSideMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ScheduleMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ServerEventMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ServerEventRewardMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.ShopItemStockQuantityMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.SiegeFortressBattleRecordMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.SiegeFortressItemForgeMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.SiegeFortressMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.SiegeFortressObjectMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.SiegeFortressRequestMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.SiegeFortressStoneStateMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.SiegeFortressStructMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.SkillBaoHiemTNETMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.StaticAvatarMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabDBSafeCheckStateMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefAISkillMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefHiveMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefNestMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefRankingHunterActivityMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefRankingHunterContributionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefRankingRobberActivityMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefRankingRobberContributionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefRankingTraderActivityMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefRankingTraderContributionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefSpawnToolVersionMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TabRefTacticsMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TestItemTNETMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TimedJobForPetMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TimedJobMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TimItemOnCharMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TrainingCampBuffStatusMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TrainingCampHonorRankMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TrainingCampHonorRankUpdateDateMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TrainingCampMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TrainingCampMemberMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TrainingCampSubMentorHonorPointMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TrijobRanking4WEBMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.TrijobRewardsMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.UserBalanceNhatMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.UserMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.UserOldMap());
            modelBuilder.ApplyConfiguration(new VsroShard.Shard_Repository.Mapping.WebShopSROLogMap());
            #endregion
        }
    }
}
