using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class AreaAvailables : Entity
    {
        
        public int AreaId { get; set; }
        public Areas Area { get; set; }
        public byte Wday { get; set; }
        public TimeSpan WdayStartAt { get; set; }
        public TimeSpan WdayEndAt { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
