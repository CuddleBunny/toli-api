using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class GashGifts : Entity
    {
        
        public int GashId { get; set; }
        public string ItemType { get; set; }
        public int ItemId { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
    }
}
