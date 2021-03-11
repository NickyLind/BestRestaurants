namespace BestRestaurants.Models
{
  public class Review
  {
    public string Description { get; set; }
    public int ReviewId { get; set; }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}