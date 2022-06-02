using System.ComponentModel.DataAnnotations;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class UserLoginRequest
    {

        [Required(ErrorMessage = "The field {0} is required.")]
        [EmailAddress(ErrorMessage = "The field {0} is in invalid format.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        public string Password { get; set; }

    }
}