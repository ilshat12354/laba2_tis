using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace laba2_tis.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
        base(options)
        {
            Database.EnsureCreated();
        }
    }
}