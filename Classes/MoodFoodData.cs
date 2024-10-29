using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2330506
{
    public static class MoodFoodData
    {
        private static List<FoodLogEntry> foodLogEntries = new List<FoodLogEntry>();

        public static List<FoodLogEntry> FoodLogEntries { get => foodLogEntries; set => foodLogEntries = value; }

        public static void LogFoodEntry(FoodLogEntry entry)
        {
            FoodLogEntries.Add(entry);
            
        }
        public static List<FoodLogEntry> GetEntriesByUser(string username)
        {
            
                List<FoodLogEntry> results = new List<FoodLogEntry>();
                foreach (var entry in FoodLogEntries)
                {
                    if (entry.UserName == username)
                    {
                        results.Add(entry);
                    }
                }
                return results;

        }
    }
}
