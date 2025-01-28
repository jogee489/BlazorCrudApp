using BlazorCrudApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }

        public DbSet<Game> Games { get; set; } 
    }
}
