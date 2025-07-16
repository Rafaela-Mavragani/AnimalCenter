using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Enums;
using AnimalCenterApp.Helpers;
using System.Data;
using System.Security.Claims;

namespace AnimalCenterApp.Services
{
    public class AuthDataService : IAuthDataService
    {
        private static readonly Dictionary<string, UserDTO> Users = new()
        {
            { "admin@acme.com", new UserDTO { UserName = "admin@acme.com", UserRole = UserRole.Admin } },
            { "super@acme.com", new UserDTO { UserName = "super@acme.com", UserRole = UserRole.Volunteer } }
        };

        public ServiceResponse<ClaimsPrincipal> Login(string userName, string password)
        {
            if (!Users.ContainsKey(userName))
            {
                return new ServiceResponse<ClaimsPrincipal>(
                    "Unknown user, please enter super@acme.com or admin@acme.com");
            }

            var user = Users[userName];

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName!),
                new Claim(ClaimTypes.Role, user.UserRole.ToString()!)
            };

            var identity = new ClaimsIdentity(claims, "jwt");
            var principal = new ClaimsPrincipal(identity);

            return new ServiceResponse<ClaimsPrincipal>("Login successful", true, principal);
        }
    }
}
