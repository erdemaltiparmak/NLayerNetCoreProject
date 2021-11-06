using NLayerNetCoreProject.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerNetCoreProject.Core.Entity
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string IdentificationNumber { get; set; }

    }
}
