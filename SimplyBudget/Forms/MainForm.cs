using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyBudget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonRecordAdd_Click(object sender, EventArgs e)
        {
            // Creates a new instance of a Record Form and then opens the form modally
            RecordForm recordForm = new RecordForm();
            recordForm.ShowDialog(); 
        }
    }
}
