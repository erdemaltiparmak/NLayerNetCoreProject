using Microsoft.EntityFrameworkCore;
using NLayerNetCoreProject.Core.Entity;
using NLayerNetCoreProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private NLayerDbContext dbContext { get => _dbContext as NLayerDbContext; }
        public CategoryRepository(NLayerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await dbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.CategoryId == categoryId);
        }
    }
}
