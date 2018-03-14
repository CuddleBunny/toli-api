using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Gachas
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public int PackCount { get; set; }
        public int Category { get; set; }
        public int ParentId { get; set; }
        public int FirstSrCount { get; set; }
        public int GuaranteedRarity { get; set; }
        public int NotDuplicateCount { get; set; }
        public byte IsListup { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string BannerTop { get; set; }
        public string BannerBg { get; set; }
        public int BannerNum { get; set; }
        public string BannerDescription { get; set; }
        public string BannerButton { get; set; }
        public int GachaRestrictId { get; set; }
        public int GachaTicketId { get; set; }
        public byte GachaElementWeightId { get; set; }
        public int? PrevGachaId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
