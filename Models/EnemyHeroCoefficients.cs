using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class EnemyHeroCoefficients
    {
        public int Id { get; set; }
        public int QuestId { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public double AtkCoefficient { get; set; }
        public double HpCoefficient { get; set; }
        public double HealCoefficient { get; set; }
        public double SubjugationPointCoefficient { get; set; }
        public double ImmigrationProbability { get; set; }
        public double ArtInitialProbability { get; set; }
        public double ArtAdditionalProbability { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
