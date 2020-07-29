using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisine { get; set; }
    public DbSet<Item> Items { get; set; }
    public BestRestaurantContext(DbContextOptions options) : base(options) {}
  }
}