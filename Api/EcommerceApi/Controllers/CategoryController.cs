using Ecommerce.EFCoreApi.Application.DTOs.Request;
using Ecommerce.EFCoreApi.Application.DTOs.Response;
using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services;
using EcommerceApi.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    public class CategoryController : ApiControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]

        public async Task<ActionResult<CategoryResponse>> GetAll()
        {
            try
            {
                var categories = await _categoryService.GetAllAsync();
                var categoriesResponse = categories.Select(category => CategoryResponse.ToDTO(category));
                return Ok(categoriesResponse);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<CategoryResponse>> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
                return NotFound();

            var categoryResponse = CategoryResponse.ToDTO(category);
            return Ok(categoryResponse);
        }


        [HttpPost]

        public async Task<ActionResult> Add(CategoryRequest category)
        {
            var id = CategoryRequest.ToEntity(category);
            await _categoryService.AddAsync(id);
            return CreatedAtAction(nameof(GetById), new { id = id.Id }, id.Id);
        }

        [HttpPut]

        public async Task<ActionResult> Update(UpdateCategoryRequest Category)
        {
            var id = UpdateCategoryRequest.ToEntity(Category);
            await _categoryService.UpdateAsync(id);
            return Ok();
        }


        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            await _categoryService.DeleteByIdAsync(id);
            return Ok();
        }

    }
}