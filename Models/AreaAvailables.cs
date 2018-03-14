﻿using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class AreaAvailables
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public byte Wday { get; set; }
        public TimeSpan WdayStartAt { get; set; }
        public TimeSpan WdayEndAt { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
