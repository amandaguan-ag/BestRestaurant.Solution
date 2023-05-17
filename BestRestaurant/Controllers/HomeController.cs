using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;

namespace BestRestaurant.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            Restaurant starterRestaurant = new Restaurant("Add first restaurant to the restaurant list");
            return View(starterRestaurant);
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
            return View("Index", myRestaurant);
        }

    }
}