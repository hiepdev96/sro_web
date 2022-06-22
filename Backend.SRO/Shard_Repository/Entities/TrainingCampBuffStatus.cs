using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class TrainingCampBuffStatus
    {
        public TrainingCampBuffStatus()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CampID { get; set; }

        public int RecipientCharID { get; set; }

        public byte BuffSlotIdx { get; set; }

        public int DonorCharID { get; set; }

        public DateTime StartingTime { get; set; }

        public int RemainBuffPoint { get; set; }

        public byte BuffType { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
