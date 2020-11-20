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
    public class ImageController
    {
        private readonly EventContext dbContext;

        public ImageController(ILogger<ImageController> logger, EventContext context)
        {
            this.dbContext = context;
            //this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Image> GetAll()
        {
            return dbContext.Image.ToList();
        }

        [HttpGet("{id}")]
        public async Task<Image> GetById(Guid id)
        {
            var image = await dbContext.Image.FirstOrDefaultAsync(p => p.ImageID == id);
            //bar.Image = await dbContext.Image.FirstOrDefaultAsync(i => i.Id == bar.Image.Id).Select(i => i.Image);
            //Product.CategoryList = await dbContext.CategoryProduct.Where(cp => cp.ProductID == Product.ProductID).Select(pro => pro.category).             
            return image;
        }

        [HttpDelete("{id}")]
        public async Task DeleteById(Guid id)
        {
            var image = await dbContext.Image.FirstOrDefaultAsync(p => p.ImageID == id);
            dbContext.Image.Remove(image);
            await dbContext.SaveChangesAsync();
        }

        [HttpPut]
        public async Task<Image> UpdateById(Image image)
        {
            var imageToUpdate = await dbContext.Image.FirstOrDefaultAsync(p => p.ImageID == image.ImageID);

            if (imageToUpdate != null)
            {
                imageToUpdate.Link = image.Link;
                await dbContext.SaveChangesAsync();
            }
            return imageToUpdate;
        }

        [HttpPost]
        public async Task<Image> InsertCategory(Image image)
        {
            dbContext.Image.Add(image);
            await dbContext.SaveChangesAsync();

            return image;
        }

        
    }
}
