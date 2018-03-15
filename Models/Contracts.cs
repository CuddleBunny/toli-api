using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Contracts : Entity
    {
        
        public string Type { get; set; }
        public string ConditionType { get; set; }
        public int ConditionId { get; set; }
        public byte ResetOn { get; set; }
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Author { get; set; }
        public string Context { get; set; }
        public string ContractClearBy { get; set; }
        public string LinkTo { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}
