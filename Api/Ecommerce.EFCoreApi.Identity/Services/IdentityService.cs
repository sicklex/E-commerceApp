using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Ecommerce.EFCoreApi.Application.DTOs.Request;
using Ecommerce.EFCoreApi.Application.DTOs.Response;
using Ecommerce.EFCoreApi.Application.Interfaces.Services;
using Ecommerce.EFCoreApi.Identity.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Ecommerce.EFCoreApi.Identity.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtOptions _jwtOptions;

        public IdentityService(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IOptions<JwtOptions> jwtOptions)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _jwtOptions = jwtOptions.Value;
        }


        public async Task<UserRegistrationResponse> UserRegistration(UserRegistrationRequest userRegistration)
        {
            var user = new IdentityUser
            {
                UserName = userRegistration.UserName,
                Email = userRegistration.UserName,
                EmailConfirmed = true,
            };

            var result = await _userManager.CreateAsync(user, userRegistration.Password);

            if (!result.Succeeded)
                await _userManager.SetLockoutEnabledAsync(user, false);

            var UserRegistrationResponse = new UserRegistrationResponse(result.Succeeded);

            if (!result.Succeeded && result.Errors.Count() > 0)
                UserRegistrationResponse.AddError(result.Errors.Select(e => e.Description));

            return UserRegistrationResponse;
        }
        public async Task<UserLoginResponse> UserLogin(UserLoginRequest userLogin)
        {
            var result = await _signInManager.PasswordSignInAsync(userLogin.UserName, userLogin.Password, false, true);
            if (result.Succeeded)
                return await CredentialGenerator(userLogin.UserName);

            var UserLoginResponse = new UserLoginResponse();

            if (!result.Succeeded)
            {
                if (result.IsLockedOut)
                    UserLoginResponse.AddError("User is locked out");
                else if (result.IsNotAllowed)
                    UserLoginResponse.AddError("User is not allowed");
                else if (result.RequiresTwoFactor)
                    UserLoginResponse.AddError("User requires two factor authentication");
                else
                    UserLoginResponse.AddError("Login or password is incorrect");
            }
            return UserLoginResponse;
        }

        private async Task<UserLoginResponse> CredentialGenerator(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var accessTokenClaims = await GetClaims(user, addUserClaims: true);
            var refreshTokenClaims = await GetClaims(user, addUserClaims: false);

            var accesstokenExpiration = DateTime.Now.AddSeconds(_jwtOptions.AccessTokenExpiration);
            var refreshTokenExpiration = DateTime.Now.AddSeconds(_jwtOptions.RefreshTokenExpiration);

            var accessToken = TokenGenerator(accessTokenClaims, accesstokenExpiration);
            var refreshToken = TokenGenerator(refreshTokenClaims, refreshTokenExpiration);

            return new UserLoginResponse(
                Success: true,
                accessToken: accessToken,
                refreshToken: refreshToken
            );
        }


        private string TokenGenerator(IEnumerable<Claim> claims, DateTime expirationDate)
        {
            var jwt = new JwtSecurityToken(
                         issuer: _jwtOptions.Issuer,
                         audience: _jwtOptions.Audience,
                         claims: claims,
                         notBefore: DateTime.Now,
                         expires: expirationDate,
                         signingCredentials: _jwtOptions.SigningCredentials);

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }


        private async Task<IList<Claim>> GetClaims(IdentityUser user, bool addUserClaims)
        {
            var claims = new List<Claim>();

            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Id));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Nbf, DateTime.Now.ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString()));

            if (addUserClaims)
            {
                var userClaims = await _userManager.GetClaimsAsync(user);
                var roles = await _userManager.GetRolesAsync(user);

                claims.AddRange(userClaims);

                foreach (var role in roles)
                    claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

    }
}