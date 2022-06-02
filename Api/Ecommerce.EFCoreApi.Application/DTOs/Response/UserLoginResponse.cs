using System.Text.Json.Serialization;

namespace Ecommerce.EFCoreApi.Application.DTOs.Response
{
    public class UserLoginResponse
    {
        public bool Success => Errors.Count == 0;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string AcecessToken { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string RefreshToken { get; set; }

        public List<string> Errors { get; set; }


        public UserLoginResponse() => Errors = new List<string>();

        public UserLoginResponse(bool Success, string accessToken, string refreshToken) : this()
        {
            AcecessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public void AddError(string error) => Errors.Add(error);
        public void AddErrors(IEnumerable<string> errors) => Errors.AddRange(errors);
    }
}