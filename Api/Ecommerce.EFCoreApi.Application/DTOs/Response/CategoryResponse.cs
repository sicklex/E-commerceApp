using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Response
{
    public class CategoryResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public CategoryResponse(int categoryId, string name)
        {
            Id = categoryId;
            Name = name;
        }


        public static CategoryResponse ToDTO(Categories category)
        {
            return new CategoryResponse
            (
                category.Id,
                category.Name
            );
        }

    }
}