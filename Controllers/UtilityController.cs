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
    public class UtilityController : Controller {
        readonly ToLiDbContext dataContext;
        

        public UtilityController(ToLiDbContext dataContext) {
            this.dataContext = dataContext;
        }
        public async Task<JsonResult> JPUnitNameFinder() {
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

            return Json(jpUnits);
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