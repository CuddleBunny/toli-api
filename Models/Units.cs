using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Units
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeriesId { get; set; }
        public int SeriesCharacterUniqId { get; set; }
        public int JobId { get; set; }
        public byte Sex { get; set; }
        public byte IsCostumed { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
