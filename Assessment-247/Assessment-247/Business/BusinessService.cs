using Assessment_247.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_247.Business
{
    public class BusinessService
    {
        public MenuItemModel ReverseIngredients(MenuItemModel menuItem)
        {
            //creates placeholders for reversed ingredients
            string newI1 = "";
            string newI2 = "";
            //takes the ingredients from the menuItem and turns them into char arrays before adding each char to the new strings
            for(int i = menuItem.Ingredient1.Length-1; i > -1; i--)
            {
                newI1 += menuItem.Ingredient1.ToCharArray()[i] + "";
            }
            for (int i = menuItem.Ingredient2.Length - 1; i > -1; i--)
            {
                newI2 += menuItem.Ingredient2.ToCharArray()[i] + "";
            }
            //overwrites the old ingredients with the new ingredients
            menuItem.Ingredient1 = newI1;
            menuItem.Ingredient2 = newI2;

            //returns the new menuItem
            return menuItem;
        }
    }
}
