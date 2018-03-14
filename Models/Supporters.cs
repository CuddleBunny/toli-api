using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Supporters
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public byte Element { get; set; }
        public byte Rarity { get; set; }
        public byte SupportType { get; set; }
        public int ApPrice { get; set; }
        public int SupporterSkillId { get; set; }
        public int ImageId { get; set; }
    }
}
