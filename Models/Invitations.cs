using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Invitations : Entity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int BannerId { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
