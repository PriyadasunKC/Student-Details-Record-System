using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data {
    public class AppDbContext:DbContext {
        public AppDbContext(DbContextOptions <AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Models.Student> Students{ get; set; }
    }
}