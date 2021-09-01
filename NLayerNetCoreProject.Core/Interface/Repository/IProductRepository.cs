using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Core.Repository
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
