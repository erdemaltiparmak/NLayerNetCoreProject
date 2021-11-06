using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerNetCoreProject.API.DataTransferObjects;
using NLayerNetCoreProject.Core.Entity;
using NLayerNetCoreProject.Core.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IService<Customer> _customerService;
        private readonly IMapper _mapper;
        public CustomerController(IService<Customer> customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CustomerDto>>(customers));
        }
        [HttpPost]
        public async Task<IActionResult> Add(Customer customer)
        {
            var c =await _customerService.AddAsync(customer);

            return Ok(_mapper.Map<CustomerDto>(customer));

        }
    }
}
