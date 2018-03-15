using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class HelpCategories : Entity
    {
        
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
