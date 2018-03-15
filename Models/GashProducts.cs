using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class GashProducts : Entity
    {
        
        public string ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public double? UnitPrice { get; set; }
        public int? Coin { get; set; }
        public byte? PointAvailable { get; set; }
        public byte? WalletAvailable { get; set; }
        public byte? TelecomAvailable { get; set; }
        public byte? RegularAvailable { get; set; }
        public byte EnableGift { get; set; }
        public DateTime GiftStartTime { get; set; }
        public DateTime GiftEndTime { get; set; }
    }
}
