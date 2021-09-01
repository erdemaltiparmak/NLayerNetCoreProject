using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerNetCoreProject.Core.Interface.Service
{
    public interface IProductService:IService<Product>
    {
        bool ControlBarcode(Product product);

    }
}
