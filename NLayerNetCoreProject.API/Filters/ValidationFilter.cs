using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NLayerNetCoreProject.API.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.API.Filters
{
    public class ValidationFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values.SelectMany(e => e.Errors).ToList();
                var errorDto = new ErrorDto 
                {
                    Errors=errors.Select(e=> e.ErrorMessage).ToList(),
                    Status=System.Net.HttpStatusCode.BadRequest
                };

                context.Result = new BadRequestObjectResult(errorDto);

            }
        }
    }
}
