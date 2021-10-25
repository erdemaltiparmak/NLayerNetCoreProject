using NLayerNetCoreProject.Core.Entity;
using NLayerNetCoreProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Core.Interface.Service
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);

    }
}
