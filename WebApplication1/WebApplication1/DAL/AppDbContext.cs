using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Model;

namespace WebApplication1.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Actor> Actors { get; set; }
    }
}
