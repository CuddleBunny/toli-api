using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Arts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MoveEffect { get; set; }
        public int FireSound { get; set; }
        public int HitEffect { get; set; }
        public int HitSound { get; set; }
        public int ArtType { get; set; }
        public int EffectType { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }
        public int Value5 { get; set; }
        public int Value6 { get; set; }
        public int Value7 { get; set; }
        public int Voice { get; set; }
        public int InitProb { get; set; }
        public int IncreaseProb { get; set; }
        public int LvMax { get; set; }
        public int AdditionalLc { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
