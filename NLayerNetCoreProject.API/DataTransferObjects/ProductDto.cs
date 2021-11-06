using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.API.DataTransferObjects
{
    public class ProductDto
    {
        [Required(ErrorMessage = "Kategori Gerekli")]
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Ad gerekli")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ad gerekli")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Ad gerekli")]//Range kullanmalıyım sayısal verilerin defaultları var
        public decimal ProductPrice { get; set; }
      
    }
}
