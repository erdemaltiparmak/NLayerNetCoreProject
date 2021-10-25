using NLayerNetCoreProject.Core.Entity;
using NLayerNetCoreProject.Core.Interface;
using NLayerNetCoreProject.Core.Interface.Service;
using NLayerNetCoreProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Service.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository) { }

        public bool ControlBarcode(Product product)
        {
            return true;
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
           return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
