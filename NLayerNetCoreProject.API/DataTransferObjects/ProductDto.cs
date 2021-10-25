using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.API.DataTransferObjects
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
