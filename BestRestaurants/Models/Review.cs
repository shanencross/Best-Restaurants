namespace BestRestaurants.Models 
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string ReviewText { get; set; }
    public int StarRating { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}