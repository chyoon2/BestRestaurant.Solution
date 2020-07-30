using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    public string Name { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Location { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PhoneNumber { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Rating { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}