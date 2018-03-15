using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ToLiAPI.Models
{
    public class Entity {
        public int Id { get; set; }
    }

    public class ConstEntity {
        public String Id { get; set; }
    }

    public partial class ToLiDbContext : DbContext
    {
        public virtual DbSet<AppliedParameters> AppliedParameters { get; set; }
        public virtual DbSet<AreaAvailables> AreaAvailables { get; set; }
        public virtual DbSet<AreaBonuses> AreaBonuses { get; set; }
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<ArtEquipmentCharacters> ArtEquipmentCharacters { get; set; }
        public virtual DbSet<ArtEquipments> ArtEquipments { get; set; }
        public virtual DbSet<ArtLevels> ArtLevels { get; set; }
        public virtual DbSet<Arts> Arts { get; set; }
        public virtual DbSet<Banners> Banners { get; set; }
        public virtual DbSet<CharacterPassiveSkills> CharacterPassiveSkills { get; set; }
        public virtual DbSet<CharacterResultMessages> CharacterResultMessages { get; set; }
        public virtual DbSet<Characters> Characters { get; set; }
        public virtual DbSet<CoinShopItemContents> CoinShopItemContents { get; set; }
        public virtual DbSet<CoinShopItems> CoinShopItems { get; set; }
        public virtual DbSet<ConstBattles> ConstBattles { get; set; }
        public virtual DbSet<ConstBgScroll> ConstBgScroll { get; set; }
        public virtual DbSet<ConstChangeCostume> ConstChangeCostume { get; set; }
        public virtual DbSet<ConstCharacters> ConstCharacters { get; set; }
        public virtual DbSet<ConstCharges> ConstCharges { get; set; }
        public virtual DbSet<ConstDecks> ConstDecks { get; set; }
        public virtual DbSet<ConstEquipmentsortfilter> ConstEquipmentsortfilter { get; set; }
        public virtual DbSet<ConstFriend> ConstFriend { get; set; }
        public virtual DbSet<ConstGamedatas> ConstGamedatas { get; set; }
        public virtual DbSet<ConstGashaConfiguration> ConstGashaConfiguration { get; set; }
        public virtual DbSet<ConstGashaPerformancePatterns> ConstGashaPerformancePatterns { get; set; }
        public virtual DbSet<ConstGashaPerformanceRate> ConstGashaPerformanceRate { get; set; }
        public virtual DbSet<ConstGashaPerformanceResultScene> ConstGashaPerformanceResultScene { get; set; }
        public virtual DbSet<ConstGashaPerformanceTutorialPatterns> ConstGashaPerformanceTutorialPatterns { get; set; }
        public virtual DbSet<ConstGashaSeTable> ConstGashaSeTable { get; set; }
        public virtual DbSet<ConstGift> ConstGift { get; set; }
        public virtual DbSet<ConstItemExchange> ConstItemExchange { get; set; }
        public virtual DbSet<ConstMenus> ConstMenus { get; set; }
        public virtual DbSet<ConstMypage> ConstMypage { get; set; }
        public virtual DbSet<ConstPush> ConstPush { get; set; }
        public virtual DbSet<ConstSystems> ConstSystems { get; set; }
        public virtual DbSet<ConstTexts> ConstTexts { get; set; }
        public virtual DbSet<ConstUnison> ConstUnison { get; set; }
        public virtual DbSet<ConstUserdatas> ConstUserdatas { get; set; }
        public virtual DbSet<ConstUserTeam> ConstUserTeam { get; set; }
        public virtual DbSet<ContractRewards> ContractRewards { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<DaisukiVideos> DaisukiVideos { get; set; }
        public virtual DbSet<EmpireMemberRoles> EmpireMemberRoles { get; set; }
        public virtual DbSet<EmpireRewards> EmpireRewards { get; set; }
        public virtual DbSet<EmpireSymbols> EmpireSymbols { get; set; }
        public virtual DbSet<Enemies> Enemies { get; set; }
        public virtual DbSet<EnemyHeroBehaviorSkills> EnemyHeroBehaviorSkills { get; set; }
        public virtual DbSet<EnemyHeroCoefficients> EnemyHeroCoefficients { get; set; }
        public virtual DbSet<EnemySkills> EnemySkills { get; set; }
        public virtual DbSet<EnemyUnits> EnemyUnits { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentEvolveStuffs> EquipmentEvolveStuffs { get; set; }
        public virtual DbSet<ErrorCodes> ErrorCodes { get; set; }
        public virtual DbSet<Gachas> Gachas { get; set; }
        public virtual DbSet<GashGifts> GashGifts { get; set; }
        public virtual DbSet<GashProducts> GashProducts { get; set; }
        public virtual DbSet<GashRcodes> GashRcodes { get; set; }
        public virtual DbSet<GashTransactions> GashTransactions { get; set; }
        public virtual DbSet<GuestCharacters> GuestCharacters { get; set; }
        public virtual DbSet<HelpCategories> HelpCategories { get; set; }
        public virtual DbSet<HelpTexts> HelpTexts { get; set; }
        public virtual DbSet<Invitations> Invitations { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<KouhakuBuffs> KouhakuBuffs { get; set; }
        public virtual DbSet<KouhakuMessages> KouhakuMessages { get; set; }
        public virtual DbSet<LeaderSkills> LeaderSkills { get; set; }
        public virtual DbSet<LevelupAps> LevelupAps { get; set; }
        public virtual DbSet<LimitupAps> LimitupAps { get; set; }
        public virtual DbSet<LimitupCharacterRequirements> LimitupCharacterRequirements { get; set; }
        public virtual DbSet<MarkerLots> MarkerLots { get; set; }
        public virtual DbSet<MissionCategories> MissionCategories { get; set; }
        public virtual DbSet<Missions> Missions { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PassiveSkills> PassiveSkills { get; set; }
        public virtual DbSet<PointGifts> PointGifts { get; set; }
        public virtual DbSet<QuestCollects> QuestCollects { get; set; }
        public virtual DbSet<QuestDisplayRestrictions> QuestDisplayRestrictions { get; set; }
        public virtual DbSet<QuestEffectCharacters> QuestEffectCharacters { get; set; }
        public virtual DbSet<QuestEffects> QuestEffects { get; set; }
        public virtual DbSet<QuestFirstTimeClearRewards> QuestFirstTimeClearRewards { get; set; }
        public virtual DbSet<Quests> Quests { get; set; }
        public virtual DbSet<QuestTargets> QuestTargets { get; set; }
        public virtual DbSet<RankingWorlds> RankingWorlds { get; set; }
        public virtual DbSet<Serials> Serials { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<Supporters> Supporters { get; set; }
        public virtual DbSet<SupporterSkills> SupporterSkills { get; set; }
        public virtual DbSet<TipGroups> TipGroups { get; set; }
        public virtual DbSet<Tips> Tips { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Worlds> Worlds { get; set; }

        public ToLiDbContext(DbContextOptions<ToLiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppliedParameters>(entity =>
            {
                entity.ToTable("applied_parameters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliedType)
                    .HasColumnName("applied_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Coefficient).HasColumnName("coefficient");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AreaAvailables>(entity =>
            {
                entity.ToTable("area_availables");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wday).HasColumnName("wday");

                entity.Property(e => e.WdayEndAt).HasColumnName("wday_end_at");

                entity.Property(e => e.WdayStartAt).HasColumnName("wday_start_at");
            });

            modelBuilder.Entity<AreaBonuses>(entity =>
            {
                entity.ToTable("area_bonuses");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BonusType).HasColumnName("bonus_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wday).HasColumnName("wday");

                entity.Property(e => e.WdayEndAt).HasColumnName("wday_end_at");

                entity.Property(e => e.WdayStartAt).HasColumnName("wday_start_at");
            });

            modelBuilder.Entity<Areas>(entity =>
            {
                entity.ToTable("areas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcquirementType)
                    .HasColumnName("acquirement_type")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.BackgroundId).HasColumnName("background_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DrawPosX)
                    .HasColumnName("draw_pos_x")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DrawPosY)
                    .HasColumnName("draw_pos_y")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EventType)
                    .HasColumnName("event_type")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HasConversation)
                    .HasColumnName("has_conversation")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.HelpContents)
                    .IsRequired()
                    .HasColumnName("help_contents")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsMainBattle)
                    .HasColumnName("is_main_battle")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.KeyItemId)
                    .HasColumnName("key_item_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.KeyItemQuantity)
                    .HasColumnName("key_item_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.KeyholeImageId)
                    .HasColumnName("keyhole_image_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PrevAreaId)
                    .HasColumnName("prev_area_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UnlockDuration)
                    .HasColumnName("unlock_duration")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorldId).HasColumnName("world_id");
            });

            modelBuilder.Entity<ArtEquipmentCharacters>(entity =>
            {
                entity.ToTable("art_equipment_characters");

                entity.HasIndex(e => new { e.ArtEquipmentId, e.CharacterId })
                    .HasName("art_equipment_characters_art_equipment_id_and_character_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtEquipmentId).HasColumnName("art_equipment_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ArtEquipments>(entity =>
            {
                entity.ToTable("art_equipments");

                entity.HasIndex(e => new { e.EquipmentId, e.ArtId })
                    .HasName("art_equipments_equipment_id_and_art_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtGroupId)
                    .HasColumnName("art_group_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ArtId).HasColumnName("art_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ArtLevels>(entity =>
            {
                entity.ToTable("art_levels");

                entity.HasIndex(e => new { e.GrowType, e.NextExp })
                    .HasName("art_levels_grow_type_and_next_exp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrowType).HasColumnName("grow_type");

                entity.Property(e => e.Lv).HasColumnName("lv");

                entity.Property(e => e.NextExp).HasColumnName("next_exp");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Arts>(entity =>
            {
                entity.ToTable("arts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalLc)
                    .HasColumnName("additional_lc")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ArtType).HasColumnName("art_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EffectType)
                    .HasColumnName("effect_type")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FireSound)
                    .HasColumnName("fire_sound")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HitEffect)
                    .HasColumnName("hit_effect")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HitSound)
                    .HasColumnName("hit_sound")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncreaseProb)
                    .HasColumnName("increase_prob")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InitProb)
                    .HasColumnName("init_prob")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LvMax).HasColumnName("lv_max");

                entity.Property(e => e.MoveEffect)
                    .HasColumnName("move_effect")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value1)
                    .HasColumnName("value1")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Value6)
                    .HasColumnName("value6")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Value7)
                    .HasColumnName("value7")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Voice)
                    .HasColumnName("voice")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Banners>(entity =>
            {
                entity.ToTable("banners");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkTo)
                    .IsRequired()
                    .HasColumnName("link_to")
                    .HasMaxLength(255);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasMaxLength(255);

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CharacterPassiveSkills>(entity =>
            {
                entity.ToTable("character_passive_skills");

                entity.HasIndex(e => e.CharacterId)
                    .HasName("character_passive_skills_character_id");

                entity.HasIndex(e => e.PassiveSkillId)
                    .HasName("character_passive_skills_passive_skill_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefeatCount).HasColumnName("defeat_count");

                entity.Property(e => e.PassiveSkillId).HasColumnName("passive_skill_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CharacterResultMessages>(entity =>
            {
                entity.ToTable("character_result_messages");

                entity.HasIndex(e => e.CharacterId)
                    .HasName("character_result_messages_character_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Characters>(entity =>
            {
                entity.ToTable("characters");

                entity.HasIndex(e => e.UnitId)
                    .HasName("characters_unit_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddonLimit)
                    .HasColumnName("addon_limit")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ApPrice).HasColumnName("ap_price");

                entity.Property(e => e.ArtGrowType)
                    .HasColumnName("art_grow_type")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.ArtId)
                    .HasColumnName("art_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ArtProbInit)
                    .HasColumnName("art_prob_init")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.AtkInit).HasColumnName("atk_init");

                entity.Property(e => e.AtkMax).HasColumnName("atk_max");

                entity.Property(e => e.AttackType).HasColumnName("attack_type");

                entity.Property(e => e.BackgroundId)
                    .HasColumnName("background_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.BonusCharacterId).HasColumnName("bonus_character_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayFlg)
                    .HasColumnName("display_flg")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Element).HasColumnName("element");

                entity.Property(e => e.EvolutionType)
                    .HasColumnName("evolution_type")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EvolveCharacterId).HasColumnName("evolve_character_id");

                entity.Property(e => e.GrowEarlyWeight)
                    .HasColumnName("grow_early_weight")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GrowLateWeight)
                    .HasColumnName("grow_late_weight")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GrowNormalWeight)
                    .HasColumnName("grow_normal_weight")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HealInit).HasColumnName("heal_init");

                entity.Property(e => e.HealMax).HasColumnName("heal_max");

                entity.Property(e => e.HpInit).HasColumnName("hp_init");

                entity.Property(e => e.HpMax).HasColumnName("hp_max");

                entity.Property(e => e.ImageId)
                    .HasColumnName("image_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsAvailable).HasColumnName("is_available");

                entity.Property(e => e.LeaderSkillId)
                    .HasColumnName("leader_skill_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LevelupApType).HasColumnName("levelup_ap_type");

                entity.Property(e => e.LimitmaxImageId)
                    .HasColumnName("limitmax_image_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LimitmaxUnitId)
                    .HasColumnName("limitmax_unit_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LimitupMaxCnt)
                    .HasColumnName("limitup_max_cnt")
                    .HasDefaultValueSql("('4')");

                entity.Property(e => e.LimitupSize)
                    .HasColumnName("limitup_size")
                    .HasDefaultValueSql("('5')");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LvMax).HasColumnName("lv_max");

                entity.Property(e => e.MotionAttack).HasColumnName("motion_attack");

                entity.Property(e => e.MotionDamage).HasColumnName("motion_damage");

                entity.Property(e => e.MotionDown).HasColumnName("motion_down");

                entity.Property(e => e.MotionId).HasColumnName("motion_id");

                entity.Property(e => e.MotionRun).HasColumnName("motion_run");

                entity.Property(e => e.MotionWait).HasColumnName("motion_wait");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.RequirementId)
                    .HasColumnName("requirement_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SkillId)
                    .HasColumnName("skill_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnName("skill_name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SpArtId)
                    .HasColumnName("sp_art_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UnisonEffect)
                    .HasColumnName("unison_effect")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UnisonExcellentArtId)
                    .HasColumnName("unison_excellent_art_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UnisonGreatArtId)
                    .HasColumnName("unison_great_art_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UnisonPartnerId)
                    .HasColumnName("unison_partner_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.VoicePack0Id).HasColumnName("voice_pack_0_id");

                entity.Property(e => e.VoicePack1Id).HasColumnName("voice_pack_1_id");

                entity.Property(e => e.WildcardEnabled)
                    .HasColumnName("wildcard_enabled")
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<CoinShopItemContents>(entity =>
            {
                entity.ToTable("coin_shop_item_contents");

                entity.HasIndex(e => e.CoinShopItemId)
                    .HasName("coin_shop_item_contents_coin_shop_item_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoinShopItemId).HasColumnName("coin_shop_item_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CoinShopItems>(entity =>
            {
                entity.ToTable("coin_shop_items");

                entity.HasIndex(e => new { e.StartAt, e.EndAt })
                    .HasName("coin_shop_items_start_at_and_end_at");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.SalesLimit)
                    .HasColumnName("sales_limit")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ConstBattles>(entity =>
            {
                entity.ToTable("const_battles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstBgScroll>(entity =>
            {
                entity.ToTable("const_bg_scroll");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstChangeCostume>(entity =>
            {
                entity.ToTable("const_change_costume");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstCharacters>(entity =>
            {
                entity.ToTable("const_characters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstCharges>(entity =>
            {
                entity.ToTable("const_charges");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstDecks>(entity =>
            {
                entity.ToTable("const_decks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstEquipmentsortfilter>(entity =>
            {
                entity.ToTable("const_equipmentsortfilter");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstFriend>(entity =>
            {
                entity.ToTable("const_friend");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstGamedatas>(entity =>
            {
                entity.ToTable("const_gamedatas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstGashaConfiguration>(entity =>
            {
                entity.ToTable("const_gasha_configuration");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstGashaPerformancePatterns>(entity =>
            {
                entity.ToTable("const_gasha_performance_patterns");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstGashaPerformanceRate>(entity =>
            {
                entity.ToTable("const_gasha_performance_rate");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstGashaPerformanceResultScene>(entity =>
            {
                entity.ToTable("const_gasha_performance_result_scene");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstGashaPerformanceTutorialPatterns>(entity =>
            {
                entity.ToTable("const_gasha_performance_tutorial_patterns");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstGashaSeTable>(entity =>
            {
                entity.ToTable("const_gasha_se_table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstGift>(entity =>
            {
                entity.ToTable("const_gift");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstItemExchange>(entity =>
            {
                entity.ToTable("const_item_exchange");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstMenus>(entity =>
            {
                entity.ToTable("const_menus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstMypage>(entity =>
            {
                entity.ToTable("const_mypage");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstPush>(entity =>
            {
                entity.ToTable("const_push");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstSystems>(entity =>
            {
                entity.ToTable("const_systems");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstTexts>(entity =>
            {
                entity.ToTable("const_texts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ConstUnison>(entity =>
            {
                entity.ToTable("const_unison");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstUserdatas>(entity =>
            {
                entity.ToTable("const_userdatas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ConstUserTeam>(entity =>
            {
                entity.ToTable("const_user_team");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ContractRewards>(entity =>
            {
                entity.ToTable("contract_rewards");

                entity.HasIndex(e => e.ContractId)
                    .HasName("contract_rewards_contract_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GiftableId)
                    .HasColumnName("giftable_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GiftableType)
                    .IsRequired()
                    .HasColumnName("giftable_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Contracts>(entity =>
            {
                entity.ToTable("contracts");

                entity.HasIndex(e => new { e.StartAt, e.EndAt })
                    .HasName("contracts_start_at_and_end_at");

                entity.HasIndex(e => new { e.StartAt, e.ExpiredAt })
                    .HasName("contracts_start_at_and_expired_at");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnName("author")
                    .HasMaxLength(40);

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.ConditionType)
                    .IsRequired()
                    .HasColumnName("condition_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasColumnName("context")
                    .HasMaxLength(255);

                entity.Property(e => e.ContractClearBy)
                    .IsRequired()
                    .HasColumnName("contract_clear_by")
                    .HasMaxLength(255);

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpiredAt)
                    .HasColumnName("expired_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkTo)
                    .HasColumnName("link_to")
                    .HasMaxLength(255);

                entity.Property(e => e.ResetOn).HasColumnName("reset_on");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(40);

                entity.Property(e => e.TitleEn)
                    .IsRequired()
                    .HasColumnName("title_en")
                    .HasMaxLength(40);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DaisukiVideos>(entity =>
            {
                entity.ToTable("daisuki_videos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ParamA)
                    .IsRequired()
                    .HasColumnName("param_a")
                    .HasColumnType("ntext");

                entity.Property(e => e.ParamD)
                    .IsRequired()
                    .HasColumnName("param_d")
                    .HasColumnType("ntext");

                entity.Property(e => e.ParamE)
                    .HasColumnName("param_e")
                    .HasColumnType("ntext");

                entity.Property(e => e.ParamKey)
                    .IsRequired()
                    .HasColumnName("param_key")
                    .HasColumnType("ntext");

                entity.Property(e => e.ParamS)
                    .IsRequired()
                    .HasColumnName("param_s")
                    .HasColumnType("ntext");

                entity.Property(e => e.Platform).HasColumnName("platform");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EmpireMemberRoles>(entity =>
            {
                entity.ToTable("empire_member_roles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageId)
                    .HasColumnName("image_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EmpireRewards>(entity =>
            {
                entity.ToTable("empire_rewards");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.GiftableId).HasColumnName("giftable_id");

                entity.Property(e => e.GiftableType)
                    .IsRequired()
                    .HasColumnName("giftable_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Interval)
                    .HasColumnName("interval")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EmpireSymbols>(entity =>
            {
                entity.ToTable("empire_symbols");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Enemies>(entity =>
            {
                entity.ToTable("enemies");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtMostQuest)
                    .HasColumnName("at_most_quest")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.AttackType).HasColumnName("attack_type");

                entity.Property(e => e.BgmId)
                    .HasColumnName("bgm_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Damage).HasColumnName("damage");

                entity.Property(e => e.Defence).HasColumnName("defence");

                entity.Property(e => e.Element).HasColumnName("element");

                entity.Property(e => e.EnemySkill10Id)
                    .HasColumnName("enemy_skill10_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill11Id)
                    .HasColumnName("enemy_skill11_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill12Id)
                    .HasColumnName("enemy_skill12_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill13Id)
                    .HasColumnName("enemy_skill13_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill14Id)
                    .HasColumnName("enemy_skill14_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill15Id)
                    .HasColumnName("enemy_skill15_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill1Id)
                    .HasColumnName("enemy_skill1_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill2Id)
                    .HasColumnName("enemy_skill2_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill3Id)
                    .HasColumnName("enemy_skill3_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill4Id)
                    .HasColumnName("enemy_skill4_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill5Id)
                    .HasColumnName("enemy_skill5_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill6Id)
                    .HasColumnName("enemy_skill6_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill7Id)
                    .HasColumnName("enemy_skill7_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill8Id)
                    .HasColumnName("enemy_skill8_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill9Id)
                    .HasColumnName("enemy_skill9_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemyUnitId).HasColumnName("enemy_unit_id");

                entity.Property(e => e.FirstTurnMax).HasColumnName("first_turn_max");

                entity.Property(e => e.FirstTurnMin).HasColumnName("first_turn_min");

                entity.Property(e => e.Gald).HasColumnName("gald");

                entity.Property(e => e.GuardCircle)
                    .HasColumnName("guard_circle")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GuardSquare)
                    .HasColumnName("guard_square")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GuardStar)
                    .HasColumnName("guard_star")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GuardTriangle)
                    .HasColumnName("guard_triangle")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GuardTurn)
                    .HasColumnName("guard_turn")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Mana)
                    .HasColumnName("mana")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PassiveSkillGroupId)
                    .HasColumnName("passive_skill_group_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Turn).HasColumnName("turn");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.WeakAttackType)
                    .HasColumnName("weak_attack_type")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<EnemyHeroBehaviorSkills>(entity =>
            {
                entity.ToTable("enemy_hero_behavior_skills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");

                entity.Property(e => e.EnemySkill10Id)
                    .HasColumnName("enemy_skill10_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill11Id)
                    .HasColumnName("enemy_skill11_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill12Id)
                    .HasColumnName("enemy_skill12_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill13Id)
                    .HasColumnName("enemy_skill13_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill14Id)
                    .HasColumnName("enemy_skill14_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill15Id)
                    .HasColumnName("enemy_skill15_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill1Id)
                    .HasColumnName("enemy_skill1_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill2Id)
                    .HasColumnName("enemy_skill2_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill3Id)
                    .HasColumnName("enemy_skill3_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill4Id)
                    .HasColumnName("enemy_skill4_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill5Id)
                    .HasColumnName("enemy_skill5_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill6Id)
                    .HasColumnName("enemy_skill6_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill7Id)
                    .HasColumnName("enemy_skill7_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill8Id)
                    .HasColumnName("enemy_skill8_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EnemySkill9Id)
                    .HasColumnName("enemy_skill9_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EnemyHeroCoefficients>(entity =>
            {
                entity.ToTable("enemy_hero_coefficients");

                entity.HasIndex(e => e.QuestId)
                    .HasName("enemy_hero_coefficients_quest_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtAdditionalProbability)
                    .HasColumnName("art_additional_probability")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.ArtInitialProbability)
                    .HasColumnName("art_initial_probability")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.AtkCoefficient)
                    .HasColumnName("atk_coefficient")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.HealCoefficient)
                    .HasColumnName("heal_coefficient")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.HpCoefficient)
                    .HasColumnName("hp_coefficient")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.ImmigrationProbability)
                    .HasColumnName("immigration_probability")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.MaxLv)
                    .HasColumnName("max_lv")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MinLv)
                    .HasColumnName("min_lv")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.SubjugationPointCoefficient)
                    .HasColumnName("subjugation_point_coefficient")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EnemySkills>(entity =>
            {
                entity.ToTable("enemy_skills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.EffectValue1).HasColumnName("effect_value1");

                entity.Property(e => e.EffectValue2).HasColumnName("effect_value2");

                entity.Property(e => e.EffectValue3).HasColumnName("effect_value3");

                entity.Property(e => e.FireSound).HasColumnName("fire_sound");

                entity.Property(e => e.HitEffect).HasColumnName("hit_effect");

                entity.Property(e => e.HitSound).HasColumnName("hit_sound");

                entity.Property(e => e.InvokeCond).HasColumnName("invoke_cond");

                entity.Property(e => e.InvokeCooltime).HasColumnName("invoke_cooltime");

                entity.Property(e => e.InvokeLimit).HasColumnName("invoke_limit");

                entity.Property(e => e.InvokeTarget).HasColumnName("invoke_target");

                entity.Property(e => e.InvokeValue1).HasColumnName("invoke_value1");

                entity.Property(e => e.InvokeValue2).HasColumnName("invoke_value2");

                entity.Property(e => e.MoveEffect).HasColumnName("move_effect");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.SkillType).HasColumnName("skill_type");

                entity.Property(e => e.Target).HasColumnName("target");

                entity.Property(e => e.TargetChange).HasColumnName("target_change");

                entity.Property(e => e.TargetCond).HasColumnName("target_cond");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EnemyUnits>(entity =>
            {
                entity.ToTable("enemy_units");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiffId).HasColumnName("diff_id");

                entity.Property(e => e.HitEffect).HasColumnName("hit_effect");

                entity.Property(e => e.HitFrame).HasColumnName("hit_frame");

                entity.Property(e => e.HitSound).HasColumnName("hit_sound");

                entity.Property(e => e.RefId).HasColumnName("ref_id");

                entity.Property(e => e.ScaleMax)
                    .HasColumnName("scale_max")
                    .HasDefaultValueSql("('100')");

                entity.Property(e => e.ScaleMin)
                    .HasColumnName("scale_min")
                    .HasDefaultValueSql("('100')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.ToTable("equipment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtkInit).HasColumnName("atk_init");

                entity.Property(e => e.AtkMax).HasColumnName("atk_max");

                entity.Property(e => e.AttackType).HasColumnName("attack_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Element).HasColumnName("element");

                entity.Property(e => e.ElementSub).HasColumnName("element_sub");

                entity.Property(e => e.EquipmentSubtype).HasColumnName("equipment_subtype");

                entity.Property(e => e.EquipmentType).HasColumnName("equipment_type");

                entity.Property(e => e.EvolveCount).HasColumnName("evolve_count");

                entity.Property(e => e.EvolveEquipmentId).HasColumnName("evolve_equipment_id");

                entity.Property(e => e.GaldExpense).HasColumnName("gald_expense");

                entity.Property(e => e.GaldPrice).HasColumnName("gald_price");

                entity.Property(e => e.Group).HasColumnName("group");

                entity.Property(e => e.GrowEarlyWeight)
                    .HasColumnName("grow_early_weight")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GrowLateWeight)
                    .HasColumnName("grow_late_weight")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GrowNormalWeight)
                    .HasColumnName("grow_normal_weight")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HealInit).HasColumnName("heal_init");

                entity.Property(e => e.HealMax).HasColumnName("heal_max");

                entity.Property(e => e.HpInit).HasColumnName("hp_init");

                entity.Property(e => e.HpMax).HasColumnName("hp_max");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.IsBroken)
                    .HasColumnName("is_broken")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsMaterialOfEvolution)
                    .HasColumnName("is_material_of_evolution")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LimitbreakGrow).HasColumnName("limitbreak_grow");

                entity.Property(e => e.LimitbreakLv)
                    .HasColumnName("limitbreak_lv")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LimitbreakStuffEquipmentId)
                    .HasColumnName("limitbreak_stuff_equipment_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Link).HasColumnName("link");

                entity.Property(e => e.LvMax).HasColumnName("lv_max");

                entity.Property(e => e.MaterialExp).HasColumnName("material_exp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.PassiveSkill1Id)
                    .HasColumnName("passive_skill1_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PassiveSkill2Id)
                    .HasColumnName("passive_skill2_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EquipmentEvolveStuffs>(entity =>
            {
                entity.ToTable("equipment_evolve_stuffs");

                entity.HasIndex(e => e.EquipmentId)
                    .HasName("equipment_evolve_stuffs_equipment_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.EvolveStuffId).HasColumnName("evolve_stuff_id");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ErrorCodes>(entity =>
            {
                entity.ToTable("error_codes");

                entity.HasIndex(e => e.ErrorClass)
                    .HasName("error_codes_error_class");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("description_en")
                    .HasColumnType("ntext");

                entity.Property(e => e.ErrorClass)
                    .IsRequired()
                    .HasColumnName("error_class")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Gachas>(entity =>
            {
                entity.ToTable("gachas");

                entity.HasIndex(e => e.GachaRestrictId)
                    .HasName("gachas_gacha_restrict_id");

                entity.HasIndex(e => e.PrevGachaId)
                    .HasName("gachas_prev_gacha_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BannerBg)
                    .IsRequired()
                    .HasColumnName("banner_bg")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BannerButton)
                    .IsRequired()
                    .HasColumnName("banner_button")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BannerDescription)
                    .HasColumnName("banner_description")
                    .HasColumnType("ntext");

                entity.Property(e => e.BannerNum)
                    .HasColumnName("banner_num")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.BannerTop)
                    .IsRequired()
                    .HasColumnName("banner_top")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstSrCount)
                    .HasColumnName("first_sr_count")
                    .HasDefaultValueSql("('5')");

                entity.Property(e => e.GachaElementWeightId)
                    .HasColumnName("gacha_element_weight_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GachaRestrictId)
                    .HasColumnName("gacha_restrict_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GachaTicketId)
                    .HasColumnName("gacha_ticket_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GuaranteedRarity)
                    .HasColumnName("guaranteed_rarity")
                    .HasDefaultValueSql("('4')");

                entity.Property(e => e.IsListup).HasColumnName("is_listup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.NotDuplicateCount)
                    .HasColumnName("not_duplicate_count")
                    .HasDefaultValueSql("('5')");

                entity.Property(e => e.PackCount)
                    .HasColumnName("pack_count")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PrevGachaId).HasColumnName("prev_gacha_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GashGifts>(entity =>
            {
                entity.ToTable("gash_gifts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GashId).HasColumnName("gash_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<GashProducts>(entity =>
            {
                entity.ToTable("gash_products");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Coin).HasColumnName("coin");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EnableGift).HasColumnName("enable_gift");

                entity.Property(e => e.GiftEndTime)
                    .HasColumnName("gift_end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GiftStartTime)
                    .HasColumnName("gift_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PointAvailable).HasColumnName("point_available");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RegularAvailable)
                    .HasColumnName("regular_available")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TelecomAvailable).HasColumnName("telecom_available");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.Property(e => e.WalletAvailable).HasColumnName("wallet_available");
            });

            modelBuilder.Entity<GashRcodes>(entity =>
            {
                entity.ToTable("gash_rcodes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rcode).HasColumnName("rcode");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GashTransactions>(entity =>
            {
                entity.ToTable("gash_transactions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasMaxLength(255);

                entity.Property(e => e.Coid)
                    .HasColumnName("coid")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cuid)
                    .HasColumnName("cuid")
                    .HasMaxLength(255);

                entity.Property(e => e.ErpId)
                    .HasColumnName("erp_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Erpc)
                    .HasColumnName("erpc")
                    .HasMaxLength(255);

                entity.Property(e => e.InquireRequestRaw)
                    .HasColumnName("inquire_request_raw")
                    .HasColumnType("ntext");

                entity.Property(e => e.InquireResponseRaw)
                    .HasColumnName("inquire_response_raw")
                    .HasColumnType("ntext");

                entity.Property(e => e.PId)
                    .HasColumnName("p_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PName)
                    .HasColumnName("p_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.PaidType)
                    .HasColumnName("paid_type")
                    .HasMaxLength(255);

                entity.Property(e => e.PayStatus)
                    .HasColumnName("pay_status")
                    .HasMaxLength(255);

                entity.Property(e => e.Rcode)
                    .HasColumnName("rcode")
                    .HasMaxLength(255);

                entity.Property(e => e.Received).HasColumnName("received");

                entity.Property(e => e.RequestRaw)
                    .HasColumnName("request_raw")
                    .HasColumnType("ntext");

                entity.Property(e => e.ResultRaw)
                    .HasColumnName("result_raw")
                    .HasColumnType("ntext");

                entity.Property(e => e.Rrn)
                    .HasColumnName("rrn")
                    .HasMaxLength(255);

                entity.Property(e => e.SettleRequestRaw)
                    .HasColumnName("settle_request_raw")
                    .HasColumnType("ntext");

                entity.Property(e => e.SettleResponseRaw)
                    .HasColumnName("settle_response_raw")
                    .HasColumnType("ntext");

                entity.Property(e => e.Settled).HasColumnName("settled");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<GuestCharacters>(entity =>
            {
                entity.ToTable("guest_characters");

                entity.HasIndex(e => new { e.QuestId, e.CharacterId })
                    .HasName("guest_characters_quest_id_and_character_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lv).HasColumnName("lv");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<HelpCategories>(entity =>
            {
                entity.ToTable("help_categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<HelpTexts>(entity =>
            {
                entity.ToTable("help_texts");

                entity.HasIndex(e => new { e.HelpCategoryId, e.Name })
                    .HasName("help_texts_help_category_id_and_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("display_order")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HelpCategoryId).HasColumnName("help_category_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Invitations>(entity =>
            {
                entity.ToTable("invitations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BannerId)
                    .HasColumnName("banner_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.ToTable("items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.ExpireAt)
                    .HasColumnName("expire_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.PossessionLimit).HasColumnName("possession_limit");

                entity.Property(e => e.Rarity)
                    .HasColumnName("rarity")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value1).HasColumnName("value1");

                entity.Property(e => e.Value2).HasColumnName("value2");

                entity.Property(e => e.Value3).HasColumnName("value3");

                entity.Property(e => e.Value4).HasColumnName("value4");

                entity.Property(e => e.Value5).HasColumnName("value5");
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.ToTable("jobs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<KouhakuBuffs>(entity =>
            {
                entity.ToTable("kouhaku_buffs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttackKind).HasColumnName("attack_kind");

                entity.Property(e => e.BuffType).HasColumnName("buff_type");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.ElementKind).HasColumnName("element_kind");

                entity.Property(e => e.Scale).HasColumnName("scale");
            });

            modelBuilder.Entity<KouhakuMessages>(entity =>
            {
                entity.ToTable("kouhaku_messages");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LeaderSkills>(entity =>
            {
                entity.ToTable("leader_skills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.LeaderSkillEffectType).HasColumnName("leader_skill_effect_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value1).HasColumnName("value1");

                entity.Property(e => e.Value2).HasColumnName("value2");

                entity.Property(e => e.Value3).HasColumnName("value3");

                entity.Property(e => e.Value4).HasColumnName("value4");

                entity.Property(e => e.Value5).HasColumnName("value5");
            });

            modelBuilder.Entity<LevelupAps>(entity =>
            {
                entity.ToTable("levelup_aps");

                entity.HasIndex(e => new { e.LevelupApType, e.Lv })
                    .HasName("levelup_aps_levelup_ap_type_and_lv");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ap).HasColumnName("ap");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.LevelupApType).HasColumnName("levelup_ap_type");

                entity.Property(e => e.Lv).HasColumnName("lv");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LimitupAps>(entity =>
            {
                entity.ToTable("limitup_aps");

                entity.HasIndex(e => new { e.Rarity, e.Count })
                    .HasName("limitup_aps_rarity_and_count");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ap)
                    .HasColumnName("ap")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LimitupCharacterRequirements>(entity =>
            {
                entity.ToTable("limitup_character_requirements");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Blow)
                    .HasColumnName("blow")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Botte)
                    .HasColumnName("botte")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EvolutionType)
                    .HasColumnName("evolution_type")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Magic)
                    .HasColumnName("magic")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RarityMax)
                    .HasColumnName("rarity_max")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RarityMin)
                    .HasColumnName("rarity_min")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Shot)
                    .HasColumnName("shot")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Slash)
                    .HasColumnName("slash")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<MarkerLots>(entity =>
            {
                entity.ToTable("marker_lots");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.T1Circle).HasColumnName("t1_circle");

                entity.Property(e => e.T1Heart).HasColumnName("t1_heart");

                entity.Property(e => e.T1Square).HasColumnName("t1_square");

                entity.Property(e => e.T1Star).HasColumnName("t1_star");

                entity.Property(e => e.T1Triangle).HasColumnName("t1_triangle");

                entity.Property(e => e.T2Circle).HasColumnName("t2_circle");

                entity.Property(e => e.T2Heart).HasColumnName("t2_heart");

                entity.Property(e => e.T2Square).HasColumnName("t2_square");

                entity.Property(e => e.T2Star).HasColumnName("t2_star");

                entity.Property(e => e.T2Triangle).HasColumnName("t2_triangle");

                entity.Property(e => e.T3Circle).HasColumnName("t3_circle");

                entity.Property(e => e.T3Heart).HasColumnName("t3_heart");

                entity.Property(e => e.T3Square).HasColumnName("t3_square");

                entity.Property(e => e.T3Star).HasColumnName("t3_star");

                entity.Property(e => e.T3Triangle).HasColumnName("t3_triangle");

                entity.Property(e => e.Table1Rate).HasColumnName("table1_rate");

                entity.Property(e => e.Table2Rate).HasColumnName("table2_rate");

                entity.Property(e => e.Table3Rate).HasColumnName("table3_rate");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MissionCategories>(entity =>
            {
                entity.ToTable("mission_categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgImgPath)
                    .IsRequired()
                    .HasColumnName("bg_img_path")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventIncentiveImgPath)
                    .IsRequired()
                    .HasColumnName("event_incentive_img_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FrameImgPath)
                    .IsRequired()
                    .HasColumnName("frame_img_path")
                    .HasMaxLength(255);

                entity.Property(e => e.LabelImgPath)
                    .IsRequired()
                    .HasColumnName("label_img_path")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Missions>(entity =>
            {
                entity.ToTable("missions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApMax).HasColumnName("ap_max");

                entity.Property(e => e.ApMin).HasColumnName("ap_min");

                entity.Property(e => e.ConfirmMessage)
                    .IsRequired()
                    .HasColumnName("confirm_message")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConfirmMessageEn)
                    .IsRequired()
                    .HasColumnName("confirm_message_en")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndMessage)
                    .IsRequired()
                    .HasColumnName("end_message")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndMessageEn)
                    .IsRequired()
                    .HasColumnName("end_message_en")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GaldMax).HasColumnName("gald_max");

                entity.Property(e => e.GaldMin).HasColumnName("gald_min");

                entity.Property(e => e.Lv).HasColumnName("lv");

                entity.Property(e => e.MissionCategoryId).HasColumnName("mission_category_id");

                entity.Property(e => e.MissionRarityWeightId).HasColumnName("mission_rarity_weight_id");

                entity.Property(e => e.MissionSuccessId).HasColumnName("mission_success_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RequireMinutes).HasColumnName("require_minutes");

                entity.Property(e => e.RequiredCoin).HasColumnName("required_coin");

                entity.Property(e => e.ReturnMessage)
                    .IsRequired()
                    .HasColumnName("return_message")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReturnMessageEn)
                    .IsRequired()
                    .HasColumnName("return_message_en")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RewardCountMax).HasColumnName("reward_count_max");

                entity.Property(e => e.RewardCountMin).HasColumnName("reward_count_min");

                entity.Property(e => e.RewardDescription)
                    .IsRequired()
                    .HasColumnName("reward_description")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RewardDescriptionEn)
                    .IsRequired()
                    .HasColumnName("reward_description_en")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartMessage)
                    .IsRequired()
                    .HasColumnName("start_message")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartMessageEn)
                    .IsRequired()
                    .HasColumnName("start_message_en")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Pages>(entity =>
            {
                entity.ToTable("pages");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Scroll)
                    .IsRequired()
                    .HasColumnName("scroll")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PassiveSkills>(entity =>
            {
                entity.ToTable("passive_skills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayFlag)
                    .HasColumnName("display_flag")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PassiveSkillEffectType).HasColumnName("passive_skill_effect_type");

                entity.Property(e => e.Value1).HasColumnName("value1");

                entity.Property(e => e.Value2).HasColumnName("value2");

                entity.Property(e => e.Value3).HasColumnName("value3");

                entity.Property(e => e.Value4).HasColumnName("value4");

                entity.Property(e => e.Value5).HasColumnName("value5");

                entity.Property(e => e.Value6).HasColumnName("value6");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<PointGifts>(entity =>
            {
                entity.ToTable("point_gifts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(40);

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestCollects>(entity =>
            {
                entity.ToTable("quest_collects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Collectable1Id)
                    .HasColumnName("collectable1_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Collectable1Quantity)
                    .HasColumnName("collectable1_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Collectable1Type)
                    .IsRequired()
                    .HasColumnName("collectable1_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Collectable2Id)
                    .HasColumnName("collectable2_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Collectable2Quantity)
                    .HasColumnName("collectable2_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Collectable2Type)
                    .IsRequired()
                    .HasColumnName("collectable2_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Collectable3Id)
                    .HasColumnName("collectable3_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Collectable3Quantity)
                    .HasColumnName("collectable3_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Collectable3Type)
                    .IsRequired()
                    .HasColumnName("collectable3_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Collectable4Id)
                    .HasColumnName("collectable4_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Collectable4Quantity)
                    .HasColumnName("collectable4_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Collectable4Type)
                    .IsRequired()
                    .HasColumnName("collectable4_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstReward1Id)
                    .HasColumnName("first_reward1_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward1Quantity)
                    .HasColumnName("first_reward1_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward1Type)
                    .IsRequired()
                    .HasColumnName("first_reward1_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstReward2Id)
                    .HasColumnName("first_reward2_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward2Quantity)
                    .HasColumnName("first_reward2_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward2Type)
                    .IsRequired()
                    .HasColumnName("first_reward2_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstReward3Id)
                    .HasColumnName("first_reward3_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward3Quantity)
                    .HasColumnName("first_reward3_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward3Type)
                    .IsRequired()
                    .HasColumnName("first_reward3_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstReward4Id)
                    .HasColumnName("first_reward4_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward4Quantity)
                    .HasColumnName("first_reward4_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward4Type)
                    .IsRequired()
                    .HasColumnName("first_reward4_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reward1Id)
                    .HasColumnName("reward1_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward1Quantity)
                    .HasColumnName("reward1_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward1Type)
                    .IsRequired()
                    .HasColumnName("reward1_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reward2Id)
                    .HasColumnName("reward2_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward2Quantity)
                    .HasColumnName("reward2_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward2Type)
                    .IsRequired()
                    .HasColumnName("reward2_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reward3Id)
                    .HasColumnName("reward3_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward3Quantity)
                    .HasColumnName("reward3_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward3Type)
                    .IsRequired()
                    .HasColumnName("reward3_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reward4Id)
                    .HasColumnName("reward4_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward4Quantity)
                    .HasColumnName("reward4_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward4Type)
                    .IsRequired()
                    .HasColumnName("reward4_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestDisplayRestrictions>(entity =>
            {
                entity.ToTable("quest_display_restrictions");

                entity.HasIndex(e => new { e.QuestId, e.PrevQuestId })
                    .HasName("quest_display_restrictions_quest_id_and_prev_quest_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrevQuestId)
                    .HasColumnName("prev_quest_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestEffectCharacters>(entity =>
            {
                entity.ToTable("quest_effect_characters");

                entity.HasIndex(e => e.CharacterId)
                    .HasName("quest_effect_characters_character_id");

                entity.HasIndex(e => e.QuestId)
                    .HasName("quest_effect_characters_quest_id");

                entity.HasIndex(e => new { e.QuestId, e.CharacterId })
                    .HasName("quest_effect_characters_quest_id_and_character_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.QuestEffectId).HasColumnName("quest_effect_id");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestEffects>(entity =>
            {
                entity.ToTable("quest_effects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtkPercentage)
                    .HasColumnName("atk_percentage")
                    .HasDefaultValueSql("('100')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasDefaultValueSql("('9')");

                entity.Property(e => e.HealPercentage)
                    .HasColumnName("heal_percentage")
                    .HasDefaultValueSql("('100')");

                entity.Property(e => e.HpPercentage)
                    .HasColumnName("hp_percentage")
                    .HasDefaultValueSql("('100')");

                entity.Property(e => e.LeaderSkillId)
                    .HasColumnName("leader_skill_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RankingPointPercentage)
                    .HasColumnName("ranking_point_percentage")
                    .HasDefaultValueSql("('100')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestFirstTimeClearRewards>(entity =>
            {
                entity.ToTable("quest_first_time_clear_rewards");

                entity.HasIndex(e => e.QuestId)
                    .HasName("quest_first_time_clear_rewards_quest_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GiftableId).HasColumnName("giftable_id");

                entity.Property(e => e.GiftableType)
                    .IsRequired()
                    .HasColumnName("giftable_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");
            });

            modelBuilder.Entity<Quests>(entity =>
            {
                entity.ToTable("quests");

                entity.HasIndex(e => new { e.AreaId, e.PrevQuestId })
                    .HasName("quests_area_id_and_prev_quest_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Act).HasColumnName("act");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BackgroundId).HasColumnName("background_id");

                entity.Property(e => e.BattleCount).HasColumnName("battle_count");

                entity.Property(e => e.BgmBossId)
                    .HasColumnName("bgm_boss_id")
                    .HasDefaultValueSql("('9')");

                entity.Property(e => e.BgmNormalId)
                    .HasColumnName("bgm_normal_id")
                    .HasDefaultValueSql("('7')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefeatCountMultiplier)
                    .HasColumnName("defeat_count_multiplier")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.MarkerLotId).HasColumnName("marker_lot_id");

                entity.Property(e => e.MaxClearCount)
                    .HasColumnName("max_clear_count")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MaxContinueCount)
                    .HasColumnName("max_continue_count")
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.PassiveSkillLearnLimit)
                    .HasColumnName("passive_skill_learn_limit")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PrevQuestId)
                    .HasColumnName("prev_quest_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.QuestType).HasColumnName("quest_type");

                entity.Property(e => e.RequirementId)
                    .HasColumnName("requirement_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SerialCodeDropRate)
                    .HasColumnName("serial_code_drop_rate")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SkillLearnBossFirstProb)
                    .HasColumnName("skill_learn_boss_first_prob")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SkillLearnBossProb)
                    .HasColumnName("skill_learn_boss_prob")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SkillLearnFlyProb)
                    .HasColumnName("skill_learn_fly_prob")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TargetableId)
                    .HasColumnName("targetable_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TargetableType)
                    .IsRequired()
                    .HasColumnName("targetable_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipGroupId)
                    .HasColumnName("tip_group_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UnisonEnabled)
                    .HasColumnName("unison_enabled")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestTargets>(entity =>
            {
                entity.ToTable("quest_targets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cond1).HasColumnName("cond1");

                entity.Property(e => e.Cond2).HasColumnName("cond2");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");

                entity.Property(e => e.EnemyId).HasColumnName("enemy_id");

                entity.Property(e => e.FirstReward1Id)
                    .HasColumnName("first_reward1_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward1Quantity)
                    .HasColumnName("first_reward1_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward1Type)
                    .IsRequired()
                    .HasColumnName("first_reward1_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstReward2Id)
                    .HasColumnName("first_reward2_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward2Quantity)
                    .HasColumnName("first_reward2_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward2Type)
                    .IsRequired()
                    .HasColumnName("first_reward2_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstReward3Id)
                    .HasColumnName("first_reward3_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward3Quantity)
                    .HasColumnName("first_reward3_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward3Type)
                    .IsRequired()
                    .HasColumnName("first_reward3_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstReward4Id)
                    .HasColumnName("first_reward4_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward4Quantity)
                    .HasColumnName("first_reward4_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FirstReward4Type)
                    .IsRequired()
                    .HasColumnName("first_reward4_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reward1Id)
                    .HasColumnName("reward1_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward1Quantity)
                    .HasColumnName("reward1_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward1Type)
                    .IsRequired()
                    .HasColumnName("reward1_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reward2Id)
                    .HasColumnName("reward2_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward2Quantity)
                    .HasColumnName("reward2_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward2Type)
                    .IsRequired()
                    .HasColumnName("reward2_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reward3Id)
                    .HasColumnName("reward3_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward3Quantity)
                    .HasColumnName("reward3_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward3Type)
                    .IsRequired()
                    .HasColumnName("reward3_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reward4Id)
                    .HasColumnName("reward4_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward4Quantity)
                    .HasColumnName("reward4_quantity")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Reward4Type)
                    .IsRequired()
                    .HasColumnName("reward4_type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<RankingWorlds>(entity =>
            {
                entity.ToTable("ranking_worlds");

                entity.HasIndex(e => e.RankingId)
                    .HasName("ranking_worlds_ranking_id");

                entity.HasIndex(e => e.WorldId)
                    .HasName("ranking_worlds_world_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasMaxLength(255);

                entity.Property(e => e.RankingId).HasColumnName("ranking_id");

                entity.Property(e => e.Threshold)
                    .HasColumnName("threshold")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorldId).HasColumnName("world_id");
            });

            modelBuilder.Entity<Serials>(entity =>
            {
                entity.ToTable("serials");

                entity.HasIndex(e => new { e.StartAt, e.EndAt })
                    .HasName("serials_start_at_and_end_at");

                entity.HasIndex(e => new { e.StartAt, e.ExpiredAt })
                    .HasName("serials_start_at_and_expired_at");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharacterMessage)
                    .IsRequired()
                    .HasColumnName("character_message")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");

                entity.Property(e => e.EndAt)
                    .HasColumnName("end_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpiredAt)
                    .HasColumnName("expired_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64);

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.StartAt)
                    .HasColumnName("start_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.ToTable("series");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abbrev)
                    .IsRequired()
                    .HasColumnName("abbrev")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.ToTable("skills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.InitTurn).HasColumnName("init_turn");

                entity.Property(e => e.MinTurn).HasColumnName("min_turn");

                entity.Property(e => e.SkillEffectType).HasColumnName("skill_effect_type");

                entity.Property(e => e.SkillType).HasColumnName("skill_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value1).HasColumnName("value1");

                entity.Property(e => e.Value2).HasColumnName("value2");

                entity.Property(e => e.Value3).HasColumnName("value3");

                entity.Property(e => e.Value4).HasColumnName("value4");

                entity.Property(e => e.Value5).HasColumnName("value5");
            });

            modelBuilder.Entity<Supporters>(entity =>
            {
                entity.ToTable("supporters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApPrice).HasColumnName("ap_price");

                entity.Property(e => e.Element).HasColumnName("element");

                entity.Property(e => e.ImageId)
                    .HasColumnName("image_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.SeriesId).HasColumnName("series_id");

                entity.Property(e => e.SupportType).HasColumnName("support_type");

                entity.Property(e => e.SupporterSkillId).HasColumnName("supporter_skill_id");
            });

            modelBuilder.Entity<SupporterSkills>(entity =>
            {
                entity.ToTable("supporter_skills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.SupporterSkillEffectType).HasColumnName("supporter_skill_effect_type");

                entity.Property(e => e.Value1).HasColumnName("value1");

                entity.Property(e => e.Value2).HasColumnName("value2");

                entity.Property(e => e.Value3).HasColumnName("value3");

                entity.Property(e => e.Value4).HasColumnName("value4");

                entity.Property(e => e.Value5).HasColumnName("value5");
            });

            modelBuilder.Entity<TipGroups>(entity =>
            {
                entity.ToTable("tip_groups");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Groups).HasColumnName("groups");

                entity.Property(e => e.TipId).HasColumnName("tip_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tips>(entity =>
            {
                entity.ToTable("tips");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.ToTable("units");

                entity.HasIndex(e => e.JobId)
                    .HasName("units_job_id");

                entity.HasIndex(e => e.SeriesId)
                    .HasName("units_series_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsCostumed)
                    .HasColumnName("is_costumed")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.SeriesCharacterUniqId).HasColumnName("series_character_uniq_id");

                entity.Property(e => e.SeriesId).HasColumnName("series_id");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Worlds>(entity =>
            {
                entity.ToTable("worlds");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BasePosX)
                    .HasColumnName("base_pos_x")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.BasePosY)
                    .HasColumnName("base_pos_y")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PrevWorldId)
                    .HasColumnName("prev_world_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });
        }
    }
}
