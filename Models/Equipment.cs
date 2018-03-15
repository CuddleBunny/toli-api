using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Equipment : Entity
    {
        
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public int Group { get; set; }
        public int ImageId { get; set; }
        public int EvolveCount { get; set; }
        public byte Rarity { get; set; }
        public byte EquipmentType { get; set; }
        public byte EquipmentSubtype { get; set; }
        public byte AttackType { get; set; }
        public byte Element { get; set; }
        public byte ElementSub { get; set; }
        public int GaldPrice { get; set; }
        public int GaldExpense { get; set; }
        public int MaterialExp { get; set; }
        public int GrowEarlyWeight { get; set; }
        public int GrowNormalWeight { get; set; }
        public int GrowLateWeight { get; set; }
        public int LvMax { get; set; }
        public int LimitbreakGrow { get; set; }
        public int LimitbreakStuffEquipmentId { get; set; }
        public int LimitbreakLv { get; set; }
        public byte IsBroken { get; set; }
        public int PassiveSkill1Id { get; set; }
        public int PassiveSkill2Id { get; set; }
        public int HpInit { get; set; }
        public int HpMax { get; set; }
        public int AtkInit { get; set; }
        public int AtkMax { get; set; }
        public int HealInit { get; set; }
        public int HealMax { get; set; }
        public int Link { get; set; }
        public int? EvolveEquipmentId { get; set; }
        public byte IsMaterialOfEvolution { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
