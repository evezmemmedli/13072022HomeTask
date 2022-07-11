using _13072022HomeTask.Models;
using Microsoft.EntityFrameworkCore;

namespace _13072022HomeTask.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
