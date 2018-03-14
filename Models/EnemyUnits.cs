using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class EnemyUnits
    {
        public int Id { get; set; }
        public int RefId { get; set; }
        public int DiffId { get; set; }
        public int HitFrame { get; set; }
        public int HitEffect { get; set; }
        public int HitSound { get; set; }
        public int? ScaleMin { get; set; }
        public int? ScaleMax { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
