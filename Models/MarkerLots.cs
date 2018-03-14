using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class MarkerLots
    {
        public int Id { get; set; }
        public int? Table1Rate { get; set; }
        public int? Table2Rate { get; set; }
        public int? Table3Rate { get; set; }
        public int? T1Circle { get; set; }
        public int? T1Triangle { get; set; }
        public int? T1Square { get; set; }
        public int? T1Star { get; set; }
        public int? T1Heart { get; set; }
        public int? T2Circle { get; set; }
        public int? T2Triangle { get; set; }
        public int? T2Square { get; set; }
        public int? T2Star { get; set; }
        public int? T2Heart { get; set; }
        public int? T3Circle { get; set; }
        public int? T3Triangle { get; set; }
        public int? T3Square { get; set; }
        public int? T3Star { get; set; }
        public int? T3Heart { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
