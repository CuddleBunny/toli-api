using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Worlds
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrevWorldId { get; set; }
        public int? BasePosX { get; set; }
        public int? BasePosY { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
