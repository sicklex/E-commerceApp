using Ecommerce.EFCoreApi.Application.DTOs.Request;
using Ecommerce.EFCoreApi.Application.DTOs.Response;
using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services;
using EcommerceApi.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    public class InventoryController : ApiControllerBase
    {
        private IIventoryService _inventoryService;

        public InventoryController(IIventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<InventoryResponse>> GetById(int id)
        {
            var productInventory = await _inventoryService.GetByIdAsync(id);
            if (productInventory == null)
                return NotFound();

            var productInventoryResponse = InventoryResponse.ToDTO(productInventory);
            return Ok(productInventoryResponse);
        }

        [HttpPost]

        public async Task<ActionResult<int>> Add(InventoryRequest productInventory)
        {
            var id = InventoryRequest.ToEntity(productInventory);
            await _inventoryService.AddAsync(id);
            return CreatedAtAction(nameof(GetById), new { id = id.Id }, id.Id);
        }

        [HttpPut]

        public async Task<ActionResult> Update(UpdateInventoryRequest productInventory)
        {
            var id = UpdateInventoryRequest.ToEntity(productInventory);
            await _inventoryService.UpdateAsync(id);
            return Ok();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            await _inventoryService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}