using System;
using System.Collections.Generic;

namespace ToLiAPI.Models
{
    public partial class Enemies
    {
        public int Id { get; set; }
        public int EnemyUnitId { get; set; }
        public string Name { get; set; }
        public int AttackType { get; set; }
        public int Size { get; set; }
        public int WeakAttackType { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int Turn { get; set; }
        public int FirstTurnMin { get; set; }
        public int FirstTurnMax { get; set; }
        public int Element { get; set; }
        public int Gald { get; set; }
        public int Mana { get; set; }
        public int EnemySkill1Id { get; set; }
        public int EnemySkill2Id { get; set; }
        public int EnemySkill3Id { get; set; }
        public int EnemySkill4Id { get; set; }
        public int EnemySkill5Id { get; set; }
        public int EnemySkill6Id { get; set; }
        public int EnemySkill7Id { get; set; }
        public int EnemySkill8Id { get; set; }
        public int EnemySkill9Id { get; set; }
        public int EnemySkill10Id { get; set; }
        public int EnemySkill11Id { get; set; }
        public int EnemySkill12Id { get; set; }
        public int EnemySkill13Id { get; set; }
        public int EnemySkill14Id { get; set; }
        public int EnemySkill15Id { get; set; }
        public int GuardCircle { get; set; }
        public int GuardTriangle { get; set; }
        public int GuardSquare { get; set; }
        public int GuardStar { get; set; }
        public int GuardTurn { get; set; }
        public int AtMostQuest { get; set; }
        public int PassiveSkillGroupId { get; set; }
        public short BgmId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
