using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class HelpTexts : Entity
    {
        
        public int HelpCategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
