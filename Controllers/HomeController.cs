using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Foodie.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(restaurants r in restaurants.GetRestaurants())
            {
                //rank, restaurant name, favorite dish, address, restaurant phone #, link to website
                restaurantList.Add($"{r.foodRank} {r.foodRestaurant} {r.foodDish} {r.foodAddress} {r.foodPhone} {r.foodWebsite} ");
            }

            return View(restaurantList);
        }
        
        [HttpGet]
        public IActionResult foodForm()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult movieForm(modelResponse appResponse)
        {
            if (appResponse.Title == "Independence Day")
            {
                //if it's independence day don't show up
                return View();
            }
            //checks to see if user inputted required material
            else if (ModelState.IsValid)
            {   
                //if valid then redirect them to confirmation page
                tempStorage.AddMovie(appResponse);
                return View("confirmation", appResponse);
            }
            
            else
            {
                //if not valid then show errors
                return View();
            }
        }*/

        [HttpPost]
        public IActionResult foodForm(modelResponse appResponse)
        {
            if (ModelState.IsValid)
            {
                //if valid the redirect them to confirmation page
                tempStorage.AddMovie(appResponse);
                return View("confirmation", appResponse);

            }
            else
            {
                //if not valid then show errors
                return View();
            }
        }

        public IActionResult foodList()
        {
            //temporary storage while session is active
            return View(tempStorage.Moviess);
        }

        public IActionResult podcasts()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
