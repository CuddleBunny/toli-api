using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class PointGifts : Entity
    {
        
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Type { get; set; }
        public int Point { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
