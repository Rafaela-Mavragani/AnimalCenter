using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateNewUserAsync(User User);
       
    }
}
