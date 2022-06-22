using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class Items
    {
        public Items()
        {
            #region Generated Constructor
            ItemChests = new HashSet<Chest>();
            ItemInvCOs = new HashSet<InvCOS>();
            ItemInventories = new HashSet<Inventory>();
            ItemInventoryForAvatars = new HashSet<InventoryForAvatar>();
            ItemInventoryForLinkedStorages = new HashSet<InventoryForLinkedStorage>();
            ItemOpenMarkets = new HashSet<OpenMarket>();
            #endregion
        }

        #region Generated Properties
        public long Id64 { get; set; }

        public int RefItemID { get; set; }

        public byte? OptLevel { get; set; }

        public long? Variance { get; set; }

        public int Data { get; set; }

        public string CreaterName { get; set; }

        public byte MagParamNum { get; set; }

        public long? MagParam1 { get; set; }

        public long? MagParam2 { get; set; }

        public long? MagParam3 { get; set; }

        public long? MagParam4 { get; set; }

        public long? MagParam5 { get; set; }

        public long? MagParam6 { get; set; }

        public long? MagParam7 { get; set; }

        public long? MagParam8 { get; set; }

        public long? MagParam9 { get; set; }

        public long? MagParam10 { get; set; }

        public long? MagParam11 { get; set; }

        public long? MagParam12 { get; set; }

        public long Serial64 { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Chest> ItemChests { get; set; }

        public virtual ICollection<InvCOS> ItemInvCOs { get; set; }

        public virtual ICollection<Inventory> ItemInventories { get; set; }

        public virtual ICollection<InventoryForAvatar> ItemInventoryForAvatars { get; set; }

        public virtual ICollection<InventoryForLinkedStorage> ItemInventoryForLinkedStorages { get; set; }

        public virtual ItemPool ItemItemPool { get; set; }

        public virtual ICollection<OpenMarket> ItemOpenMarkets { get; set; }

        #endregion

    }
}
