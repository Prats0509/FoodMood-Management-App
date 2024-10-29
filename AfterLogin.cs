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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_OOP_2330506
{
    public partial class AfterLogin : Form
    {
        private string currentUsername;
        public AfterLogin()
        {
            InitializeComponent();
            LoadUserLogs();
        }

        public AfterLogin(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadUserLogs();
        }

        public void ShowForm()
        {
            this.Show();
            LoadUserLogs();
        }

        // Button Click Logics

        //Button for logging a foodentry and passing the current object of afterlogin form and the username 
        private void buttonAddNewLog_Click(object sender, EventArgs e)
        {

            FoodEntry foodEntryForm = new FoodEntry(this, currentUsername);
            foodEntryForm.Show();
            this.Hide();
        }
        //button to go back to the main form
        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }


        // Loading Functions
        private void LoadUserLogs()
        {
            List<FoodLogEntry> userEntries = MoodFoodData.GetEntriesByUser(currentUsername);
            listBox1.Items.Clear();
            foreach (var entry in userEntries)
            {
                listBox1.Items.Add($"Date: {entry.EntryDateTime}, Food: {entry.FoodName}, Mood Before: {entry.MoodBefore}, Mood After: {entry.MoodAfter}");
            }
        }

        private void button_recommend_Click(object sender, EventArgs e)
        {
            User currentUser = UserManager.GetUserByUsername(currentUsername);
            if (currentUser == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            List<FoodItem> recommendations = FoodRecommender.RecommendFoods(currentUser);

            if (recommendations.Count == 0)
            {
                MessageBox.Show("No food recommendations available based on your dietary preferences and allergies.");
                return;
            }

            string recommendationText = "Recommended Foods:\n";
            foreach (var food in recommendations)
            {
                recommendationText += food.Name + " - ";
                for (int i = 0; i < food.Benefits.Count; i++)
                {
                    recommendationText += food.Benefits[i];
                    if (i < food.Benefits.Count - 1)
                    {
                        recommendationText += ", ";
                    }
                }
                recommendationText += "\n";
            }


            MessageBox.Show(recommendationText);
        }

        private void button_deletelog_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                MoodFoodData.FoodLogEntries.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                LoadUserLogs();
            }
            else
            {
                MessageBox.Show("Please select a log entry to delete.");

            }
        }
    }
}
