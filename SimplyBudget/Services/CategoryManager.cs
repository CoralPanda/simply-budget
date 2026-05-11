using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplyBudget.Models;

namespace SimplyBudget.Services
{
    /// <summary>
    /// A global manager of categories for records.
    /// </summary>
    public class CategoryManager
    {
        private static CategoryManager instance;
        private const string categoryFilePath = "Data/categories.csv";

        // Singleton instace
        public static CategoryManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryManager();
                return instance;
            }
        }

        // Private so a new instance can't be created
        private CategoryManager() { }
        public List<string> IncomeCategories { get; set; } = new List<string>();
        public List<string> ExpenseCategories { get; set; } = new List<string>();

        /// <summary>
        /// Loads categories into the app from the categories.csv file.
        /// </summary>
        public void Load()
        {
            // Clears both category lists to avoid duplicates
            IncomeCategories.Clear();
            ExpenseCategories.Clear();

            // Only loads data if the categories.csv file exists
            if (!File.Exists(categoryFilePath))
                return;

            // Goes trough the categories.csv file and loads the data
            foreach (string line in File.ReadAllLines(categoryFilePath))
            {
                string[] splitLine = line.Split(';');

                // Safety net for a line with an incorrect format
                if (splitLine.Length != 2)
                    continue;

                string recordType = splitLine[0].Trim();
                string categoryName = splitLine[1].Trim();

                // Saves the loaded category into the correct list
                switch (recordType)
                {
                    case "Income":
                        IncomeCategories.Add(categoryName);
                        break;
                    case "Expense":
                        ExpenseCategories.Add(categoryName);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Returns all categories filtered based on record type.
        /// </summary>
        /// <param name="recordType">Record type of the categories you want to return.</param>
        /// <returns>All categories which match the record type.</returns>
        public List<string> GetFilteredCategoryList(RecordType recordType)
        {
            if (recordType == RecordType.Income)
                return IncomeCategories;
            else
                return ExpenseCategories;
        }
    }
}
