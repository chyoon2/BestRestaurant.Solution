using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public virtual DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public BestRestaurantContext(DbContextOptions options) : base(options) {}
  }
}