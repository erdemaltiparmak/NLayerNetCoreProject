using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Web.APIService
{
    public static class RequestHelper
    {
        public static StringContent CreateStringContent(object obj)
        {
            return  new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

        }
        
    }
}
