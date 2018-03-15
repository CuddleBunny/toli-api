using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class SupporterSkills : Entity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupporterSkillEffectType { get; set; }
        public int? Value1 { get; set; }
        public int? Value2 { get; set; }
        public int? Value3 { get; set; }
        public int? Value4 { get; set; }
        public int? Value5 { get; set; }
    }
}
