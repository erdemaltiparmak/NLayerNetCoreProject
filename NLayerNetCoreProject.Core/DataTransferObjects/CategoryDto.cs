using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Core.DataTransferObjects
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="{0} alanı boş olamaz")]
        public string CategoryName{ get; set; }

    }
}
