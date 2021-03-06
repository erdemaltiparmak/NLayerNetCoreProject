using NLayerNetCoreProject.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerNetCoreProject.Core.Entity
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal ProductPrice { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted  { get; set; }
        public int CategoryId { get; set; }
        public string Barcode { get; set; }

        public virtual Category Category{ get; set; }

    }

}
