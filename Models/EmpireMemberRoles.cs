using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class EmpireMemberRoles : Entity
    {
        
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int ImageId { get; set; }
    }
}
