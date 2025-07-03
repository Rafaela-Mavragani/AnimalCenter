using AnimalCenterAPI.Data;
using AnimalCenterAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class GetUserByIdSer(AnimalAppDbContext context) : IGetUserByIdSer
    {
        public async Task<User?> GetUserByIdAsync(int id)
        {
            var user = await context.Users.FindAsync(id);

            return user;
        }
    }
    
}
