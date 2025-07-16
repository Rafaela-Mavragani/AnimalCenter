using AnimalCenterApp.Helpers;
using System.Security.Claims;

namespace AnimalCenterApp.Services
{
    public interface IAuthDataService
    {
        ServiceResponse<ClaimsPrincipal> Login(string userName, string password);
    }
}
