using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplyBudget.Models.Factories;

namespace SimplyBudget.Models
{
    /// <summary>
    /// A class model with a purpose to store information about the movement of money.
    /// </summary>
    public class Record
    {
        public int ID { get; private set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public RecordType Type { get; set; }

        public Record(int id, decimal amount, DateTime date, string category, string description, RecordType type)
        {
            ID = id;
            Amount = amount;
            Date = date;
            Category = category;
            Description = description;
            Type = type;
        }

        /// <summary>
        /// Converts record into a csv format.
        /// </summary>
        /// <returns>Record in a csv format.</returns>
        public string ToCSV()
        {
            return string.Join(";",
                ID,
                Amount.ToString(CultureInfo.InvariantCulture),
                Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                Category,
                Description,
                Type
            );
        }

        /// <summary>
        /// Converts a csv line into a record.
        /// </summary>
        /// <param name="CSVline">Record csv line.</param>
        /// <returns>Converted record.</returns>
        public static Record FromCSV(string CSVline)
        {
            string[] splitLine = CSVline.Split(';');

            return new Record(
                int.Parse(splitLine[0]),
                decimal.Parse(splitLine[1], CultureInfo.InvariantCulture),
                DateTime.Parse(splitLine[2], CultureInfo.InvariantCulture),
                splitLine[3],
                splitLine[4],
                (RecordType)Enum.Parse(typeof(RecordType), splitLine[5])
            );
        }
    }
}
