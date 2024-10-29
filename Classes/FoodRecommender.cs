using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_OOP_2330506.Classes
{
    public static class FoodRecommender
    {
        public static List<FoodItem> RecommendFoods(User user)
        {
            List<FoodItem> recommendedFoods = new List<FoodItem>();

            foreach (var food in FoodRepository.Foods)
            {
                if (ImprovesMood(food.Name, user.Username) && MeetsDietaryRestriction(food, user))
                {
                    recommendedFoods.Add(food);
                }
            }

            return recommendedFoods;
        }
        private static bool MeetsDietaryRestriction(FoodItem food, User user)
        {
            if (user.Allergies != null && user.Allergies.Count > 0)
            {

                foreach (string allergen in food.Allergens)
                {
                    if (user.Allergies.Contains(allergen)|| user.Allergies.Contains("None"))
                    {
                        return false;
                    }
                }

            }
            if (user.DietaryRestrictions != null && user.DietaryRestrictions.Count > 0)
            {
                    foreach (string category in food.DietaryCategories)
                    {
                        if (user.DietaryRestrictions.Contains(category)||user.DietaryRestrictions.Contains("None"))
                        {
                            return true;
                        }
                    }

                    return false;
            }
            return true;
        }

        private static bool ImprovesMood(string foodName, string user)
        {
                bool improvesMood = true;
                foreach (var entry in MoodFoodData.FoodLogEntries)
                {
                    if (entry.FoodName == foodName && entry.UserName == user && entry.MoodAfter < entry.MoodBefore)
                    {
                        improvesMood = false;
                        break;
                    }

                }
                return improvesMood;
        }

        
    }
}
