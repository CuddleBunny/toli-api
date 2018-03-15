using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Tips : Entity
    {
        
        public string Text { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
