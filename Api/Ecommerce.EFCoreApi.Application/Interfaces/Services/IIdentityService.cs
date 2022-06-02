using Ecommerce.EFCoreApi.Application.DTOs.Request;
using Ecommerce.EFCoreApi.Application.DTOs.Response;

namespace Ecommerce.EFCoreApi.Application.Interfaces.Services;
public interface IIdentityService
{
    Task<UserRegistrationResponse> UserRegistration(UserRegistrationRequest userRegistration);

    Task<UserLoginResponse> UserLogin(UserLoginRequest userLogin);

}