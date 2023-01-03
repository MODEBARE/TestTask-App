using Microsoft.EntityFrameworkCore;
using TestTaskApp.Models;

namespace TestTaskApp.Data
{
    public class TestTaskDbContext: DbContext
    {
        public TestTaskDbContext(DbContextOptions<TestTaskDbContext> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
    }

}
