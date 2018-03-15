using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Serials : Entity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Platform { get; set; }
        public string CharacterMessage { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}
