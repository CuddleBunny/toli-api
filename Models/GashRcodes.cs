﻿using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class GashRcodes : Entity
    {
        
        public int? Rcode { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
