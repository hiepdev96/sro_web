using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class TrainingCampSubMentorHonorPoint
    {
        public TrainingCampSubMentorHonorPoint()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CharID { get; set; }

        public int HonorPoint { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Char Char { get; set; }

        #endregion

    }
}
