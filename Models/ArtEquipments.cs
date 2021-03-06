﻿using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class ArtEquipments : Entity
    {
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public int ArtId { get; set; }
        public Arts Art { get; set; }
        public int ArtGroupId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
