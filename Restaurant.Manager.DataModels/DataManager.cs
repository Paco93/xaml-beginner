using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RestaurantManager.Models
{
    public class DataManager
    {
        public DataManager()
        {
            this.OrderItems = new ObservableCollection<string>(
                new List<string>
                {
                    "Steak, Chicken, Peas",
                    "Rice, Chicken",
                    "Hummus, Pita"
                }
            );

            this.MenuItems = new List<string>
            {
                "Steak",
                "Chicken",
                "Peas",
                "Rice",
                "Hummus",
                "Pita"
            };

            this.CurrentlySelectedMenuItems = new ObservableCollection<string>(new List <string>
            {
                "Rice",
                "Pita"
            }
            );
           

        }

        public ObservableCollection<string> OrderItems { get; set; }
        public List<string> MenuItems { get; set; }
        public ObservableCollection<string>  CurrentlySelectedMenuItems { get; set; }
        public string  submitOrder()
        { 
            string ret="";
            foreach (string s in CurrentlySelectedMenuItems)
            {
                if (ret == "")
                    ret += s;
                else
                    ret += ", " + s;
            }
            return ret;
        }
    }
}