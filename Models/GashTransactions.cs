using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class GashTransactions
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Cid { get; set; }
        public string Coid { get; set; }
        public string Rrn { get; set; }
        public string Cuid { get; set; }
        public string PaidType { get; set; }
        public double? Amount { get; set; }
        public string PayStatus { get; set; }
        public string Rcode { get; set; }
        public byte? Paid { get; set; }
        public byte? Received { get; set; }
        public byte? Settled { get; set; }
        public string ErpId { get; set; }
        public string PId { get; set; }
        public string PName { get; set; }
        public string Erpc { get; set; }
        public string RequestRaw { get; set; }
        public string ResultRaw { get; set; }
        public string InquireRequestRaw { get; set; }
        public string InquireResponseRaw { get; set; }
        public string SettleRequestRaw { get; set; }
        public string SettleResponseRaw { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
