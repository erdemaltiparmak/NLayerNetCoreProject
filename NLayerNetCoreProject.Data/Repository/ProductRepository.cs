using Microsoft.EntityFrameworkCore;
using NLayerNetCoreProject.Core.Entity;
using NLayerNetCoreProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private NLayerDbContext dbContext { get => _dbContext as NLayerDbContext; }
        public ProductRepository(NLayerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            var product = dbContext.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.ProductId == productId);
            return await product;
        }
       
    }
}
