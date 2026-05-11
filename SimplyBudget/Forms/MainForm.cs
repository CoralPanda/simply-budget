using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            bindingSource.DataSource = RecordManager.Instance.GetAll();
            dataGridViewLatestRecords.Columns["Id"].Visible = false;
        }

        private void buttonRecordAdd_Click(object sender, EventArgs e)
        {
            // Creates a new instance of a Record Form and then opens the form modally
            RecordForm recordForm = new RecordForm();
            
            if (recordForm.ShowDialog() == DialogResult.OK)
            {
                RefreshDataGrid();
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
                RefreshDataGrid();
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

                RefreshDataGrid();
            }
        }

        private void dataGridViewLatestRecords_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cancel the operation if now rows are selected
            if (dataGridViewLatestRecords.SelectedRows.Count == 0)
                return;

            // Creates a new instance of a Record Form and then opens the form modally
            RecordForm recordForm = new RecordForm((Record)bindingSource.Current);

            if (recordForm.ShowDialog() == DialogResult.OK)
            {
                RefreshDataGrid();
            }
        }

        private void buttonSaveExit_Click(object sender, EventArgs e)
        {
            RecordManager.Instance.Save();
            Application.Exit();
        }

        private void RefreshDataGrid()
        {
            bindingSource.ResetBindings(false);
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
    }
}
