using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class CharacterPassiveSkills : Entity
    {
        
        public int? CharacterId { get; set; }
        public int? PassiveSkillId { get; set; }
        public int? DefeatCount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
