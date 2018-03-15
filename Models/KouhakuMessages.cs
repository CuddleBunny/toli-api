using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class KouhakuMessages : Entity
    {
        
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
