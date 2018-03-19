using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ToLiAPI.Models;

namespace ToLiAPI {
    [Route("api/[controller]")]
    public class UtilityController : Controller {
        readonly ToLiDbContext dataContext;
        

        public UtilityController(ToLiDbContext dataContext) {
            this.dataContext = dataContext;
        }

        [HttpGet("[action]/{shrink?}")]
        public async Task<JsonResult> JPUnitNameFinder([FromRoute] Boolean? shrink) {
            var wikiaApiCall = "http://tales-of-link.wikia.com/api/v1/Articles/List?category=JP_Units&limit=600";
            List<WikiaResponse> wikiaJpUnits = new List<WikiaResponse>();

            using(var httpClient = new HttpClient()) {
                var response = await httpClient.GetAsync(wikiaApiCall);
                var json = JObject.Parse(await response.Content.ReadAsStringAsync());
                wikiaJpUnits = json["items"].ToObject<List<WikiaResponse>>();
            }

            var ids = wikiaJpUnits.Select(u => u.GetUnitId());
            var jpUnits = dataContext.Characters
                .Include(c => c.LeaderSkill)
                .Include(c => c.Skill)
                .Include(c => c.Art)
                .Include(c => c.EvolveCharacter)
                .Where(c => ids.Any(id => id == c.UnitId));

            if(shrink.HasValue && shrink.Value) {
                return Json(jpUnits.Select(u => new {
                    UnitId = u.UnitId,
                    Name = u.Name,
                    NameEn = u.NameEn,
                    Rarity = u.Rarity,
                    LeaderSkillName = u.LeaderSkill.Name,
                    LeaderSkillDescription = u.LeaderSkill.Description,
                    ActiveSkillName = u.SkillName,
                    ActiveSkillDescription = u.Skill.Description,
                    ArteName = u.Art.Name,
                    ArteDescription = u.Art.Description,
                    HpInit = u.HpInit,
                    HpMax = u.HpMax,
                    AtkInit = u.AtkInit,
                    AtkMax = u.AtkMax,
                    RcvInit = u.HealInit,
                    RcvMax = u.HealMax,
                    AwakeningUnitId = u.EvolveCharacterId
                }));
            }

            return Json(jpUnits);
        }

        [HttpGet("[action]/{id}")]
        public async Task<JsonResult> FindEnemiesByEnemyUnitId([FromRoute] int id) {
            return Json(await dataContext.Enemies.Where(e => e.EnemyUnitId == id).ToListAsync());
        }
    }

    class WikiaResponse {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Url { get; set; }
        public int Ns { get; set; }

        public int GetUnitId() {
            return Int32.Parse(Regex.Match(Title, @"JP ([0-9]*)").Groups[1].Value);
        }
    }
}