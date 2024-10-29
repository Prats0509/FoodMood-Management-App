using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2330506.Classes
{
    public static class FoodRepository
    {
        public static List<FoodItem> Foods = new List<FoodItem>()
    {
        new FoodItem("Almond Milk", new List<string>{"Dairy-free", "Low in calories"}, new List<string>{"Vegan", "Dairy-Free"}, new List<string>{"Nuts"}),
        new FoodItem("Quinoa Salad", new List<string>{"High in protein", "Fiber-rich"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Blueberries", new List<string>{"High in antioxidants", "Low in calories"}, new List<string>{"Vegan"}, new List<string>{}),
        new FoodItem("Kale Chips", new List<string>{"Vitamin rich", "Low fat"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Avocado Toast", new List<string>{"Healthy fats", "High fiber"}, new List<string>{"Vegetarian"}, new List<string>{}),
        new FoodItem("Sweet Potato Fries", new List<string>{"Rich in vitamin A", "High fiber"}, new List<string>{"Vegan"}, new List<string>{}),
        new FoodItem("Chia Seed Pudding", new List<string>{"High in Omega-3", "Good source of protein"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Oatmeal", new List<string>{"Heart healthy", "Energy boosting"}, new List<string>{"Vegan"}, new List<string>{}),
        new FoodItem("Greek Yogurt", new List<string>{"Protein-rich", "Probiotic"}, new List<string>{"Vegetarian"}, new List<string>{"Dairy"}),
        new FoodItem("Salmon", new List<string>{"Rich in Omega-3", "Great source of protein"}, new List<string>{"Keto"}, new List<string>{"Fish"}),

        
        new FoodItem("Lentil Soup", new List<string>{"High in fiber", "Rich in protein"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Tofu Stir Fry", new List<string>{"High in protein", "Low in fat"}, new List<string>{"Vegan", "Vegetarian"}, new List<string>{"Soy"}),
        new FoodItem("Spinach Salad", new List<string>{"Rich in iron", "Vitamin K"}, new List<string>{"Vegan", "Vegetarian"}, new List<string>{}),
        new FoodItem("Black Bean Burger", new List<string>{"High in protein", "Fiber-rich"}, new List<string>{"Vegan"}, new List<string>{}),
        new FoodItem("Beetroot Juice", new List<string>{"Boosts stamina", "Lowers blood pressure"}, new List<string>{"Vegan", "Vegetarian"}, new List<string>{}),
        new FoodItem("Carrot Cake", new List<string>{"Contains beta-carotene", "Energy boosting"}, new List<string>{"Vegetarian"}, new List<string>{"Eggs"}),
        new FoodItem("Banana Smoothie", new List<string>{"Rich in potassium", "Energy boosting"}, new List<string>{"Vegetarian"}, new List<string>{"Dairy"}),
        new FoodItem("Garlic Bread", new List<string>{"Flavorful", "Energy boosting"}, new List<string>{"Vegetarian"}, new List<string>{"Dairy"}),
        new FoodItem("Ratatouille", new List<string>{"Rich in vegetables", "Low fat"}, new List<string>{"Vegan"}, new List<string>{}),
        new FoodItem("Miso Soup", new List<string>{"Rich in probiotics", "Low calorie"}, new List<string>{"Vegan"}, new List<string>{"Soy"}),

        new FoodItem("Pumpkin Seeds", new List<string>{"High in magnesium", "Good for heart health"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Tempeh", new List<string>{"Rich in protein", "Good source of probiotics"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{"Soy"}),
        new FoodItem("Cashew Cheese", new List<string>{"Dairy-free", "Rich in healthy fats"}, new List<string>{"Vegan"}, new List<string>{"Nuts"}),
        new FoodItem("Butternut Squash Soup", new List<string>{"High in vitamins", "Creamy texture without dairy"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Mango Lassi", new List<string>{"Rich in vitamin A", "Probiotic"}, new List<string>{"Vegetarian"}, new List<string>{"Dairy"}),
        new FoodItem("Peanut Butter Smoothie", new List<string>{"High in protein", "Rich in healthy fats"}, new List<string>{"Vegetarian"}, new List<string>{"Nuts"}),
        new FoodItem("Zucchini Pasta", new List<string>{"Low carb", "High in fiber"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Falafel Wrap", new List<string>{"Rich in protein", "High in fiber"}, new List<string>{"Vegan", "Vegetarian"}, new List<string>{}),
        new FoodItem("Tomato Basil Soup", new List<string>{"Rich in antioxidants", "Flavorful"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Eggplant Parmesan", new List<string>{"High in fiber", "Rich in flavor"}, new List<string>{"Vegetarian"}, new List<string>{"Dairy"}),
        new FoodItem("Cauliflower Steak", new List<string>{"Low in calories", "High in fiber"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Coconut Yogurt", new List<string>{"Dairy-free", "Probiotic"}, new List<string>{"Vegan", "Dairy-Free"}, new List<string>{}),
        
        new FoodItem("Seaweed Salad", new List<string>{"Rich in iodine", "Low calorie"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Portobello Mushroom Burger", new List<string>{"High in potassium", "Low in fat"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Almond Flour Pancakes", new List<string>{"Gluten-free", "High in protein"}, new List<string>{"Vegetarian", "Gluten-Free"}, new List<string>{"Nuts"}),
        new FoodItem("Keto Avocado Brownies", new List<string>{"Low carb", "Rich in healthy fats"}, new List<string>{"Keto"}, new List<string>{"Nuts"}),
        new FoodItem("Jackfruit Tacos", new List<string>{"Rich in fiber", "Meat substitute"}, new List<string>{"Vegan"}, new List<string>{}),
        new FoodItem("Sunflower Seed Butter", new List<string>{"Nut-free", "High in magnesium"}, new List<string>{"Vegan", "Dairy-Free"}, new List<string>{}),
        new FoodItem("Buckwheat Noodles", new List<string>{"High in protein", "Gluten-free"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Watercress Soup", new List<string>{"Rich in antioxidants", "Low calorie"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Grilled Halloumi", new List<string>{"High in protein", "Rich flavor"}, new List<string>{"Vegetarian"}, new List<string>{"Dairy"}),
        new FoodItem("Keto Cheese Crackers", new List<string>{"Low carb", "Crunchy snack"}, new List<string>{"Keto"}, new List<string>{"Dairy"}),
        new FoodItem("Soy-Free Vegan Cheese", new List<string>{"Dairy-free", "Rich in healthy fats"}, new List<string>{"Vegan", "Dairy-Free"}, new List<string>{"Nuts"}),
        new FoodItem("Hemp Seed Oatmeal", new List<string>{"High in Omega-3", "Good source of protein"}, new List<string>{"Vegan", "Gluten-Free"}, new List<string>{}),
        new FoodItem("Pumpkin Spice Latte", new List<string>{"Rich in vitamins", "Seasonal flavor"}, new List<string>{"Vegetarian"}, new List<string>{"Dairy"})



    };
    }

}
