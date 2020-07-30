using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Ratings = new HashSet<Rating>();
    }
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    public string Name { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //allows in workbench to set a default value. rather than null. 
    public string Location { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PhoneNumber { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Rating { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual ICollection<Rating> Ratings { get; set; }
  }
}