using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefShopObject
    {
        public RefShopObject()
        {
            #region Generated Constructor
            CountryRefMappingShopGroups = new HashSet<RefMappingShopGroup>();
            CountryRefMappingShopWithTabs = new HashSet<RefMappingShopWithTab>();
            CountryRefPackageItems = new HashSet<RefPackageItem>();
            CountryRefPricePolicyOfItems = new HashSet<RefPricePolicyOfItem>();
            CountryRefRewardPolicyToBuyScrapItems = new HashSet<RefRewardPolicyToBuyScrapItem>();
            CountryRefRewardPolicyToSellPackageItems = new HashSet<RefRewardPolicyToSellPackageItem>();
            CountryRefRewardPolicyToSellScrapItems = new HashSet<RefRewardPolicyToSellScrapItem>();
            CountryRefScrapOfPackageItems = new HashSet<RefScrapOfPackageItem>();
            CountryRefShopGoods = new HashSet<RefShopGoods>();
            CountryRefShopGroups = new HashSet<RefShopGroup>();
            CountryRefShops = new HashSet<RefShop>();
            CountryRefShopTabGroups = new HashSet<RefShopTabGroup>();
            CountryRefShopTabs = new HashSet<RefShopTab>();
            CountryRefTreatItemOfShops = new HashSet<RefTreatItemOfShop>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string CodeName128 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual RefAccessPermissionOfShop CountryRefAccessPermissionOfShop { get; set; }

        public virtual RefConditionToBuyScrapItem CountryRefConditionToBuyScrapItem { get; set; }

        public virtual RefConditionToSellPackageItem CountryRefConditionToSellPackageItem { get; set; }

        public virtual RefConditionToSellScrapItem CountryRefConditionToSellScrapItem { get; set; }

        public virtual ICollection<RefMappingShopGroup> CountryRefMappingShopGroups { get; set; }

        public virtual ICollection<RefMappingShopWithTab> CountryRefMappingShopWithTabs { get; set; }

        public virtual ICollection<RefPackageItem> CountryRefPackageItems { get; set; }

        public virtual ICollection<RefPricePolicyOfItem> CountryRefPricePolicyOfItems { get; set; }

        public virtual ICollection<RefRewardPolicyToBuyScrapItem> CountryRefRewardPolicyToBuyScrapItems { get; set; }

        public virtual ICollection<RefRewardPolicyToSellPackageItem> CountryRefRewardPolicyToSellPackageItems { get; set; }

        public virtual ICollection<RefRewardPolicyToSellScrapItem> CountryRefRewardPolicyToSellScrapItems { get; set; }

        public virtual ICollection<RefScrapOfPackageItem> CountryRefScrapOfPackageItems { get; set; }

        public virtual ICollection<RefShopGoods> CountryRefShopGoods { get; set; }

        public virtual ICollection<RefShopGroup> CountryRefShopGroups { get; set; }

        public virtual ICollection<RefShop> CountryRefShops { get; set; }

        public virtual ICollection<RefShopTabGroup> CountryRefShopTabGroups { get; set; }

        public virtual ICollection<RefShopTab> CountryRefShopTabs { get; set; }

        public virtual ICollection<RefTreatItemOfShop> CountryRefTreatItemOfShops { get; set; }

        #endregion

    }
}
