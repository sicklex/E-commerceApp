using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class CategoryRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public CategoryRequest(int id, string name)
        {
            Name = name;
        }

        public static Categories ToEntity(CategoryRequest request)
        {
            return new Categories
            (
                request.Id,
                request.Name
            );
        }
    }
}