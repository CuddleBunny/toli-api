using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class QuestFirstTimeClearRewards
    {
        public int Id { get; set; }
        public int QuestId { get; set; }
        public string GiftableType { get; set; }
        public int GiftableId { get; set; }
        public short Quantity { get; set; }
    }
}
