using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyBudget.Models
{
    /// <summary>
    /// Represents the type of a financial record
    /// </summary>
    enum RecordType
    {
        /// <summary>
        /// Incoming money (e.g. salary, gift, )
        /// </summary>
        Income,
        /// <summary>
        /// Outgoing money (e.g. food, transport)
        /// </summary>
        Expense
    }
}
