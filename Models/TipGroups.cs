using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class TipGroups : Entity
    {
        
        public int Groups { get; set; }
        public int TipId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
