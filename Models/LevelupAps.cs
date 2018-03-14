using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class LevelupAps
    {
        public int Id { get; set; }
        public int LevelupApType { get; set; }
        public int Lv { get; set; }
        public int Ap { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
