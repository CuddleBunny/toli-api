using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Skills : Entity
    {
        
        public string Description { get; set; }
        public int SkillType { get; set; }
        public int SkillEffectType { get; set; }
        public int? Value1 { get; set; }
        public int? Value2 { get; set; }
        public int? Value3 { get; set; }
        public int? Value4 { get; set; }
        public int? Value5 { get; set; }
        public int InitTurn { get; set; }
        public int MinTurn { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
