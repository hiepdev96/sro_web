using System;
using System.Collections.Generic;

namespace VsroShard.Shard_Repository.Entities
{
    public partial class RefServerEvent
    {
        public RefServerEvent()
        {
            #region Generated Constructor
            OwnerServerEventRefServerEventRewards = new HashSet<RefServerEventReward>();
            #endregion
        }

        #region Generated Properties
        public byte Service { get; set; }

        public int Id { get; set; }

        public byte DetectingTargetType { get; set; }

        public int DetectingTargetID { get; set; }

        public string Name { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public byte NotificationTypeDetectingTarget { get; set; }

        public byte AchievementConditionType { get; set; }

        public short AchievementConditionLevel { get; set; }

        public int AchievementCondition { get; set; }

        public byte RewardTarget { get; set; }

        public int GiveRewardDelayTime { get; set; }

        public byte ActivateClientUI { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<RefServerEventReward> OwnerServerEventRefServerEventRewards { get; set; }

        #endregion

    }
}
