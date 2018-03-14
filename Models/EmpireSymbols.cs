using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class EmpireSymbols
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
