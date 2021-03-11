using System.Collections.Generic;
namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual ICollection<Review> Reviews { get; set;}
    public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }
  }
}