using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class QuestEffectCharacters : Entity
    {
        
        public int QuestId { get; set; }
        public int CharacterId { get; set; }
        public int QuestEffectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
