using Ecommerce.EFCoreApi.Application.DTOs.Request;
using Ecommerce.EFCoreApi.Application.DTOs.Response;
using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services;
using EcommerceApi.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    public class ProductController : ApiControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAll()
        {
            var products = await _productService.GetAllAsync();
            var productResponses = products.Select(p => ProductResponse.ToDTO(p));
            return Ok(productResponses);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<ProductResponse>> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
                return NotFound();
            var productResponse = ProductResponse.ToDTO(product);
            return Ok(productResponse);
        }


        [HttpPost]

        public async Task<ActionResult<int>> Add(AddProductRequest productRequest)
        {
            var product = AddProductRequest.ToEntity(productRequest);
            var id = (int)await _productService.AddAsync(product);

            return CreatedAtAction(nameof(GetById), new { id = id }, id);
        }


        [HttpPut]

        public async Task<ActionResult> Update(UpdateProductRequest productRequest)
        {
            var product = UpdateProductRequest.ToEntity(productRequest);
            await _productService.UpdateAsync(product);
            return Ok();
        }


        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            await _productService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}