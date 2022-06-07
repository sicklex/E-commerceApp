using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class DiscountRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Discount_Percent { get; set; }

        public DateTime Created_at { get; set; }

        public DiscountRequest(string name, string description, decimal discount_Percent)
        {
            Name = name;
            Description = description;
            Discount_Percent = discount_Percent;
            Created_at = DateTime.Now;
        }


        public static Discount ToEntity(DiscountRequest request)
        {
            return new Discount
            {
                Name = request.Name,
                Description = request.Description,
                Discount_Percent = request.Discount_Percent,
                Created_at = request.Created_at
            };
        }


    }
}