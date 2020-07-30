using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Linq;

namespace BestRestaurant.Controllers
{
  public class RatingController : Controller
  {
    private readonly BestRestaurantContext _db;

    public RatingController(BestRestaurantContext db)
    {
      _db = db;
    }
    public ActionResult Create(int id)
    {
      ViewBag.RestaurantId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Rating rating)
    {
      _db.Ratings.Add(rating);
      _db.SaveChanges();
      return RedirectToAction("Show", "Restaurant", new {id = rating.RestaurantId});
    }

    public ActionResult Edit(int id)
    {
      Rating thisRating = _db.Ratings.FirstOrDefault(ratings => ratings.RatingId == id);
      return View(thisRating);
    }

    [HttpPost]
    public ActionResult Edit(Rating rating)
    {
      _db.Entry(rating).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Show", "Restaurant", new {id = rating.RestaurantId});
    }

    public ActionResult Delete(int id)
    {
      Rating thisRating = _db.Ratings.FirstOrDefault(ratings => ratings.RatingId == id);
      return View(thisRating);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Rating thisRating = _db.Ratings.FirstOrDefault(ratings => ratings.RatingId == id);
      _db.Ratings.Remove(thisRating);
      _db.SaveChanges();
      return RedirectToAction("Show", "Restaurant", new {id = thisRating.RestaurantId});
    }
  }
}