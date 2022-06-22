using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class TrainingCampMember
    {
        public TrainingCampMember()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CampID { get; set; }

        public int CharID { get; set; }

        public int RefObjID { get; set; }

        public string CharName { get; set; }

        public DateTime JoinDate { get; set; }

        public byte MemberClass { get; set; }

        public byte CharJoinedLevel { get; set; }

        public byte CharCurLevel { get; set; }

        public byte CharMaxLevel { get; set; }

        public int HonorPoint { get; set; }

        #endregion

        #region Generated Relationships
        public virtual TrainingCamp CampTrainingCamp { get; set; }

        public virtual Char Char { get; set; }

        #endregion

    }
}
