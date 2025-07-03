using Microsoft.AspNetCore.Mvc;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAnimalDelete
    {
        Task<bool> DeleteAsync(int id);
    }
}
