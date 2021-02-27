using Assessment247.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment247.Business.Service
{
    public class MenuService
    {
        //pass model to business layer
        public string getMenu(MenuModel menuModel)
        {
            //reversing the two string if a string is blue and with it reversed it is eulb
            
                //retrieves data from the post
                //and puts it into the model
                string theMenu = menuModel.Name + "" + menuModel.Calories + "" + "" + menuModel.Ingredient1 + "" + menuModel.Ingredient2;
            return theMenu;
          
        }
    }
}
