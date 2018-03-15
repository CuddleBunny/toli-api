using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class KouhakuBuffs : Entity
    {
        
        public string Description { get; set; }
        public int? BuffType { get; set; }
        public int? ElementKind { get; set; }
        public int? AttackKind { get; set; }
        public int? Scale { get; set; }
    }
}
