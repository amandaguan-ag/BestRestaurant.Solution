using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;

namespace BestRestaurant.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {

            List<Restaurant> allRestaurants = Restaurant.GetAll();
            return View(allRestaurants);
        }

        [HttpGet("/restaurants/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/restaurants")]
        public ActionResult Create(string description)
        {
            Restaurant myRestaurant = new Restaurant(description);
            return RedirectToAction("Index");
        }

    }
}