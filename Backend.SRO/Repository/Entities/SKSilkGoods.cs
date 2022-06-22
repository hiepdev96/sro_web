using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class SKSilkGoods
    {
        public SKSilkGoods()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Id { get; set; }

        public string GoodsCode { get; set; }

        public string GoodsName { get; set; }

        public int SilkQuantity { get; set; }

        public int PointQuantity { get; set; }

        public int SilkPrice { get; set; }

        public byte Category { get; set; }

        public string CPName { get; set; }

        public DateTime RegDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
