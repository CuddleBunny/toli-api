using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToLiAPI.Api;
using ToLiAPI.Models;

namespace ToLiAPI {
	[Route("api/[controller]")]
    public class CharactersController : ApiController<Characters>
    {
        public CharactersController(ToLiDbContext dataContext) : base(dataContext, dataContext.Characters) { }

        public override async Task<JsonResult> GetAll([FromQuery] ApiQuery queryOptions) {
            var query = ApplyFilters(data, queryOptions);
        
            if(queryOptions.Include.HasValue && queryOptions.Include.Value) {
                query = query.Include(c => c.CharacterPassiveSkills)
                    .ThenInclude(c => c.PassiveSkill);
            }

            return Json(await query.ToListAsync());
        }
    }
}