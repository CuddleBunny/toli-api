﻿using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class ArtLevels : Entity
    {
        
        public int? GrowType { get; set; }
        public int? Lv { get; set; }
        public int? NextExp { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
