using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Linq;
using System;

namespace BestRestaurant.Controllers
{
  public class RestaurantController : Controller
  {
    private readonly BestRestaurantContext _db;

    public RestaurantController(BestRestaurantContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(restaurants => restaurants.Cuisine).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Show(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.Include(restaurants => restaurants.Cuisine).Include(restaurants => restaurants.Ratings).FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      
      var AverageScore = 
        from r in _db.Ratings
        group r by r.RestaurantId into res
        where res.Key == thisRestaurant.RestaurantId
        select res.Average(ratings => ratings.Score);


      ViewBag.avgScore =  Math.Round(AverageScore.FirstOrDefault(), 1); 
      return View(thisRestaurant);
    }

    public ActionResult Edit(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      return View(thisRestaurant);
    }

    [HttpPost]
    public ActionResult Edit(Restaurant restaurant)
    {
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      return View(thisRestaurant);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      _db.Restaurants.Remove(thisRestaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}