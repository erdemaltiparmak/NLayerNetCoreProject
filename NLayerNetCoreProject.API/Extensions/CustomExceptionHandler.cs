using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using NLayerNetCoreProject.API.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.API.Extensions
{
    public static class CustomExceptionHandler
    {
        public static void UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(c => c.Run(async handler =>
            {
                handler.Response.StatusCode = 500;
                handler.Response.ContentType = "application/json";
                var error = handler.Features.Get<IExceptionHandlerFeature>();

                if (error != null)
                {
                    var exception = error.Error;
                    var errorDto = new ErrorDto();
                    errorDto.Status = System.Net.HttpStatusCode.InternalServerError;
                    errorDto.Errors = new List<string> { exception.Message };
                    await handler.Response.WriteAsync(JsonConvert.SerializeObject(errorDto));
                }

            }));
        }
    }
}
