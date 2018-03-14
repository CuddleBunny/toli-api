using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class RankingWorlds
    {
        public int Id { get; set; }
        public int? RankingId { get; set; }
        public int? WorldId { get; set; }
        public string Element { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Threshold { get; set; }
    }
}
