using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerNetCoreProject.Core.Entity
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        

        public ICollection<Product> Products { get; set; }
    }
}
