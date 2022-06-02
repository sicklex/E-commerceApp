using System.Collections.Generic;
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

    }
}