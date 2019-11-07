using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult WelcomePage()
        {
            List<Dishes> AllDishes = dbContext.Dishes.ToList();

            return View(AllDishes);
        }
        [HttpPost]
        public IActionResult AddDish(Dishes dish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("WelcomePage");
            }
            return View("AddDishPage");
            
        }
        [HttpGet("new")]
        public IActionResult AddDishPage()
        {
            return View();
        }
        [HttpGet("{dishid}")]
        public IActionResult IndividualDishPage(int dishid)
        {
            Dishes oneDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishid);
            return View(oneDish);
        }
        [HttpGet("edit/{dishid}")]
        public IActionResult EditPage(int dishid)
        {
            Dishes oneDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishid);
            return View(oneDish);
        }


        [HttpPost]
        public IActionResult EditDish(Dishes thedish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Dishes.Update(thedish);
                dbContext.SaveChanges();
                return RedirectToAction("WelcomePage");
            }
            return View("EditPage");
            
            
            
            
        }
        [HttpPost("ProcessDelete/{dishid}")]
        public IActionResult DeleteDish(int dishid)
        {
            Dishes oneDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishid);
            dbContext.Dishes.Remove(oneDish);
            dbContext.SaveChanges();
            return RedirectToAction("WelcomePage");
        }
        public IActionResult Index()
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
