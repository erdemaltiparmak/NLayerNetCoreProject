using Microsoft.AspNetCore.Mvc.Filters;
using NLayerNetCoreProject.Core;
using NLayerNetCoreProject.Core.Interface.Service;
using NLayerNetCoreProject.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLayerNetCoreProject.API.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace NLayerNetCoreProject.API.Filters
{

    public class NotFoundFilter<T> : IAsyncActionFilter where T: IEntity
    {
        private readonly IService<T> service;


        public NotFoundFilter(IService<T> service)
        {
            this.service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var obj = context.ActionArguments.Values.FirstOrDefault();

            var entity = await service.GetByIdAsync(Convert.ToInt32(obj));

            if (entity != null) await next();
            else
            {
                Type type = typeof(T);
                var dto = new ErrorDto();
                dto.Status = System.Net.HttpStatusCode.NotFound;
                dto.Errors = new List<string> { $"{type.Name} Bulunamadı" };

                context.Result = new NotFoundObjectResult(dto);
            }
        }
    }
}
