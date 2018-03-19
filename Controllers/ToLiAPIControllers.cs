using ToLiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ToLiAPI
{
	[Route("api/[controller]")]
    public class AppliedParametersController : ApiController<AppliedParameters>
    {
        public AppliedParametersController(ToLiDbContext dataContext) : base(dataContext, dataContext.AppliedParameters) { }
    }

	[Route("api/[controller]")]
    public class AreaAvailablesController : ApiController<AppliedParameters>
    {
        public AreaAvailablesController(ToLiDbContext dataContext) : base(dataContext, dataContext.AppliedParameters) { }
    }

	[Route("api/[controller]")]
    public class AreaBonusesController : ApiController<AreaBonuses>
    {
        public AreaBonusesController(ToLiDbContext dataContext) : base(dataContext, dataContext.AreaBonuses) { }
    }

	[Route("api/[controller]")]
    public class AreasController : ApiController<Areas>
    {
        public AreasController(ToLiDbContext dataContext) : base(dataContext, dataContext.Areas) { }
    }

	[Route("api/[controller]")]
    public class ArtEquipmentCharactersController : ApiController<ArtEquipmentCharacters>
    {
        public ArtEquipmentCharactersController(ToLiDbContext dataContext) : base(dataContext, dataContext.ArtEquipmentCharacters) { }
    }

	[Route("api/[controller]")]
    public class ArtEquipmentsController : ApiController<ArtEquipments>
    {
        public ArtEquipmentsController(ToLiDbContext dataContext) : base(dataContext, dataContext.ArtEquipments) { }
    }

	[Route("api/[controller]")]
    public class ArtLevelsController : ApiController<ArtLevels>
    {
        public ArtLevelsController(ToLiDbContext dataContext) : base(dataContext, dataContext.ArtLevels) { }
    }

	[Route("api/[controller]")]
    public class ArtsController : ApiController<Arts>
    {
        public ArtsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Arts) { }
    }

	[Route("api/[controller]")]
    public class BannersController : ApiController<Banners>
    {
        public BannersController(ToLiDbContext dataContext) : base(dataContext, dataContext.Banners) { }
    }

	[Route("api/[controller]")]
    public class CharacterPassiveSkillsController : ApiController<CharacterPassiveSkills>
    {
        public CharacterPassiveSkillsController(ToLiDbContext dataContext) : base(dataContext, dataContext.CharacterPassiveSkills) { }
    }

	[Route("api/[controller]")]
    public class CharacterResultMessagesController : ApiController<CharacterResultMessages>
    {
        public CharacterResultMessagesController(ToLiDbContext dataContext) : base(dataContext, dataContext.CharacterResultMessages) { }
    }

	[Route("api/[controller]")]
    public class CoinShopItemContentsController : ApiController<CoinShopItemContents>
    {
        public CoinShopItemContentsController(ToLiDbContext dataContext) : base(dataContext, dataContext.CoinShopItemContents) { }
    }

	[Route("api/[controller]")]
    public class CoinShopItemsController : ApiController<CoinShopItems>
    {
        public CoinShopItemsController(ToLiDbContext dataContext) : base(dataContext, dataContext.CoinShopItems) { }
    }

	[Route("api/[controller]")]
    public class ContractRewardsController : ApiController<ContractRewards>
    {
        public ContractRewardsController(ToLiDbContext dataContext) : base(dataContext, dataContext.ContractRewards) { }
    }

	[Route("api/[controller]")]
    public class ContractsController : ApiController<Contracts>
    {
        public ContractsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Contracts) { }
    }

	[Route("api/[controller]")]
    public class DaisukiVideosController : ApiController<DaisukiVideos>
    {
        public DaisukiVideosController(ToLiDbContext dataContext) : base(dataContext, dataContext.DaisukiVideos) { }
    }

	[Route("api/[controller]")]
    public class EmpireMemberRolesController : ApiController<EmpireMemberRoles>
    {
        public EmpireMemberRolesController(ToLiDbContext dataContext) : base(dataContext, dataContext.EmpireMemberRoles) { }
    }

	[Route("api/[controller]")]
    public class EmpireRewardsController : ApiController<EmpireRewards>
    {
        public EmpireRewardsController(ToLiDbContext dataContext) : base(dataContext, dataContext.EmpireRewards) { }
    }

	[Route("api/[controller]")]
    public class EmpireSymbolsController : ApiController<EmpireSymbols>
    {
        public EmpireSymbolsController(ToLiDbContext dataContext) : base(dataContext, dataContext.EmpireSymbols) { }
    }

	[Route("api/[controller]")]
    public class EnemiesController : ApiController<Enemies>
    {
        public EnemiesController(ToLiDbContext dataContext) : base(dataContext, dataContext.Enemies) { }
    }

	[Route("api/[controller]")]
    public class EnemyHeroBehaviorSkillsController : ApiController<EnemyHeroBehaviorSkills>
    {
        public EnemyHeroBehaviorSkillsController(ToLiDbContext dataContext) : base(dataContext, dataContext.EnemyHeroBehaviorSkills) { }
    }

	[Route("api/[controller]")]
    public class EnemyHeroCoefficientsController : ApiController<EnemyHeroCoefficients>
    {
        public EnemyHeroCoefficientsController(ToLiDbContext dataContext) : base(dataContext, dataContext.EnemyHeroCoefficients) { }
    }

	[Route("api/[controller]")]
    public class EnemySkillsController : ApiController<EnemySkills>
    {
        public EnemySkillsController(ToLiDbContext dataContext) : base(dataContext, dataContext.EnemySkills) { }
    }

	[Route("api/[controller]")]
    public class EnemyUnitsController : ApiController<EnemyUnits>
    {
        public EnemyUnitsController(ToLiDbContext dataContext) : base(dataContext, dataContext.EnemyUnits) { }
    }

	[Route("api/[controller]")]
    public class EquipmentController : ApiController<Equipment>
    {
        public EquipmentController(ToLiDbContext dataContext) : base(dataContext, dataContext.Equipment) { }
    }

	[Route("api/[controller]")]
    public class EquipmentEvolveStuffsController : ApiController<EquipmentEvolveStuffs>
    {
        public EquipmentEvolveStuffsController(ToLiDbContext dataContext) : base(dataContext, dataContext.EquipmentEvolveStuffs) { }
    }

	[Route("api/[controller]")]
    public class ErrorCodesController : ApiController<ErrorCodes>
    {
        public ErrorCodesController(ToLiDbContext dataContext) : base(dataContext, dataContext.ErrorCodes) { }
    }

	[Route("api/[controller]")]
    public class GachasController : ApiController<Gachas>
    {
        public GachasController(ToLiDbContext dataContext) : base(dataContext, dataContext.Gachas) { }
    }

	[Route("api/[controller]")]
    public class GashGiftsController : ApiController<GashGifts>
    {
        public GashGiftsController(ToLiDbContext dataContext) : base(dataContext, dataContext.GashGifts) { }
    }

	[Route("api/[controller]")]
    public class GashProductsController : ApiController<GashProducts>
    {
        public GashProductsController(ToLiDbContext dataContext) : base(dataContext, dataContext.GashProducts) { }
    }

	[Route("api/[controller]")]
    public class GashRcodesController : ApiController<GashRcodes>
    {
        public GashRcodesController(ToLiDbContext dataContext) : base(dataContext, dataContext.GashRcodes) { }
    }

	[Route("api/[controller]")]
    public class GashTransactionsController : ApiController<GashTransactions>
    {
        public GashTransactionsController(ToLiDbContext dataContext) : base(dataContext, dataContext.GashTransactions) { }
    }

	[Route("api/[controller]")]
    public class GuestCharactersController : ApiController<GuestCharacters>
    {
        public GuestCharactersController(ToLiDbContext dataContext) : base(dataContext, dataContext.GuestCharacters) { }
    }

	[Route("api/[controller]")]
    public class HelpCategoriesController : ApiController<HelpCategories>
    {
        public HelpCategoriesController(ToLiDbContext dataContext) : base(dataContext, dataContext.HelpCategories) { }
    }

	[Route("api/[controller]")]
    public class HelpTextsController : ApiController<HelpTexts>
    {
        public HelpTextsController(ToLiDbContext dataContext) : base(dataContext, dataContext.HelpTexts) { }
    }

	[Route("api/[controller]")]
    public class InvitationsController : ApiController<Invitations>
    {
        public InvitationsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Invitations) { }
    }

	[Route("api/[controller]")]
    public class ItemsController : ApiController<Items>
    {
        public ItemsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Items) { }
    }

	[Route("api/[controller]")]
    public class JobsController : ApiController<Jobs>
    {
        public JobsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Jobs) { }
    }

	[Route("api/[controller]")]
    public class KouhakuBuffsController : ApiController<KouhakuBuffs>
    {
        public KouhakuBuffsController(ToLiDbContext dataContext) : base(dataContext, dataContext.KouhakuBuffs) { }
    }

	[Route("api/[controller]")]
    public class KouhakuMessagesController : ApiController<KouhakuMessages>
    {
        public KouhakuMessagesController(ToLiDbContext dataContext) : base(dataContext, dataContext.KouhakuMessages) { }
    }

	[Route("api/[controller]")]
    public class LeaderSkillsController : ApiController<LeaderSkills>
    {
        public LeaderSkillsController(ToLiDbContext dataContext) : base(dataContext, dataContext.LeaderSkills) { }
    }

	[Route("api/[controller]")]
    public class LevelupApsController : ApiController<LevelupAps>
    {
        public LevelupApsController(ToLiDbContext dataContext) : base(dataContext, dataContext.LevelupAps) { }
    }

	[Route("api/[controller]")]
    public class LimitupApsController : ApiController<LimitupAps>
    {
        public LimitupApsController(ToLiDbContext dataContext) : base(dataContext, dataContext.LimitupAps) { }
    }

	[Route("api/[controller]")]
    public class LimitupCharacterRequirementsController : ApiController<LimitupCharacterRequirements>
    {
        public LimitupCharacterRequirementsController(ToLiDbContext dataContext) : base(dataContext, dataContext.LimitupCharacterRequirements) { }
    }

	[Route("api/[controller]")]
    public class MarkerLotsController : ApiController<MarkerLots>
    {
        public MarkerLotsController(ToLiDbContext dataContext) : base(dataContext, dataContext.MarkerLots) { }
    }

	[Route("api/[controller]")]
    public class MissionCategoriesController : ApiController<MissionCategories>
    {
        public MissionCategoriesController(ToLiDbContext dataContext) : base(dataContext, dataContext.MissionCategories) { }
    }

	[Route("api/[controller]")]
    public class MissionsController : ApiController<Missions>
    {
        public MissionsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Missions) { }
    }

	[Route("api/[controller]")]
    public class PagesController : ApiController<Pages>
    {
        public PagesController(ToLiDbContext dataContext) : base(dataContext, dataContext.Pages) { }
    }

	[Route("api/[controller]")]
    public class PassiveSkillsController : ApiController<PassiveSkills>
    {
        public PassiveSkillsController(ToLiDbContext dataContext) : base(dataContext, dataContext.PassiveSkills) { }
    }

	[Route("api/[controller]")]
    public class PointGiftsController : ApiController<PointGifts>
    {
        public PointGiftsController(ToLiDbContext dataContext) : base(dataContext, dataContext.PointGifts) { }
    }

	[Route("api/[controller]")]
    public class QuestCollectsController : ApiController<QuestCollects>
    {
        public QuestCollectsController(ToLiDbContext dataContext) : base(dataContext, dataContext.QuestCollects) { }
    }

	[Route("api/[controller]")]
    public class QuestDisplayRestrictionsController : ApiController<QuestDisplayRestrictions>
    {
        public QuestDisplayRestrictionsController(ToLiDbContext dataContext) : base(dataContext, dataContext.QuestDisplayRestrictions) { }
    }

	[Route("api/[controller]")]
    public class QuestEffectCharactersController : ApiController<QuestEffectCharacters>
    {
        public QuestEffectCharactersController(ToLiDbContext dataContext) : base(dataContext, dataContext.QuestEffectCharacters) { }
    }

	[Route("api/[controller]")]
    public class QuestEffectsController : ApiController<QuestEffects>
    {
        public QuestEffectsController(ToLiDbContext dataContext) : base(dataContext, dataContext.QuestEffects) { }
    }

	[Route("api/[controller]")]
    public class QuestFirstTimeClearRewardsController : ApiController<QuestFirstTimeClearRewards>
    {
        public QuestFirstTimeClearRewardsController(ToLiDbContext dataContext) : base(dataContext, dataContext.QuestFirstTimeClearRewards) { }
    }

	[Route("api/[controller]")]
    public class QuestsController : ApiController<Quests>
    {
        public QuestsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Quests) { }
    }

	[Route("api/[controller]")]
    public class QuestTargetsController : ApiController<QuestTargets>
    {
        public QuestTargetsController(ToLiDbContext dataContext) : base(dataContext, dataContext.QuestTargets) { }
    }

	[Route("api/[controller]")]
    public class RankingWorldsController : ApiController<RankingWorlds>
    {
        public RankingWorldsController(ToLiDbContext dataContext) : base(dataContext, dataContext.RankingWorlds) { }
    }

	[Route("api/[controller]")]
    public class SerialsController : ApiController<Serials>
    {
        public SerialsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Serials) { }
    }

	[Route("api/[controller]")]
    public class SeriesController : ApiController<Series>
    {
        public SeriesController(ToLiDbContext dataContext) : base(dataContext, dataContext.Series) { }
    }

	[Route("api/[controller]")]
    public class SkillsController : ApiController<Skills>
    {
        public SkillsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Skills) { }
    }

	[Route("api/[controller]")]
    public class SupportersController : ApiController<Supporters>
    {
        public SupportersController(ToLiDbContext dataContext) : base(dataContext, dataContext.Supporters) { }
    }

	[Route("api/[controller]")]
    public class SupporterSkillsController : ApiController<SupporterSkills>
    {
        public SupporterSkillsController(ToLiDbContext dataContext) : base(dataContext, dataContext.SupporterSkills) { }
    }

	[Route("api/[controller]")]
    public class TipGroupsController : ApiController<TipGroups>
    {
        public TipGroupsController(ToLiDbContext dataContext) : base(dataContext, dataContext.TipGroups) { }
    }

	[Route("api/[controller]")]
    public class TipsController : ApiController<Tips>
    {
        public TipsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Tips) { }
    }

	[Route("api/[controller]")]
    public class UnitsController : ApiController<Units>
    {
        public UnitsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Units) { }
    }

	[Route("api/[controller]")]
    public class WorldsController : ApiController<Worlds>
    {
        public WorldsController(ToLiDbContext dataContext) : base(dataContext, dataContext.Worlds) { }
    }
}