using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplyBudget.Models;

namespace SimplyBudget.Services
{
    /// <summary>
    /// Used for managing statistics from records.
    /// </summary>
    public static class BudgetManager
    {
        /// <summary>
        /// Get total incomes from the records list.
        /// </summary>
        /// <returns>Sum of all incomes.</returns>
        public static decimal GetTotalIncomes()
        {
            return RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Income)
                .Sum(record => record.Amount);
        }

        /// <summary>
        /// Get total incomes from a specific month in the records list.
        /// </summary>
        /// <param name="date">Date of record (must contain atleast month and year).</param>
        /// <returns>Sum of all incomes from a month.</returns>
        public static decimal GetIncomesByMonth(DateTime date)
        {
            return RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Income
                              && record.Date.Year == date.Year
                              && record.Date.Month == date.Month)
                .Sum(record => record.Amount);
        }

        /// <summary>
        /// Get total expenses from the records list.
        /// </summary>
        /// <returns>Sum of all expenses.</returns>
        public static decimal GetTotalExpenses()
        {
            return RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Expense)
                .Sum(record => record.Amount);
        }

        /// <summary>
        /// Get total expenses from a specific month in the records list.
        /// </summary>
        /// <param name="date">Date of record (must contain atleast month and year).</param>
        /// <returns>Sum of all expenses from a month.</returns>
        public static decimal GetExpensesByMonth(DateTime date)
        {
            return RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Expense
                              && record.Date.Year == date.Year
                              && record.Date.Month == date.Month)
                .Sum(record => record.Amount);
        }

        /// <summary>
        /// Get the highest income record from a specific month.
        /// </summary>
        /// <param name="date">Month to look in.</param>
        /// <returns>Highest income of the month.</returns>
        public static Record GetHighestIncomeByMonth(DateTime date)
        {
            return RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Income
                              && record.Date.Year == date.Year
                              && record.Date.Month == date.Month)
                .OrderByDescending(record => record.Amount)
                .FirstOrDefault();
        }

        /// <summary>
        /// Get the highest expense record from a specific month.
        /// </summary>
        /// <param name="date">Month to look in.</param>
        /// <returns>Highest expense of the month.</returns>
        public static Record GetHighestExpenseByMonth(DateTime date)
        {
            return RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Expense
                              && record.Date.Year == date.Year
                              && record.Date.Month == date.Month)
                .OrderByDescending(record => record.Amount)
                .FirstOrDefault();
        }

        /// <summary>
        /// Get the highest income record from all records.
        /// </summary>
        /// <returns>Highest income overall.</returns>
        public static Record GetHighestIncome()
        {
            return RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Income)
                .OrderByDescending(record => record.Amount)
                .FirstOrDefault();
        }

        /// <summary>
        /// Get the highest expense record from all records.
        /// </summary>
        /// <returns>Highest expense overall.</returns>
        public static Record GetHighestExpense()
        {
            return RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Expense)
                .OrderByDescending(record => record.Amount)
                .FirstOrDefault();
        }

        /// <summary>
        /// Calculates the difference between incomes and expenses by month.
        /// </summary>
        /// <param name="date">Month to calculate.</param>
        /// <returns>Incomes subtracted by expenses.</returns>
        public static decimal GetDifferenceByMonth(DateTime date)
        {
            decimal incomes = RecordManager.Instance.GetAll()
                                                    .Where(record => record.Type == RecordType.Income
                                                                  && record.Date.Year == date.Year
                                                                  && record.Date.Month == date.Month)
                                                    .Sum(record => record.Amount);

            decimal expenses = RecordManager.Instance.GetAll()
                                                     .Where(record => record.Type == RecordType.Expense
                                                                   && record.Date.Year == date.Year
                                                                   && record.Date.Month == date.Month)
                                                     .Sum(record => record.Amount);

            return incomes - expenses;
        }

        /// <summary>
        /// Gets the most common expense category in a month.
        /// </summary>
        /// <param name="date">Month to look in.</param>
        /// <returns>Most common category of expenses.</returns>
        public static string GetMostCommonCategoryByMonth(DateTime date)
        {
            return RecordManager.Instance.GetAll()
                       .Where(record => record.Type == RecordType.Expense
                                     && record.Date.Year == date.Year
                                     && record.Date.Month == date.Month)
                       .GroupBy(record => record.Category)
                       .OrderByDescending(record => record.Count())
                       .FirstOrDefault()
                       ?.Key ?? "-"; // If FirstOrDefault returns null, returns a "-"
        }

        /// <summary>
        /// Gets all records ordered by their date.
        /// </summary>
        /// <returns>A list of records.</returns>
        public static List<Record> GetLatestRecords()
        {
            return RecordManager.Instance.GetAll()
                .OrderByDescending(record => record.Date)
                .ToList();
        }

        /// <summary>
        /// Calculates the average monthly income rounded to 2 decimal points.
        /// </summary>
        /// <returns>Average monthly income.</returns>
        public static decimal GetAverageMonthlyIncome()
        {
            return Math.Round(RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Income)
                .Average(record => record.Amount), 2);
        }

        /// <summary>
        /// Calculates the average monthly expense rounded to 2 decimal points.
        /// </summary>
        /// <returns>Average monthly income.</returns>
        public static decimal GetAverageMonthlyExpense()
        {
            return Math.Round(RecordManager.Instance.GetAll()
                .Where(record => record.Type == RecordType.Expense)
                .Average(record => record.Amount), 2);
        }
        
        /// <summary>
        /// Calculates total savings.
        /// </summary>
        /// <returns>Total savings.</returns>
        public static decimal GetTotalSavings()
        {
            decimal incomes = RecordManager.Instance.GetAll()
                                                    .Where(record => record.Type == RecordType.Income)
                                                    .Sum(record => record.Amount);

            decimal expenses = RecordManager.Instance.GetAll()
                                                     .Where(record => record.Type == RecordType.Expense)
                                                     .Sum(record => record.Amount);

            return incomes - expenses;
        }
    }
}
