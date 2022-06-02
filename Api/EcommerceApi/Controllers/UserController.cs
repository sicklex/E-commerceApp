
using Ecommerce.EFCoreApi.Application.DTOs.Request;
using Ecommerce.EFCoreApi.Application.DTOs.Response;
using Ecommerce.EFCoreApi.Application.Interfaces.Services;
using EcommerceApi.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    public class UserController : ApiControllerBase
    {

        private IIdentityService _identityService;

        public UserController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost("register")]

        public async Task<ActionResult<UserRegistrationResponse>> Register(UserRegistrationRequest userRegistration)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _identityService.UserRegistration(userRegistration);

            if (result.Success)
                return Ok(result);
            else if (result.Errors.Count > 0)
            {
                return BadRequest(result);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }


        [HttpPost("login")]

        public async Task<ActionResult<UserLoginResponse>> Login(UserLoginRequest userLogin)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _identityService.UserLogin(userLogin);

            if (result.Success)
                return Ok(result);

            return Unauthorized(result);
        }
    }
}