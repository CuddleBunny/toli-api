using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class QuestCollects
    {
        public int Id { get; set; }
        public string Collectable1Type { get; set; }
        public int Collectable1Id { get; set; }
        public int Collectable1Quantity { get; set; }
        public string Collectable2Type { get; set; }
        public int Collectable2Id { get; set; }
        public int Collectable2Quantity { get; set; }
        public string Collectable3Type { get; set; }
        public int Collectable3Id { get; set; }
        public int Collectable3Quantity { get; set; }
        public string Collectable4Type { get; set; }
        public int Collectable4Id { get; set; }
        public int Collectable4Quantity { get; set; }
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
