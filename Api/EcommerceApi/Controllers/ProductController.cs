using System.Collections.Generic;
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
        private readonly IProductService _productService;

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

        public async Task<ActionResult<int>> Add(PostProductRequest productRequest)
        {
            var product = PostProductRequest.ToEntity(productRequest);
            var id = await _productService.AddAsync(product);

            return CreatedAtAction(nameof(GetById), new { id = id }, id);
        }

    }
}