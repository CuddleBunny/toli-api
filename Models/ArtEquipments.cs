using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class ArtEquipments
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int ArtId { get; set; }
        public int ArtGroupId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
