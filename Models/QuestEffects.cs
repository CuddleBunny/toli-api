using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class QuestEffects
    {
        public int Id { get; set; }
        public int Element { get; set; }
        public int HpPercentage { get; set; }
        public int AtkPercentage { get; set; }
        public int HealPercentage { get; set; }
        public int RankingPointPercentage { get; set; }
        public int LeaderSkillId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
