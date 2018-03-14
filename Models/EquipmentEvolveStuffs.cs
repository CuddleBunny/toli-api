using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class EquipmentEvolveStuffs
    {
        public int Id { get; set; }
        public int? EquipmentId { get; set; }
        public int Num { get; set; }
        public int EvolveStuffId { get; set; }
        public int Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
