using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class TrainingCamp
    {
        public TrainingCamp()
        {
            #region Generated Constructor
            CampTrainingCampMembers = new HashSet<TrainingCampMember>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public byte Rank { get; set; }

        public int GraduateCount { get; set; }

        public int EvaluationPoint { get; set; }

        public DateTime LatestEvaluationDate { get; set; }

        public string CommentTitle { get; set; }

        public string Comment { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<TrainingCampMember> CampTrainingCampMembers { get; set; }

        #endregion

    }
}
