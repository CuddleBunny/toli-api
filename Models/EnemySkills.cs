using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class EnemySkills : Entity
    {
        
        public string Name { get; set; }
        public int MoveEffect { get; set; }
        public int FireSound { get; set; }
        public int HitEffect { get; set; }
        public int HitSound { get; set; }
        public int SkillType { get; set; }
        public int InvokeCond { get; set; }
        public int? InvokeTarget { get; set; }
        public int? InvokeValue1 { get; set; }
        public int? InvokeValue2 { get; set; }
        public int? InvokeLimit { get; set; }
        public int? InvokeCooltime { get; set; }
        public int Effect { get; set; }
        public int? EffectValue1 { get; set; }
        public int? EffectValue2 { get; set; }
        public int? EffectValue3 { get; set; }
        public int? Target { get; set; }
        public int? TargetCond { get; set; }
        public int? TargetChange { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
