using BuberBreakfast.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
namespace BuberBreakfast.Database
{
    public class DataContext : DbContext
    { 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Breakfast> Breakfasts { get; set; }
    }
}
