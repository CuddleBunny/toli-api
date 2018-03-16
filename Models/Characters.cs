using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Characters : Entity
    {
        
        public int UnitId { get; set; }
        public int LimitmaxUnitId { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public int VoicePack0Id { get; set; }
        public int VoicePack1Id { get; set; }
        public int LvMax { get; set; }
        public int LimitupMaxCnt { get; set; }
        public int LimitupSize { get; set; }
        public byte Rarity { get; set; }
        public int LevelupApType { get; set; }
        public int ApPrice { get; set; }
        public int AttackType { get; set; }
        public int GrowEarlyWeight { get; set; }
        public int GrowNormalWeight { get; set; }
        public int GrowLateWeight { get; set; }
        public int MotionId { get; set; }
        public int MotionAttack { get; set; }
        public int MotionDown { get; set; }
        public int MotionRun { get; set; }
        public int MotionDamage { get; set; }
        public int MotionWait { get; set; }
        public int LeaderSkillId { get; set; }
        public LeaderSkills LeaderSkill { get; set; }
        public string SkillName { get; set; }
        public int SkillId { get; set; }
        public Skills Skill { get; set; }
        public int Link { get; set; }
        public int SpArtId { get; set; }
        public int ArtId { get; set; }
        public Arts Art { get; set; }
        public int ArtGrowType { get; set; }
        public int Element { get; set; }
        public int HpInit { get; set; }
        public int HpMax { get; set; }
        public int AtkInit { get; set; }
        public int AtkMax { get; set; }
        public int HealInit { get; set; }
        public int HealMax { get; set; }
        public int AddonLimit { get; set; }
        public int ArtProbInit { get; set; }
        public int BonusCharacterId { get; set; }
        public int? EvolveCharacterId { get; set; }
        public Characters EvolveCharacter { get; set; }
        public int EvolutionType { get; set; }
        public int RequirementId { get; set; }
        public byte IsAvailable { get; set; }
        public byte DisplayFlg { get; set; }
        public int ImageId { get; set; }
        public int LimitmaxImageId { get; set; }
        public int BackgroundId { get; set; }
        public byte WildcardEnabled { get; set; }
        public int UnisonPartnerId { get; set; }
        public int UnisonExcellentArtId { get; set; }
        public int UnisonGreatArtId { get; set; }
        public int UnisonEffect { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
