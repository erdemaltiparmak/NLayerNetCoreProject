using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayerNetCoreProject.Core.DataTransferObjects;
using NLayerNetCoreProject.Core.Entity;
using NLayerNetCoreProject.Core.Interface.Service;
using NLayerNetCoreProject.Web.APIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryAPIService _categoryAPIService;
        private readonly IMapper _mapper;
        public CategoryController(IMapper mapper, CategoryAPIService categoryAPIService)
        {
            _categoryAPIService = categoryAPIService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryAPIService.GetAllAsync();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            await _categoryAPIService.AddAsync(categoryDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryAPIService.GetByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            await _categoryAPIService.Update(categoryDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryAPIService.Remove(id);
            return RedirectToAction("Index");
        }

    }
}
