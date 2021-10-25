using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.API.DataTransferObjects
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName{ get; set; }

    }
}
