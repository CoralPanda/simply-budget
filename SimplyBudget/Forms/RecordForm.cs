using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimplyBudget.Models;
using SimplyBudget.Models.Factories;
using SimplyBudget.Services;
using SimplyBudget.Utilities;

namespace SimplyBudget
{
    public partial class RecordForm : Form
    {
        private Record _record;

        public RecordForm(Record record = null)
        {
            InitializeComponent();

            // Updates the currency label to the current currency
            labelRecordCurrency.Text = AppSettings.Instance.Currency;

            // When the Edit button is pressed the fields are filled with the selected record's values
            if (record != null)
            {
                // Sets the text of the Save/Add button to Save
                buttonRecordAddSave.Text = "Save";

                // Set field values to the opened record
                radioRecordTypeIncome.Checked = (record.Type == RecordType.Income) ? true : false;      // Checks the income radio button if the type is income
                radioRecordTypeExpense.Checked = (record.Type == RecordType.Expense) ? true : false;    // Checks the expense radio button if the type is expense
                textBoxRecordAmount.Text = record.Amount.ToString();
                dateTimePickerRecordDate.Value = record.Date;
                comboBoxRecordCategory.SelectedItem = record.Category;
                richTextBoxRecordDescription.Text = record.Description;

                // Set the record to the local record variable
                _record = record;
            }
            else
            {
                // Sets the text of the Save/Add button to Add
                buttonRecordAddSave.Text = "Add";

                // Default values for when a new record is being created
                radioRecordTypeExpense.Checked = true;
                comboBoxRecordCategory.DataSource = CategoryManager.Instance.GetFilteredCategoryList(RecordType.Expense);
                dateTimePickerRecordDate.Value = DateTime.Now;
            }
        }

        private void buttonRecordAddSave_Click(object sender, EventArgs e)
        {
            // CREATING A NEW RECORD

            // Validates if all fields are correctly filled and then creates a new record
            if (_record == null && this.ValidateChildren())
            {
                // Selects the Record Type from the radio buttons
                RecordType recordType;
                if (radioRecordTypeExpense.Checked) recordType = RecordType.Expense;
                else recordType = RecordType.Income;

                RecordManager.Instance.Add(
                    RecordFactory.Create
                    (
                        recordType,
                        decimal.Parse(textBoxRecordAmount.Text),
                        dateTimePickerRecordDate.Value,
                        comboBoxRecordCategory.SelectedItem.ToString(),
                        richTextBoxRecordDescription.Text
                    )
                );

                // Return an OK result and close the window
                DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // UPDATING AN EXISTING RECORD

            // Validates if all fields are correctly filled and then updates the selected record
            if (_record != null && this.ValidateChildren())
            {
                // Selects the Record Type from the radio buttons
                RecordType recordType;
                if (radioRecordTypeExpense.Checked) recordType = RecordType.Expense;
                else recordType = RecordType.Income;

                // Set the current field values to the existing record
                _record.Type = recordType;
                _record.Amount = decimal.Parse(textBoxRecordAmount.Text);
                _record.Date = dateTimePickerRecordDate.Value;
                _record.Category = comboBoxRecordCategory.SelectedItem.ToString();
                _record.Description = richTextBoxRecordDescription.Text;

                // Return an OK result and close the window
                DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
        }

        private void radioRecordType_CheckedChanged(object sender, EventArgs e)
        {
            // When the selected record type radio button is changed, categories are updated to it's record type
            if (radioRecordTypeExpense.Checked)
            {
                comboBoxRecordCategory.DataSource = CategoryManager.Instance.GetFilteredCategoryList(RecordType.Expense);
            } else
            {
                comboBoxRecordCategory.DataSource = CategoryManager.Instance.GetFilteredCategoryList(RecordType.Income);
            }
        }

        private void richTextBoxRecordDescription_Leave(object sender, EventArgs e)
        {
            // Clears whitespace from both ends when the user unfocuses the text box
            richTextBoxRecordDescription.Text = richTextBoxRecordDescription.Text.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validating of the Record Amount
        private void recordAmount_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Validators.RecordAmount(sender as TextBox, errorProviderRecord);
        }

        private void recordAmount_Validated(object sender, EventArgs e)
        {
            errorProviderRecord.SetError(sender as TextBox, null);
        }

        // Validating of the Record Date
        private void recordDate_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Validators.RecordDate(sender as DateTimePicker, errorProviderRecord);
        }
        private void recordDate_Validated(object sender, EventArgs e)
        {
            errorProviderRecord.SetError(sender as DateTimePicker, null);
        }

        // Validating of the Record Description
        private void recordDescription_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Validators.RecordDescription(sender as RichTextBox, errorProviderRecord);
        }

        private void recordDescription_Validated(object sender, EventArgs e)
        {
            errorProviderRecord.SetError(sender as RichTextBox, null);
        }
    }
}
