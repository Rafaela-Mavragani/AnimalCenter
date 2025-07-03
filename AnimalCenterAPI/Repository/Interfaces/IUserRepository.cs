using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Repository.Interfaces
{
    public interface IUserRepository
    {
        User UserMappper(UserDTO userDTO);
    }
}
