using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Banners
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string LinkTo { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public int Platform { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
