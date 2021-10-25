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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<CategoryDto>>(categories);
            return Ok(dto);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var dto = _mapper.Map<CategoryDto>(category);
            return Ok(dto);
        }

        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetWithProductsById(int id)
        {
            var entity = await _categoryService.GetWithProductsByIdAsync(id);

            return Ok(_mapper.Map<CategoryWithProductsDto>(entity));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {
            var entity = _mapper.Map<Category>(categoryDto);
            await _categoryService.AddAsync(entity);
            return Created(String.Empty,_mapper.Map<CategoryDto>(entity));
        }

        [HttpPut]
        public IActionResult Update(CategoryDto categoryDto)
        {
            var entity = _categoryService.Update(_mapper.Map<Category>(categoryDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var entity = _categoryService.GetByIdAsync(id).Result;
            _categoryService.Remove(entity);
            return NoContent();
        }

    }
}
