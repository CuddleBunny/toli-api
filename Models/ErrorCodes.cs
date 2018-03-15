using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class ErrorCodes : Entity
    {
        
        public string ErrorClass { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
