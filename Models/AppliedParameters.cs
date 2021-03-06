﻿using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class AppliedParameters : Entity
    {
        
        public string AppliedType { get; set; }
        public double? Coefficient { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
