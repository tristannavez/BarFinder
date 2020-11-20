using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using POIN.Server.DAL;
using POIN.Shared.Models;


namespace POIN.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BarsController : ControllerBase
    {
        private readonly EventContext dbContext;

        public BarsController(EventContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Bars>> GetAll()
        {

            return await dbContext.Bars.Include(i => i.Image).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Bars> GetById(Guid id)
        {
            var bar =  await dbContext.Bars.Include(i => i.Image).FirstOrDefaultAsync(p => p.BarsID == id);
            //bar.Image = await dbContext.Image.FirstOrDefaultAsync(i => i.ImageID == bar.ImageID);
            return bar;
        }

        // [HttpGet("image/{id}")]
        // public async Task<IEnumerable<Bar>> GetByImageId(Guid id)
        // {
        //     return await dbContext.Bars.Where(p => p.Image.Id == id).ToListAsync();
        // }

        [HttpGet("menus/{id}")]
        public async Task<List<Menus>> GetMenusByBarsId(Guid id) 
        {
            var menus = await dbContext.Menus.Where(m => m.BarsID == id).ToListAsync();
            return menus;
        }


        [HttpDelete("{id}")]
        public async Task DeleteById(Guid id)
        {
            var item = await dbContext.Bars.FirstOrDefaultAsync(p => p.BarsID == id);
            dbContext.Bars.Remove(item);
            await dbContext.SaveChangesAsync();

        }

        [HttpPut]
        public async Task<Bars> UpdateById(Bars item)
        {
            var itemPrevious = await dbContext.Bars.FirstOrDefaultAsync(p => p.BarsID == item.BarsID);

            if (itemPrevious != null)
            {
                itemPrevious.Name = item.Name;
                itemPrevious.Lng = item.Lng;
                itemPrevious.Lat = item.Lat;
                itemPrevious.ImageID = item.ImageID;
                itemPrevious.Image = item.Image;

                await dbContext.SaveChangesAsync();
            }

            return itemPrevious;

        }

        [HttpPost]
        public async Task<Bars> InsertBar(Bars bar)
        {
            dbContext.Bars.Add(bar);
            await dbContext.SaveChangesAsync();

            return bar;
        } 
    }
}
