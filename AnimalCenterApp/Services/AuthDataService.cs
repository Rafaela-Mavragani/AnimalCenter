using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Enums;
using AnimalCenterApp.Helpers;
using System.Security.Claims;
using System.Net.Http.Json;

namespace AnimalCenterApp.Services
{
    public class AuthDataService : IAuthDataService
    {
        private readonly HttpClient _http;

        public AuthDataService(HttpClient http)
        {
            _http = http;
        }

        ServiceResponse<ClaimsPrincipal> IAuthDataService.Login(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                return new ServiceResponse<ClaimsPrincipal>("Username and password are required.");
            }

            var loginDto = new LoginDTO
            {
                UserName = userName,
                Password = password
            };

            try
            {
                var responseTask = _http.PostAsJsonAsync("api/auth/login", loginDto);
                responseTask.Wait();
                var response = responseTask.Result;

                if (!response.IsSuccessStatusCode)
                {
                    var errorTask = response.Content.ReadAsStringAsync();
                    errorTask.Wait();
                    var error = errorTask.Result;
                    return new ServiceResponse<ClaimsPrincipal>($"❌ Login failed: {error}");
                }

                var userTask = response.Content.ReadFromJsonAsync<UserDTO>();
                userTask.Wait();
                var user = userTask.Result;

                if (user is null || string.IsNullOrWhiteSpace(user.UserName))
                {
                    return new ServiceResponse<ClaimsPrincipal>("Invalid response from server.");
                }

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName!),
                        new Claim(ClaimTypes.Role, user.UserRole.ToString()!)
                    };

                var identity = new ClaimsIdentity(claims, "jwt");
                var principal = new ClaimsPrincipal(identity);

                return new ServiceResponse<ClaimsPrincipal>("✅ Login successful", true, principal);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<ClaimsPrincipal>($"❌ Login request failed: {ex.Message}");
            }
        }
    }
}