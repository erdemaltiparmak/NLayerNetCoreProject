using NLayerNetCoreProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Core.Interface
{
    public interface IUnitOfWork
    { 
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task CommitAsync();
        void Commit();
    }
}
