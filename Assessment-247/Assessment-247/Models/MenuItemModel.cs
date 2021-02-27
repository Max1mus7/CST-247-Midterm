using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_247.Models
{
    public class MenuItemModel
    {
        //fields to hold information about each menu item
        public string Name { get; set; }
        public int Calories { get; set; }
        public string Ingredient1 { get; set; }
        public string Ingredient2 { get; set; }

        //no-args constructor
        public MenuItemModel()
        {

        }

        //full-args constructor
        public MenuItemModel(string name, int calories, string ingredient1, string ingredient2)
        {
            this.Name = name;
            this.Calories = calories;
            this.Ingredient1 = ingredient1;
            this.Ingredient2 = ingredient2;
        }
    }
}
