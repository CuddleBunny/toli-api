using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class QuestTargets : Entity
    {
        
        public int EnemyId { get; set; }
        public string Description { get; set; }
        public int? Cond1 { get; set; }
        public int? Cond2 { get; set; }
        public string FirstReward1Type { get; set; }
        public int FirstReward1Id { get; set; }
        public int FirstReward1Quantity { get; set; }
        public string FirstReward2Type { get; set; }
        public int FirstReward2Id { get; set; }
        public int FirstReward2Quantity { get; set; }
        public string FirstReward3Type { get; set; }
        public int FirstReward3Id { get; set; }
        public int FirstReward3Quantity { get; set; }
        public string FirstReward4Type { get; set; }
        public int FirstReward4Id { get; set; }
        public int FirstReward4Quantity { get; set; }
        public string Reward1Type { get; set; }
        public int Reward1Id { get; set; }
        public int Reward1Quantity { get; set; }
        public string Reward2Type { get; set; }
        public int Reward2Id { get; set; }
        public int Reward2Quantity { get; set; }
        public string Reward3Type { get; set; }
        public int Reward3Id { get; set; }
        public int Reward3Quantity { get; set; }
        public string Reward4Type { get; set; }
        public int Reward4Id { get; set; }
        public int Reward4Quantity { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
