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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var dto = _mapper.Map<ProductDto>(product);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var entity = _mapper.Map<Product>(productDto);
            await _productService.AddAsync(entity);
            return Created(String.Empty, _mapper.Map<ProductDto>(entity));
        }

        [HttpPut]
        public IActionResult Update(ProductDto productDto)
        {
            var entity = _productService.Update(_mapper.Map<Product>(productDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var entity = _productService.GetByIdAsync(id).Result;
            _productService.Remove(entity);
            return NoContent();
        }

    }
}
