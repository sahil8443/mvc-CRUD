using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using demo.Models; // Ensure this matches your namespace

namespace demo.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }  // Replace 'User' with your actual model
    }
}
