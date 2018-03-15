using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class ContractRewards : Entity
    {
        
        public int ContractId { get; set; }
        public string GiftableType { get; set; }
        public int GiftableId { get; set; }
        public int Quantity { get; set; }
    }
}
