using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class ReviewController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public ReviewController(BestRestaurantsContext db)
    {
      _db = db;
    }
    public ActionResult Create()
    {
      ViewBag.RestaurantId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Index", "Restaurants");
    }
    public ActionResult Details(int id)
    {
      Review thisReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
      return View(thisReview);
    }
    public ActionResult Edit(int id)
    {
      var thisReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
      ViewBag.RestaurantId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
      return View(thisReview);
    }
    [HttpPost]
    public ActionResult Edit(Review review)
    {
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index", "Restaurants");
    }
    public ActionResult Delete(int id)
    {
      var thisReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
      _db.Reviews.Remove(thisReview);
      _db.SaveChanges();
      return RedirectToAction("Index", "Restaurants");
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
      _db.Reviews.Remove(thisReview);
      _db.SaveChanges();
      return RedirectToAction("Index", "Restaurants");
    }
  }
}