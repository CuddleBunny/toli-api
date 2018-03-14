using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class TipGroups
    {
        public int Id { get; set; }
        public int Groups { get; set; }
        public int TipId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
