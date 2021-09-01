using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Core.Interface
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
