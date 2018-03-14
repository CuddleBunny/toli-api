using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class ArtEquipmentCharacters
    {
        public int Id { get; set; }
        public int ArtEquipmentId { get; set; }
        public int CharacterId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
