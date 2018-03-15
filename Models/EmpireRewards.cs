using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class EmpireRewards : Entity
    {
        
        public string GiftableType { get; set; }
        public int GiftableId { get; set; }
        public int Quantity { get; set; }
        public int Interval { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
