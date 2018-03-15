using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Areas : Entity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string HelpContents { get; set; }
        public int WorldId { get; set; }
        public int PrevAreaId { get; set; }
        public int BackgroundId { get; set; }
        public int? DrawPosX { get; set; }
        public int? DrawPosY { get; set; }
        public int AcquirementType { get; set; }
        public int EventType { get; set; }
        public byte HasConversation { get; set; }
        public int KeyItemId { get; set; }
        public int KeyItemQuantity { get; set; }
        public int UnlockDuration { get; set; }
        public short KeyholeImageId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte? IsMainBattle { get; set; }
    }
}
