using POIN.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using POIN.Server.DAL;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace POIN.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {

        private readonly EventContext dbContext;
        public MenusController(EventContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Menus>> GetAll()
        {

            return await dbContext.Menus.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Menus> GetById(Guid id)
        {
            var menu = await dbContext.Menus.FirstOrDefaultAsync(p => p.MenusID == id);
            //bar.Image = await dbContext.Image.FirstOrDefaultAsync(i => i.Id == bar.IdImage);
            return menu;
        }

        // [HttpGet("image/{id}")]
        // public async Task<IEnumerable<Bar>> GetByImageId(Guid id)
        // {
        //     return await dbContext.Bars.Where(p => p.Image.Id == id).ToListAsync();
        // }


        [HttpDelete("{id}")]
        public async Task DeleteById(Guid id)
        {
            var item = await dbContext.Menus.FirstOrDefaultAsync(p => p.MenusID == id);
            dbContext.Menus.Remove(item);
            await dbContext.SaveChangesAsync();

        }

        [HttpPut]
        public async Task<Menus> UpdateById(Menus item)
        {
            var itemPrevious = await dbContext.Menus.FirstOrDefaultAsync(p => p.MenusID == item.MenusID);

            if (itemPrevious != null)
            {
                itemPrevious.Link = item.Link;
                itemPrevious.BarsID = item.BarsID;

                await dbContext.SaveChangesAsync();
            }

            return itemPrevious;

        }

        [HttpPost]
        public async Task<Menus> InsertMenus(Menus menu)
        {
            dbContext.Menus.Add(menu);
            await dbContext.SaveChangesAsync();

            return menu;
        }

    }
}
