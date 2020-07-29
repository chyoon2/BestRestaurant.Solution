using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Linq;

namespace BestRestaurant.Controllers
{
  public class CuisineController : Controller
  {
    private readonly BestRestaurantContext _db;

    public CuisineController(BestRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      return View(model); 
    }

    public ActionResult Show(int id)
    {
      Cuisine thisCuisine = _db.Cuisines.Include(cuisines => cuisines.Restaurants).FirstOrDefault(cuisines => cuisines.CuisineId == id);
      return View(thisCuisine);
    }
  }
}