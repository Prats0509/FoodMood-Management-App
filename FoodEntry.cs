using Project_OOP_2330506.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP_2330506
{
    public partial class FoodEntry : Form
    {
        private AfterLogin afterLogin;
        private string userName;
        public FoodEntry(AfterLogin afterLogin, string username)
        {
            InitializeComponent();
            this.userName = username;
            this.afterLogin = afterLogin;
            PopulateFoodItemsComboBox();
        }

        private void PopulateFoodItemsComboBox()
        {
            List<string> foodNames = new List<string>();
            User user = UserManager.GetUserByUsername(userName);

            foreach (var food in FoodRepository.Foods)
            {
                bool suitable = true;
                foreach (string allergen in food.Allergens)
                {
                    
                    if (user.Allergies.Contains(allergen))
                    {
                        suitable = false;
                        break;
                    }
                }

                if (suitable == true) 
                {
                    bool allowedFood = false;
                    foreach (string category in food.DietaryCategories)
                    {
                        if (user.DietaryRestrictions.Contains(category)|| user.DietaryRestrictions.Contains("None"))
                        {
                            allowedFood = true;
                            break;
                        }
                    }
                    if (allowedFood == false)
                    {
                        suitable = false;
                    }
                }

                if (suitable == true || (user.Allergies.Contains("None") && user.DietaryRestrictions.Contains("None")))
                {
                    foodNames.Add(food.Name);
                }
            }

            comboBox_food.DataSource = foodNames;
            comboBox_food.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void buttonLogEntry_Click(object sender, EventArgs e)
        
        {
        
            DateTime entryDate = dateTimePicker1.Value; 
            string foodItemName = comboBox_food.Text; 
            string portionSize = textBoxPortionSize.Text; 
            int moodRatingBefore = int.Parse(textBoxMoodBefore.Text); 
            int moodRatingAfter = int.Parse(textBoxMoodAfter.Text); 

            
            var foodLogEntry = new FoodLogEntry

            {
                UserName = userName,
                EntryDateTime = entryDate,
                FoodName = foodItemName,
                PortionSize = portionSize,
                MoodBefore = moodRatingBefore,
                MoodAfter = moodRatingAfter
            };

            MoodFoodData.LogFoodEntry(foodLogEntry);

            MessageBox.Show("Entry Logged Successfully!");

            afterLogin.ShowForm();
            this.Hide();

        }
        
    }
}
