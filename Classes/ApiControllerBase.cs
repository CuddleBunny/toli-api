using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NSwag.Annotations;
using ToLiAPI.Models;

namespace ToLiAPI {
    public class ApiController<T> : Controller where T : Entity, new() {
        protected readonly DbSet<T> data;
        protected readonly ToLiDbContext dataContext;
        
        public ApiController(ToLiDbContext dataContext, DbSet<T> data) {
            this.data = data;
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<JsonResult> Get() {
            return Json(await data.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<JsonResult> Get([FromRoute] int id) {
            return Json(await data.Where(item => item.Id == id).FirstOrDefaultAsync());
        }

        /* TODO: Let authenticated users add data?

        [HttpPost]
        public async Task<JsonResult> Post([FromBody] T item) {
            data.Add(item);
            await dataContext.SaveChangesAsync();
            return Json(item);
        }

        [HttpPut("{id}")]
        public async Task<JsonResult> Put([FromRoute] int id, [FromBody] T item) {
            item.Id = id;
            dataContext.Entry(item).State = EntityState.Modified;
            await dataContext.SaveChangesAsync();
            return Json(item);
        }

        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete([FromRoute] int id) {
            var item = new T { Id = id };
            dataContext.Entry(item).State = EntityState.Deleted;
            await dataContext.SaveChangesAsync();
            return Json(item);
        }
        */
    }
}