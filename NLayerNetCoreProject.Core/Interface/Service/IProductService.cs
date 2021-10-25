using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Core.Interface.Service
{
    public interface IProductService:IService<Product>
    {
        bool ControlBarcode(Product product);
        Task<Product> GetWithCategoryByIdAsync(int productId);

    }
}
