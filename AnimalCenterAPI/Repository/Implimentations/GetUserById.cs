using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;

namespace AnimalCenterAPI.Repository.Implimentations
{
    public class GetUserById : IUserRepository
    {
        public User UserMappper(UserDTO userDTO)
        {
            return new User
            {
                Id = userDTO.Id,
                Name = userDTO.firstname ?? string.Empty,
                lastname = userDTO.lastname ?? string.Empty,
                Email = userDTO.Email ?? string.Empty,
                Password = userDTO.Password ?? string.Empty,
                UserName = userDTO.UserName ?? string.Empty,
                UserRole = userDTO.UserRole ?? default
            };
        }
    }
}
