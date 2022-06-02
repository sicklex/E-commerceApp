using System.ComponentModel.DataAnnotations;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request;
public class UserRegistrationRequest
{
    [Required(ErrorMessage = "The field {0} is required.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "The field {0} is required.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "The field {0} is required.")]
    [EmailAddress(ErrorMessage = "The field {0} is in invalid format.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "The field {0} is required.")]
    public string Password { get; set; }

    [Compare(nameof(Password), ErrorMessage = "The field {0} and {1} must be equals.")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "The field {0} is required.")]
    public string PhoneNumber { get; set; }
}