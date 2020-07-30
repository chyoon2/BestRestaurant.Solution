namespace BestRestaurant.Models
{
  public class Rating
  {
    public int RatingId { get; set; }
    public int RestaurantId { get; set; }
    public int Score { get; set; }
    public string Review { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}