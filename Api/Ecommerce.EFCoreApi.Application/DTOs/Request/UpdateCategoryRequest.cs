using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }

        public String Name { get; set; }


        public UpdateCategoryRequest(string name)
        {

            Name = name;
        }


        public static Categories ToEntity(UpdateCategoryRequest request)
        {
            return new Categories
            (
                request.Id,
                request.Name
            );
        }
    }
}