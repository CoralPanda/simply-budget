using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyBudget.Models
{
    /// <summary>
    /// A class model with a purpose to store information about the movement of money
    /// </summary>
    public class Record
    {
        public int ID { get; private set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Determines wheter this record is an income or an expense
        /// </summary>
        public RecordType Type { get; set; }
    }
}
