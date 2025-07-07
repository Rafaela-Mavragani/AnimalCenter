using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateNewUserAsync(User User);
        Task<User?> GetUserByIdAsync(int id);
        Task<bool> DeleteAsync(int id);

    }
}
