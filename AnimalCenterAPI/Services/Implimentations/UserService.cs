using AnimalCenterAPI.Data;
using AnimalCenterAPI.Services.Interfaces;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class UserService(AnimalAppDbContext context) : IUserService
    {
        readonly AnimalAppDbContext _context = context;
        public async Task<User> CreateNewUserAsync(User User)
        {
            _context.Users.Add(User);
            await _context.SaveChangesAsync();
            return User;
    
        }

        
    }
}
