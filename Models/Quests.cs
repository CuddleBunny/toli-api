using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Quests
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public int PrevQuestId { get; set; }
        public int QuestType { get; set; }
        public int Act { get; set; }
        public int BattleCount { get; set; }
        public int SkillLearnFlyProb { get; set; }
        public int PassiveSkillLearnLimit { get; set; }
        public int SkillLearnBossFirstProb { get; set; }
        public int SkillLearnBossProb { get; set; }
        public int MaxClearCount { get; set; }
        public int MaxContinueCount { get; set; }
        public int BackgroundId { get; set; }
        public int MarkerLotId { get; set; }
        public int TipGroupId { get; set; }
        public int TargetableId { get; set; }
        public string TargetableType { get; set; }
        public int BgmNormalId { get; set; }
        public int BgmBossId { get; set; }
        public short SerialCodeDropRate { get; set; }
        public short DefeatCountMultiplier { get; set; }
        public int RequirementId { get; set; }
        public byte UnisonEnabled { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
