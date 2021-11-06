using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.API.DataTransferObjects
{
    public class ErrorDto
    {
        public List<String> Errors{ get; set; }
        public HttpStatusCode  Status { get; set; }
    }
}
