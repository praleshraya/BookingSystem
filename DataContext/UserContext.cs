using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;

namespace BookingSystem.DataContext

{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        { 
        
        }

        public DbSet<User> Users { get; set; }
       
    }
}
