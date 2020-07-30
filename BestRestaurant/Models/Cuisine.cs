using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
    
    public int CuisineId { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}