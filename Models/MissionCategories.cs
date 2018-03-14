using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class MissionCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string BgImgPath { get; set; }
        public string LabelImgPath { get; set; }
        public string FrameImgPath { get; set; }
        public string EventIncentiveImgPath { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
