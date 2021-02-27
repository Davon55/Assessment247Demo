using Assessment247.Business.Service;
using Assessment247.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment247.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View("Menu");
        }
        [HttpPost]
        public IActionResult InggMenu()
        {
            //Get the model
            MenuModel menu = new MenuModel();

            menu.Name = Convert.ToString(Request.Form["Name"].ToString());
            menu.Calories = Convert.ToInt32(Request.Form["Calories"].ToString());
            menu.Ingredient1 = Convert.ToString(Request.Form["Ingredient1"].ToString());
            menu.Ingredient2 = Convert.ToString(Request.Form["Ingredient2"].ToString());

            // get info from business layer and return it to the view 
            MenuService menuService = new MenuService();
            string simpleMenu = menuService.getMenu(menu);

            StringBuilder theMenu = new StringBuilder();

            theMenu.Append("<b>Name: </b>" + menu.Name + "<br>");
            theMenu.Append("<b>Calories: </b>" + menu.Calories + "<br>");
            theMenu.Append("<b>Ingredient1: </b>" + menu.Ingredient1 + "<br>");
            theMenu.Append("<b>Ingredient2: </b>" + menu.Ingredient2 + "<br>");
            theMenu.Append("<b>Ingredient: </b>" + simpleMenu+ "<br>");

            ViewBag.menuValue = theMenu;
            return View("IngMenu");
        }
        public IActionResult IngMenu()
        {
            return View();
        }
    }
}
