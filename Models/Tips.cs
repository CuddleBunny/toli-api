﻿using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Tips
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
