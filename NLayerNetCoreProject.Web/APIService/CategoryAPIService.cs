using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLayerNetCoreProject.Core.DataTransferObjects;
using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Web.APIService
{
    public class CategoryAPIService
    {
        private readonly HttpClient _httpClient;
        private readonly string uri = "category";
        public CategoryAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpPost]
        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var categories = JsonConvert.DeserializeObject<IEnumerable<CategoryDto>>(await response.Content.ReadAsStringAsync());
                return categories;
            }
            else return null;
        }

        public async Task<CategoryDto> AddAsync(CategoryDto categoryDto)
        {
            var stringContent = RequestHelper.CreateStringContent(categoryDto);
            var response = await _httpClient.PostAsync(uri, stringContent);

            if (response.IsSuccessStatusCode)
            {
                categoryDto = JsonConvert.DeserializeObject<CategoryDto>(await response.Content.ReadAsStringAsync());
                return categoryDto;
            }
            else return null;
        }
        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync(uri+$"/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CategoryDto>(await response.Content.ReadAsStringAsync());
            }
            else return null;
        }

        public async Task<bool> Update(CategoryDto categoryDto)
        {
            var stringContent = RequestHelper.CreateStringContent(categoryDto);
            var response = await _httpClient.PutAsync(uri, stringContent);

            return response.IsSuccessStatusCode;

        }

        public async Task<bool> Remove(int id)
        {
            var response = await _httpClient.DeleteAsync(uri + $"/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
