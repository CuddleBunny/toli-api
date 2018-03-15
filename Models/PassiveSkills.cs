using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class PassiveSkills : Entity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int PassiveSkillEffectType { get; set; }
        public int? Value1 { get; set; }
        public int? Value2 { get; set; }
        public int? Value3 { get; set; }
        public int? Value4 { get; set; }
        public int? Value5 { get; set; }
        public int? Value6 { get; set; }
        public int Weight { get; set; }
        public byte DisplayFlag { get; set; }
    }
}
