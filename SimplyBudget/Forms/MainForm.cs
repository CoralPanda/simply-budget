using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimplyBudget.Models;
using SimplyBudget.Services;

namespace SimplyBudget
{
    public partial class MainForm : Form
    {
        private BindingSource bindingSource = new BindingSource();
        

        public MainForm()
        {
            InitializeComponent();

            // Load data from data files
            CategoryManager.Instance.Load();
            RecordManager.Instance.Load();

            // Sets a source for the Latest Records datagrid
            dataGridViewLatestRecords.DataSource = bindingSource;
            bindingSource.DataSource = BudgetManager.GetLatestRecords();

            dataGridViewLatestRecords.DataBindingComplete += (s, e) =>
            {
                dataGridViewLatestRecords.Columns[0].Visible = false;
            };

            UpdateUI();
        }

        private void buttonRecordAdd_Click(object sender, EventArgs e)
        {
            // Creates a new instance of a Record Form and then opens the form modally
            RecordForm recordForm = new RecordForm();
            
            if (recordForm.ShowDialog() == DialogResult.OK)
            {
                UpdateUI();
            }
        }

        private void buttonRecordEdit_Click(object sender, EventArgs e)
        {
            // Cancel the operation if now rows are selected
            if (dataGridViewLatestRecords.SelectedRows.Count == 0)
                return;

            // Creates a new instance of a Record Form and then opens the form modally
            RecordForm recordForm = new RecordForm((Record)bindingSource.Current);

            if (recordForm.ShowDialog() == DialogResult.OK)
            {
                UpdateUI();
            }
        }

        // Enable editing by double-clicking on the cell
        private void dataGridViewLatestRecords_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Cancel the operation if now rows are selected
            if (dataGridViewLatestRecords.SelectedRows.Count == 0)
                return;

            // Creates a new instance of a Record Form and then opens the form modally
            RecordForm recordForm = new RecordForm((Record)bindingSource.Current);

            if (recordForm.ShowDialog() == DialogResult.OK)
            {
                UpdateUI();
            }
        }

        private void buttonRecordDelete_Click(object sender, EventArgs e)
        {
            // Cancel the operation if now rows are selected
            if (dataGridViewLatestRecords.SelectedRows.Count == 0)
                return;

            // Opens a popup to confirm if the user wants to delete the record
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Delete record?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Deletes the selected record
                RecordManager.Instance.Delete((Record)bindingSource.Current);

                UpdateUI();
            }
        }

        private void buttonResetChanges_Click(object sender, EventArgs e)
        {
            // Opens a popup to confirm if the user wants to delete the record
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset all changes?",
                "Reset changes?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Deletes the selected record
                RecordManager.Instance.Clear();
                RecordManager.Instance.Load();

                UpdateUI();
            }
        }

        private void buttonSaveExit_Click(object sender, EventArgs e)
        {
            RecordManager.Instance.Save();
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Opens a popup to check if the user want to exit without saving
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit without saving?",
                "Exit application?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordManager.Instance.Save();
        }

        private void UpdateUI()
        {
            // Refreshes the DataGrid with latest data
            bindingSource.DataSource = BudgetManager.GetLatestRecords();

            /* =================================== */
            /*            CURRENT MONTH            */
            /* =================================== */

            // Create a string for the highest incomes/expenses of the current month
            Record highestIncome = BudgetManager.GetHighestIncomeByMonth(DateTime.Now);
            Record highestExpense = BudgetManager.GetHighestExpenseByMonth(DateTime.Now);
            string currentMonthHighestIncome = highestIncome != null ? $"{highestIncome.Amount} {AppSettings.Instance.Currency}, {highestIncome.Category}" : "0";
            string currentMonthHighestExpense = highestExpense != null ? $"{highestExpense.Amount} {AppSettings.Instance.Currency}, {highestExpense.Category}" : "0";

            // Update fields with the current values
            labelCurrentIncomes.Text = BudgetManager.GetIncomesByMonth(DateTime.Now).ToString();
            labelCurrentExpenses.Text = BudgetManager.GetExpensesByMonth(DateTime.Now).ToString();
            labelCurrentHighestIncome.Text = currentMonthHighestIncome;
            labelCurrentHighestExpense.Text = currentMonthHighestExpense;
            labelCurrentCurrentBalance.Text = BudgetManager.GetDifferenceByMonth(DateTime.Now).ToString();
            labelCurrentMostCommon.Text = BudgetManager.GetMostCommonCategoryByMonth(DateTime.Now);

            // Progress bar for spent income
            decimal income = BudgetManager.GetIncomesByMonth(DateTime.Now);
            decimal expense = BudgetManager.GetExpensesByMonth(DateTime.Now);

            if (income > 0)
            {
                int percentage = (int)((expense / income) * 100);
                progressBarCurrentMonth.Value = Math.Min(percentage, 100);
            }
            else
            {
                progressBarCurrentMonth.Value = 0;
            }
        }
    }
}
