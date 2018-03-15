using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class CharacterResultMessages : Entity
    {
        
        public int CharacterId { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
