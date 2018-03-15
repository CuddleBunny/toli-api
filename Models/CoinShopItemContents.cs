using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class CoinShopItemContents : Entity
    {
        
        public int CoinShopItemId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
