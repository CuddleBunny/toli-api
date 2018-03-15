using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Series : Entity
    {
        
        public string Name { get; set; }
        public string Abbrev { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
