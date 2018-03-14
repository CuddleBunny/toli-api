using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class DaisukiVideos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParamS { get; set; }
        public string ParamA { get; set; }
        public string ParamD { get; set; }
        public string ParamE { get; set; }
        public string ParamKey { get; set; }
        public int Platform { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
