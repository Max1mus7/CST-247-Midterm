using Assessment_247.Business;
using Assessment_247.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_247.Controllers
{
    public class AssessmentController : Controller
    {
        public IActionResult Index()
        {
            return View("Menu");
        }

        //form sends a MenuItemModel object to the controller
        public IActionResult addItem(MenuItemModel menuItem)
        {
            //instantiate new BusinessService object in order to access Business Layer
            BusinessService bs = new BusinessService();
            //rewrite the menuItem with new ingredients
            menuItem = bs.ReverseIngredients(menuItem);
            //controller returns a MenuItemModel object
            return View("Menu", menuItem);
        }
    }
}
