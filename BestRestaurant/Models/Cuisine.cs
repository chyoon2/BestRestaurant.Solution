using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Region { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}