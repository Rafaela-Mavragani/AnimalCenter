using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;

namespace AnimalCenterAPI.Repository.Implimentations
{
    public class UserRepository : IUserRepository
    {
        public User UserMappper(UserDTO userDTO)
        {
            return new User
            {
                
                Name = userDTO.firstname ?? string.Empty,
                lastname = userDTO.lastname ?? string.Empty,
                Email = userDTO.Email ?? string.Empty,
                Password = userDTO.Password ?? string.Empty,
                UserName = userDTO.UserName ?? string.Empty,
                UserRole = userDTO.UserRole ?? default
            };
        }

        public User UserById(UserToUpdateDTO userToUpdateDTO)
        {
            return new User
            {
                Id = userToUpdateDTO.Id,
                Name = userToUpdateDTO.FirstName ?? string.Empty,
                lastname = userToUpdateDTO.LastName ?? string.Empty,
                Email = userToUpdateDTO.Email ?? string.Empty,
                Password = userToUpdateDTO.Password ?? string.Empty,
                UserName = userToUpdateDTO.UserName ?? string.Empty
            };
        }
    }
    
}
