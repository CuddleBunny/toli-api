using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Missions : Entity
    {
        
        public int MissionCategoryId { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public int Lv { get; set; }
        public int QuestId { get; set; }
        public int RequireMinutes { get; set; }
        public int RewardCountMin { get; set; }
        public int RewardCountMax { get; set; }
        public int RequiredCoin { get; set; }
        public int ApMin { get; set; }
        public int ApMax { get; set; }
        public int GaldMin { get; set; }
        public int GaldMax { get; set; }
        public string StartMessage { get; set; }
        public string StartMessageEn { get; set; }
        public string ConfirmMessage { get; set; }
        public string ConfirmMessageEn { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnMessageEn { get; set; }
        public string EndMessage { get; set; }
        public string EndMessageEn { get; set; }
        public int MissionRarityWeightId { get; set; }
        public int MissionSuccessId { get; set; }
        public string RewardDescription { get; set; }
        public string RewardDescriptionEn { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
