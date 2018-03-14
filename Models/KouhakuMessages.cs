using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class KouhakuMessages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
