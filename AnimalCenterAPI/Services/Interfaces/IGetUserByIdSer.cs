using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IGetUserByIdSer
    {
        Task<User?> GetUserByIdAsync(int id);
    }
}
