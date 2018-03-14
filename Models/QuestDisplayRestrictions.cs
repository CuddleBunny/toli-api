using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class QuestDisplayRestrictions
    {
        public int Id { get; set; }
        public int QuestId { get; set; }
        public int PrevQuestId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
