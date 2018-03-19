using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class ArtEquipmentCharacters : Entity
    {
        public int ArtEquipmentId { get; set; }
        public ArtEquipments ArtEquipment { get; set; }
        public int CharacterId { get; set; }
        public Characters Character { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
