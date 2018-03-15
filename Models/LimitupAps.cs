﻿using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class LimitupAps : Entity
    {
        
        public byte Rarity { get; set; }
        public int Count { get; set; }
        public int Ap { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
