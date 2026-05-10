using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyBudget.Services
{
    /// <summary>
    /// A class used for global managing of the app settings, uses a singleton design pattern
    /// </summary>
    public class AppSettings
    {
        private static AppSettings instance;
        private const string settingsPath = "Data/settings.ini";

        // Singleton instace
        public static AppSettings Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppSettings();
                return instance;
            }
        }

        // Private so a new instance can't be created
        private AppSettings() { }

        // Settings properties
        public string Currency { get; set; } = "$";
        public int LastID { get; set; } = -1;

        /// <summary>
        /// This funfciton loads the app settings from the settings.ini file
        /// </summary>
        public void Load()
        {
            // Checks if the settings.ini file exists, if it doesn't it creates one
            if (!File.Exists(settingsPath))
            {
                Save();
                return;
            }

            // Goes trough the settings.ini file and loads the data
            foreach (string line in File.ReadAllLines(settingsPath))
            {
                string[] splitLine = line.Split('=');

                // Safety net for a line with an incorrect format
                if (splitLine.Length != 2)
                    continue;

                string key = splitLine[0].Trim();
                string value = splitLine[1].Trim();

                // Saves the loaded value into the correct property
                switch (key)
                {
                    case "currency":
                        this.Currency = value;
                        break;
                    case "last_id":
                        int.TryParse(value, out int id);
                        LastID = id; 
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// This function saves the current settings into the settings.ini file or creates a new
        /// file if it can't find one
        /// </summary>
        public void Save()
        {
            // Creates a directory for Data if it doesn't exist
            Directory.CreateDirectory("Data"); 

            string[] lines =
            {
                $"currency={Currency}",
                $"last_id={LastID}"
            };

            // Rewrites or creates the settings.ini file with the new settings
            File.WriteAllLines(settingsPath, lines);
        }
    }
}
