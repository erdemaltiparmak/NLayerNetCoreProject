using NLayerNetCoreProject.Core.Entity;
using NLayerNetCoreProject.Core.Interface;
using NLayerNetCoreProject.Core.Interface.Service;
using NLayerNetCoreProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Service.Service
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository) { }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await  _unitOfWork.Categories.GetWithProductsByIdAsync(categoryId);
        }
    }
}
