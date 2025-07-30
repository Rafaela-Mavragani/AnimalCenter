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
        public async Task<User?> GetUserByIdAsync(int id)
        {
            var user = await context.Users.FindAsync(id);

            return user;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        
        public async Task<AnimalTask?> GetAnimalTaskByIdAsync(int id)
        {
            return await context.AnimalTasks.FindAsync(id);
        }

    }

}

