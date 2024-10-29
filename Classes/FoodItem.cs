using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2330506.Classes
{
    public class FoodItem
    {
        private string name;
        private List<string> benefits = new List<string>();
        private List<string> dietaryCategories = new List<string>();
        private List<string> allergens = new List<string>();

        public string Name { get => name; set => name = value; }
        public List<string> Benefits { get => benefits; set => benefits = value; }
        public List<string> DietaryCategories { get => dietaryCategories; set => dietaryCategories = value; }
        public List<string> Allergens { get => allergens; set => allergens = value; }

        public FoodItem(string name, List<string> benefits, List<string> dietaryCategories, List<string> allergens)
        {
            Name = name;
            Benefits = benefits;
            DietaryCategories = dietaryCategories;
            Allergens = allergens;
        }
    }

}
