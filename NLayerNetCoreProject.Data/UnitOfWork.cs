using NLayerNetCoreProject.Core.Interface;
using NLayerNetCoreProject.Core.Repository;
using NLayerNetCoreProject.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NLayerDbContext _dbContext;
        private CategoryRepository categoryRepository;
        private ProductRepository  productRepository;

        public IProductRepository Products => productRepository ??= new ProductRepository(_dbContext);
        public ICategoryRepository Categories => categoryRepository ??= new CategoryRepository(_dbContext);

        public UnitOfWork(NLayerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
