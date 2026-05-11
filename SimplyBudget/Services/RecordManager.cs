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
    /// A global manager for records.
    /// </summary>
    public class RecordManager
    {
        private static RecordManager instance;

        // Singleton instace
        public static RecordManager Instance
        {
            get 
            { 
                if  (instance == null)
                    instance = new RecordManager();
                return instance;
            }
        }

        // Private so a new instance can't be created
        private RecordManager() { }

        // Record manager properties
        private List<Record> records = new List<Record>();
        private const string recordsFilePath = "Data/internal_records.csv";

        /// <summary>
        /// Adds a new record to the records list.
        /// </summary>
        /// <param name="newRecord">The record to be added into the records list.</param>
        public void Add(Record newRecord)
        {
            records.Add(newRecord);
        }

        /// <summary>
        /// Updates an existing record with new values. The record is selected by it's ID.
        /// </summary>
        /// <param name="updatedRecord">The updated record.</param>
        public void Update(Record updatedRecord)
        {
            Record recordToUpdate = records.Find(x => x.ID == updatedRecord.ID);

            if (recordToUpdate != null)
            {
                recordToUpdate = updatedRecord;
            }
        }

        /// <summary>
        /// Deletes a record.
        /// </summary>
        /// <param name="recordToDelete">Record to be deleted.</param>
        public void Delete(Record recordToDelete)
        {
            records.Remove(recordToDelete);
        }

        /// <summary>
        /// Clears all records from the records list.
        /// </summary>
        public void Clear()
        {
            records.Clear();
        }

        /// <summary>
        /// Finds a record from the record list from an ID.
        /// </summary>
        /// <param name="idOfRecord">ID of the record to be found.</param>
        /// <returns>Record with the inserted ID.</returns>
        public Record GetByID(int idOfRecord)
        {
            return records.Find(x => x.ID == idOfRecord);
        }

        /// <summary>
        /// Finds all records saved in the records list.
        /// </summary>
        /// <returns>All existing records.</returns>
        public List<Record> GetAll()
        {
            return records;
        }

        /// <summary>
        /// Saves the current list of records to the internal_records.csv file.
        /// </summary>
        public void Save()
        {
            // Creates a directory for Data if it doesn't exist
            Directory.CreateDirectory("Data");

            // Goes trough the records list and writes it into the internal_records.csv file
            using (StreamWriter streamWriter = new StreamWriter(recordsFilePath, false))
            {
                foreach (Record record in records)
                    streamWriter.WriteLine(record.ToCSV());
            }
        }

        /// <summary>
        /// Loads records from the internal_records.csv file into the records list.
        /// </summary>
        public void Load()
        {
            if (!File.Exists(recordsFilePath))
                return;

            using (StreamReader streamReader = new StreamReader(recordsFilePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    try
                    {
                        records.Add(Record.FromCSV(line));
                    }
                    catch
                    {
                        // skip corrupted lines
                    }
                }
            }
        }
    }
}
