using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public RestaurantsController(BestRestaurantsContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {

      return View(_db.CuisineRestaurant.ToList());
    }
    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      return View();
    }
    [HttpPost]
    public ActionResult Create (Restaurant restaurant, int CuisineId)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      if (CuisineId != 0)
      {
        _db.CuisineRestaurant.Add(new CuisineRestaurant() { CuisineId = CuisineId, RestaurantId = restaurant.RestaurantId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisRestaurant = _db.Restaurants
      .Include(rest => rest.JoinEntities)
      .ThenInclude(join => join.Cuisine)
      .FirstOrDefault(rest => rest.RestaurantId == id);
      return View(thisRestaurant);
    }
    public ActionResult Edit(int id)
    {
      var thisRestaurant = _db.Restaurants
      .Include(rest => rest.JoinEntities)
      .ThenInclude(join => join.Cuisine)
      .FirstOrDefault(rest => rest.RestaurantId == id);
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      return View(thisRestaurant);
    }
    [HttpPost]
    public ActionResult Edit(Restaurant restaurant, int CuisineId, int joinId)
    {
      if (CuisineId != 0)
      {
        var joinEntry = _db.CuisineRestaurant.FirstOrDefault(entry => entry.CuisineRestaurantId == joinId);
        _db.CuisineRestaurant.Remove(joinEntry);    
        _db.CuisineRestaurant.Add(new CuisineRestaurant() { CuisineId = CuisineId, RestaurantId = restaurant.RestaurantId});
      }
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
      
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      return View(thisRestaurant);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      _db.Restaurants.Remove(thisRestaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult AddCuisine(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      return View(thisRestaurant);
    }
    [HttpPost]
    public ActionResult AddCuisine(Restaurant restaurant, int CuisineId)
    {
      if (CuisineId != 0)
      {
        _db.CuisineRestaurant.Add(new CuisineRestaurant() { CuisineId = CuisineId, RestaurantId = restaurant.RestaurantId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult DeleteCuisine(int joinId)
    {
      var joinEntry = _db.CuisineRestaurant.FirstOrDefault(entry => entry.CuisineRestaurantId == joinId);
      _db.CuisineRestaurant.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}