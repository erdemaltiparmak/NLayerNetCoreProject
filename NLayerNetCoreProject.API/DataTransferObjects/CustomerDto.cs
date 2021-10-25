using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.API.DataTransferObjects
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string IdentificationNumber { get; set; }

    }
}
