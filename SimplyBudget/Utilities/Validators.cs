using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyBudget.Utilities
{
    public static class Validators
    {
        /*
            SECTION: VALIDATORS FOR RECORDS
            - the section contains validators for the fields of the record form
        */

        /// <summary>
        /// Validator for the record amount.
        /// </summary>
        /// <param name="textBox">What field should be checked.</param>
        /// <param name="errorProvider">Where the error should be thrown.</param>
        /// <returns>Value is required, must be a non-negative number.</returns>
        public static bool RecordAmount(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "This field is required.");
                return true;
            }
            else if (!Regex.IsMatch(textBox.Text, @"^\d+[,.]?\d*$"))
            {
                errorProvider.SetError(textBox, "This field only accepts non-negative numbers");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validator for the record's date.
        /// </summary>
        /// <param name="dateTimePicker">What field should be checked.</param>
        /// <param name="errorProvider">Where the error should be thrown.</param>
        /// <returns>Selected date can't be in the future.</returns>
        public static bool RecordDate(DateTimePicker dateTimePicker, ErrorProvider errorProvider)
        {
            if (dateTimePicker.Value > DateTime.Now)
            {
                errorProvider.SetError(dateTimePicker, "Date of the record cannot be in the future.");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validator for the record's description.
        /// </summary>
        /// <param name="richTextBox">What field should be checked.</param>
        /// <param name="errorProvider">Where the error should be thrown.</param>
        /// <returns>Must have a value and cannot be longer than 100 characters.</returns>
        public static bool RecordDescription(RichTextBox richTextBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrEmpty(richTextBox.Text))
            {
                errorProvider.SetError(richTextBox, "This field is required.");
                return true;
            }
            else if (richTextBox.Text.Length >= 100)
            {
                return true;
            }
            return false;
        }
    }
}
