using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2330506
{
   public class FoodLogEntry
        {
        private string userName;
        private DateTime entryDateTime;
        private string foodName;
        private string portionSize;
        private int moodBefore;
        private int moodAfter;

        public FoodLogEntry() { }

        public FoodLogEntry(string userName, DateTime entryDateTime, string foodName, string portionSize, int moodBefore, int moodAfter)
        {
            UserName = userName;
            EntryDateTime = entryDateTime;
            FoodName = foodName;
            PortionSize = portionSize;
            MoodBefore = moodBefore;
            MoodAfter = moodAfter;
        }

        public string UserName { get => userName; set => userName = value; }
        public DateTime EntryDateTime { get => entryDateTime; set => entryDateTime = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public string PortionSize { get => portionSize; set => portionSize = value; }
        public int MoodBefore { get => moodBefore; set => moodBefore = value; }
        public int MoodAfter { get => moodAfter; set => moodAfter = value; }
    }
   
}
