using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class LimitupCharacterRequirements : Entity
    {
        
        public int RarityMax { get; set; }
        public int RarityMin { get; set; }
        public byte Slash { get; set; }
        public byte Botte { get; set; }
        public byte Shot { get; set; }
        public byte Blow { get; set; }
        public byte Magic { get; set; }
        public int EvolutionType { get; set; }
    }
}
