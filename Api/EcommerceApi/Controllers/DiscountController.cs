using Ecommerce.EFCoreApi.Application.DTOs.Request;
using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services;
using EcommerceApi.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    public class DiscountController : ApiControllerBase
    {
        private IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]

        public async Task<IEnumerable<Discount>> GetAll()
        {
            return await _discountService.GetAllAsync();
        }

        [HttpGet("{id}")]

        public async Task<Discount> GetById(int id)
        {
            var discount = await _discountService.GetByIdAsync(id);


            return discount;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Add(DiscountRequest discountRequest)
        {
            var discount = DiscountRequest.ToEntity(discountRequest);

            var id = await _discountService.AddAsync(discount);

            return CreatedAtAction(nameof(GetById), new { id = id }, id);
        }
    }
}