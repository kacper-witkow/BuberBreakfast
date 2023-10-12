using BuberBreakfast.Models;
using Microsoft.EntityFrameworkCore;

public class BreakfastDb : DbContext
{

    public BreakfastDb(DbContextOptions<BreakfastDb> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Breakfast>()
            .Property(e => e.Savory)
            .HasConversion(
            s => string.Join(',', s),
            s => s.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());


    }


    public DbSet<Breakfast> Breakfasts { get; set; }
}