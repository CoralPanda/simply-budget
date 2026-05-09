namespace SimplyBudget
{
    partial class RecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioRecordTypeIncome = new System.Windows.Forms.RadioButton();
            this.radioRecordTypeExpense = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRecordAmount = new System.Windows.Forms.TextBox();
            this.labelRecordCurrency = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerRecordDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxRecordCategory = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBoxRecordDescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioRecordTypeExpense);
            this.groupBox1.Controls.Add(this.radioRecordTypeIncome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // radioRecordTypeIncome
            // 
            this.radioRecordTypeIncome.AutoSize = true;
            this.radioRecordTypeIncome.Location = new System.Drawing.Point(7, 20);
            this.radioRecordTypeIncome.Name = "radioRecordTypeIncome";
            this.radioRecordTypeIncome.Size = new System.Drawing.Size(60, 17);
            this.radioRecordTypeIncome.TabIndex = 0;
            this.radioRecordTypeIncome.TabStop = true;
            this.radioRecordTypeIncome.Text = "Income";
            this.radioRecordTypeIncome.UseVisualStyleBackColor = true;
            // 
            // radioRecordTypeExpense
            // 
            this.radioRecordTypeExpense.AutoSize = true;
            this.radioRecordTypeExpense.Location = new System.Drawing.Point(7, 43);
            this.radioRecordTypeExpense.Name = "radioRecordTypeExpense";
            this.radioRecordTypeExpense.Size = new System.Drawing.Size(66, 17);
            this.radioRecordTypeExpense.TabIndex = 1;
            this.radioRecordTypeExpense.TabStop = true;
            this.radioRecordTypeExpense.Text = "Expense";
            this.radioRecordTypeExpense.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(e.g. salary, gift, ...)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(93, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(e.g. rent, food, ...)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRecordCurrency);
            this.groupBox2.Controls.Add(this.textBoxRecordAmount);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount";
            // 
            // textBoxRecordAmount
            // 
            this.textBoxRecordAmount.Location = new System.Drawing.Point(6, 16);
            this.textBoxRecordAmount.Name = "textBoxRecordAmount";
            this.textBoxRecordAmount.Size = new System.Drawing.Size(152, 20);
            this.textBoxRecordAmount.TabIndex = 0;
            // 
            // labelRecordCurrency
            // 
            this.labelRecordCurrency.AutoSize = true;
            this.labelRecordCurrency.Location = new System.Drawing.Point(159, 19);
            this.labelRecordCurrency.Name = "labelRecordCurrency";
            this.labelRecordCurrency.Size = new System.Drawing.Size(28, 13);
            this.labelRecordCurrency.TabIndex = 1;
            this.labelRecordCurrency.Text = "CZK";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerRecordDate);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date";
            // 
            // dateTimePickerRecordDate
            // 
            this.dateTimePickerRecordDate.Location = new System.Drawing.Point(6, 19);
            this.dateTimePickerRecordDate.Name = "dateTimePickerRecordDate";
            this.dateTimePickerRecordDate.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerRecordDate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxRecordCategory);
            this.groupBox4.Location = new System.Drawing.Point(12, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Category";
            // 
            // comboBoxRecordCategory
            // 
            this.comboBoxRecordCategory.FormattingEnabled = true;
            this.comboBoxRecordCategory.Location = new System.Drawing.Point(6, 19);
            this.comboBoxRecordCategory.Name = "comboBoxRecordCategory";
            this.comboBoxRecordCategory.Size = new System.Drawing.Size(181, 21);
            this.comboBoxRecordCategory.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBoxRecordDescription);
            this.groupBox5.Location = new System.Drawing.Point(12, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 124);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Description";
            // 
            // richTextBoxRecordDescription
            // 
            this.richTextBoxRecordDescription.Location = new System.Drawing.Point(7, 19);
            this.richTextBoxRecordDescription.Name = "richTextBoxRecordDescription";
            this.richTextBoxRecordDescription.Size = new System.Drawing.Size(180, 91);
            this.richTextBoxRecordDescription.TabIndex = 0;
            this.richTextBoxRecordDescription.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecordForm";
            this.Text = "RecordForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioRecordTypeExpense;
        private System.Windows.Forms.RadioButton radioRecordTypeIncome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRecordCurrency;
        private System.Windows.Forms.TextBox textBoxRecordAmount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxRecordCategory;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBoxRecordDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}