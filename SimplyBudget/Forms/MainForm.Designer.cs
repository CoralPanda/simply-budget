namespace SimplyBudget
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewLatestRecords = new System.Windows.Forms.DataGridView();
            this.buttonRecordAdd = new System.Windows.Forms.Button();
            this.buttonRecordEdit = new System.Windows.Forms.Button();
            this.buttonRecordDelete = new System.Windows.Forms.Button();
            this.buttonExitSave = new System.Windows.Forms.Button();
            this.buttonOverview = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonResetChanges = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.labelCurrentMostCommon = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.labelCurrentCurrentBalance = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labelCurrentExpenses = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelCurrentHighestExpense = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelCurrentHighestIncome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCurrentIncomes = new System.Windows.Forms.Label();
            this.progressBarCurrentMonth = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarOverallSavings = new System.Windows.Forms.ProgressBar();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.labelOverallHighestExpense = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.labelOverallCurrentSavings = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.labelOverallTotalExpenses = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.labelOverallTotalIncome = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelOverallAverageExpenses = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.labelOverallAverageIncome = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.labelSelectedMostCommon = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.labelSelectedHighestExpense = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.labelSelectedHighestIncome = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.labelSelectedReamined = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.labelSelectedExpenses = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.labelSelectedIncome = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatestRecords)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.exportDataToolStripMenuItem,
            this.saveAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importDataToolStripMenuItem.Text = "Import data...";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportDataToolStripMenuItem.Text = "Export data...";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAllToolStripMenuItem.Text = "Save all";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSettingsToolStripMenuItem.Text = "Open settings...";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit application...";
            // 
            // dataGridViewLatestRecords
            // 
            this.dataGridViewLatestRecords.AllowUserToAddRows = false;
            this.dataGridViewLatestRecords.AllowUserToDeleteRows = false;
            this.dataGridViewLatestRecords.AllowUserToResizeRows = false;
            this.dataGridViewLatestRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLatestRecords.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLatestRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLatestRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLatestRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewLatestRecords.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewLatestRecords.MultiSelect = false;
            this.dataGridViewLatestRecords.Name = "dataGridViewLatestRecords";
            this.dataGridViewLatestRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLatestRecords.Size = new System.Drawing.Size(591, 250);
            this.dataGridViewLatestRecords.TabIndex = 1;
            this.dataGridViewLatestRecords.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLatestRecords_CellMouseDoubleClick);
            // 
            // buttonRecordAdd
            // 
            this.buttonRecordAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRecordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecordAdd.Location = new System.Drawing.Point(6, 275);
            this.buttonRecordAdd.Name = "buttonRecordAdd";
            this.buttonRecordAdd.Size = new System.Drawing.Size(66, 23);
            this.buttonRecordAdd.TabIndex = 2;
            this.buttonRecordAdd.Text = "Add...";
            this.buttonRecordAdd.UseVisualStyleBackColor = true;
            this.buttonRecordAdd.Click += new System.EventHandler(this.buttonRecordAdd_Click);
            // 
            // buttonRecordEdit
            // 
            this.buttonRecordEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRecordEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecordEdit.Location = new System.Drawing.Point(78, 275);
            this.buttonRecordEdit.Name = "buttonRecordEdit";
            this.buttonRecordEdit.Size = new System.Drawing.Size(66, 23);
            this.buttonRecordEdit.TabIndex = 3;
            this.buttonRecordEdit.Text = "Edit...";
            this.buttonRecordEdit.UseVisualStyleBackColor = true;
            this.buttonRecordEdit.Click += new System.EventHandler(this.buttonRecordEdit_Click);
            // 
            // buttonRecordDelete
            // 
            this.buttonRecordDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRecordDelete.Location = new System.Drawing.Point(150, 275);
            this.buttonRecordDelete.Name = "buttonRecordDelete";
            this.buttonRecordDelete.Size = new System.Drawing.Size(66, 23);
            this.buttonRecordDelete.TabIndex = 4;
            this.buttonRecordDelete.Text = "Delete";
            this.buttonRecordDelete.UseVisualStyleBackColor = true;
            this.buttonRecordDelete.Click += new System.EventHandler(this.buttonRecordDelete_Click);
            // 
            // buttonExitSave
            // 
            this.buttonExitSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExitSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitSave.Location = new System.Drawing.Point(693, 520);
            this.buttonExitSave.Name = "buttonExitSave";
            this.buttonExitSave.Size = new System.Drawing.Size(185, 29);
            this.buttonExitSave.TabIndex = 5;
            this.buttonExitSave.Text = "Exit and Save";
            this.buttonExitSave.UseVisualStyleBackColor = true;
            this.buttonExitSave.Click += new System.EventHandler(this.buttonSaveExit_Click);
            // 
            // buttonOverview
            // 
            this.buttonOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOverview.Location = new System.Drawing.Point(395, 275);
            this.buttonOverview.Name = "buttonOverview";
            this.buttonOverview.Size = new System.Drawing.Size(98, 23);
            this.buttonOverview.TabIndex = 6;
            this.buttonOverview.Text = "Overview...";
            this.buttonOverview.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonResetChanges);
            this.groupBox2.Controls.Add(this.dataGridViewLatestRecords);
            this.groupBox2.Controls.Add(this.buttonRecordAdd);
            this.groupBox2.Controls.Add(this.buttonOverview);
            this.groupBox2.Controls.Add(this.buttonRecordEdit);
            this.groupBox2.Controls.Add(this.buttonRecordDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 304);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Latest records";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(222, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonResetChanges
            // 
            this.buttonResetChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetChanges.Location = new System.Drawing.Point(499, 275);
            this.buttonResetChanges.Name = "buttonResetChanges";
            this.buttonResetChanges.Size = new System.Drawing.Size(98, 23);
            this.buttonResetChanges.TabIndex = 7;
            this.buttonResetChanges.Text = "Reset changes";
            this.buttonResetChanges.UseVisualStyleBackColor = true;
            this.buttonResetChanges.Click += new System.EventHandler(this.buttonResetChanges_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.progressBarCurrentMonth);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 212);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Money spent this month";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.labelCurrentMostCommon);
            this.groupBox10.Location = new System.Drawing.Point(147, 114);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(146, 41);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Most common category";
            // 
            // labelCurrentMostCommon
            // 
            this.labelCurrentMostCommon.AutoSize = true;
            this.labelCurrentMostCommon.Location = new System.Drawing.Point(6, 16);
            this.labelCurrentMostCommon.Name = "labelCurrentMostCommon";
            this.labelCurrentMostCommon.Size = new System.Drawing.Size(10, 13);
            this.labelCurrentMostCommon.TabIndex = 5;
            this.labelCurrentMostCommon.Text = "-";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.labelCurrentCurrentBalance);
            this.groupBox9.Location = new System.Drawing.Point(6, 114);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(135, 41);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Current balance";
            // 
            // labelCurrentCurrentBalance
            // 
            this.labelCurrentCurrentBalance.AutoSize = true;
            this.labelCurrentCurrentBalance.Location = new System.Drawing.Point(6, 16);
            this.labelCurrentCurrentBalance.Name = "labelCurrentCurrentBalance";
            this.labelCurrentCurrentBalance.Size = new System.Drawing.Size(10, 13);
            this.labelCurrentCurrentBalance.TabIndex = 4;
            this.labelCurrentCurrentBalance.Text = "-";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.labelCurrentExpenses);
            this.groupBox8.Location = new System.Drawing.Point(6, 67);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(135, 41);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Expenses";
            // 
            // labelCurrentExpenses
            // 
            this.labelCurrentExpenses.AutoSize = true;
            this.labelCurrentExpenses.Location = new System.Drawing.Point(6, 16);
            this.labelCurrentExpenses.Name = "labelCurrentExpenses";
            this.labelCurrentExpenses.Size = new System.Drawing.Size(10, 13);
            this.labelCurrentExpenses.TabIndex = 3;
            this.labelCurrentExpenses.Text = "-";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelCurrentHighestExpense);
            this.groupBox7.Location = new System.Drawing.Point(147, 67);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(146, 41);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Highest expense";
            // 
            // labelCurrentHighestExpense
            // 
            this.labelCurrentHighestExpense.AutoSize = true;
            this.labelCurrentHighestExpense.Location = new System.Drawing.Point(6, 16);
            this.labelCurrentHighestExpense.Name = "labelCurrentHighestExpense";
            this.labelCurrentHighestExpense.Size = new System.Drawing.Size(10, 13);
            this.labelCurrentHighestExpense.TabIndex = 2;
            this.labelCurrentHighestExpense.Text = "-";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelCurrentHighestIncome);
            this.groupBox6.Location = new System.Drawing.Point(147, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(146, 41);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Highest income";
            // 
            // labelCurrentHighestIncome
            // 
            this.labelCurrentHighestIncome.AutoSize = true;
            this.labelCurrentHighestIncome.Location = new System.Drawing.Point(6, 16);
            this.labelCurrentHighestIncome.Name = "labelCurrentHighestIncome";
            this.labelCurrentHighestIncome.Size = new System.Drawing.Size(10, 13);
            this.labelCurrentHighestIncome.TabIndex = 1;
            this.labelCurrentHighestIncome.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCurrentIncomes);
            this.groupBox1.Location = new System.Drawing.Point(7, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 41);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Income";
            // 
            // labelCurrentIncomes
            // 
            this.labelCurrentIncomes.AutoSize = true;
            this.labelCurrentIncomes.Location = new System.Drawing.Point(6, 16);
            this.labelCurrentIncomes.Name = "labelCurrentIncomes";
            this.labelCurrentIncomes.Size = new System.Drawing.Size(10, 13);
            this.labelCurrentIncomes.TabIndex = 0;
            this.labelCurrentIncomes.Text = "-";
            // 
            // progressBarCurrentMonth
            // 
            this.progressBarCurrentMonth.Enabled = false;
            this.progressBarCurrentMonth.Location = new System.Drawing.Point(7, 177);
            this.progressBarCurrentMonth.MarqueeAnimationSpeed = 0;
            this.progressBarCurrentMonth.Name = "progressBarCurrentMonth";
            this.progressBarCurrentMonth.Size = new System.Drawing.Size(286, 23);
            this.progressBarCurrentMonth.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.progressBarOverallSavings);
            this.groupBox4.Controls.Add(this.groupBox16);
            this.groupBox4.Controls.Add(this.groupBox15);
            this.groupBox4.Controls.Add(this.groupBox14);
            this.groupBox4.Controls.Add(this.groupBox13);
            this.groupBox4.Controls.Add(this.groupBox12);
            this.groupBox4.Controls.Add(this.groupBox11);
            this.groupBox4.Location = new System.Drawing.Point(317, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 212);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Overall statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total money spent";
            // 
            // progressBarOverallSavings
            // 
            this.progressBarOverallSavings.Enabled = false;
            this.progressBarOverallSavings.Location = new System.Drawing.Point(6, 177);
            this.progressBarOverallSavings.MarqueeAnimationSpeed = 0;
            this.progressBarOverallSavings.Name = "progressBarOverallSavings";
            this.progressBarOverallSavings.Size = new System.Drawing.Size(286, 23);
            this.progressBarOverallSavings.TabIndex = 13;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.labelOverallHighestExpense);
            this.groupBox16.Location = new System.Drawing.Point(150, 115);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(142, 41);
            this.groupBox16.TabIndex = 12;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Highest expense";
            // 
            // labelOverallHighestExpense
            // 
            this.labelOverallHighestExpense.AutoSize = true;
            this.labelOverallHighestExpense.Location = new System.Drawing.Point(6, 16);
            this.labelOverallHighestExpense.Name = "labelOverallHighestExpense";
            this.labelOverallHighestExpense.Size = new System.Drawing.Size(10, 13);
            this.labelOverallHighestExpense.TabIndex = 3;
            this.labelOverallHighestExpense.Text = "-";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.labelOverallCurrentSavings);
            this.groupBox15.Location = new System.Drawing.Point(6, 114);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(138, 41);
            this.groupBox15.TabIndex = 11;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Current savings";
            // 
            // labelOverallCurrentSavings
            // 
            this.labelOverallCurrentSavings.AutoSize = true;
            this.labelOverallCurrentSavings.Location = new System.Drawing.Point(7, 16);
            this.labelOverallCurrentSavings.Name = "labelOverallCurrentSavings";
            this.labelOverallCurrentSavings.Size = new System.Drawing.Size(10, 13);
            this.labelOverallCurrentSavings.TabIndex = 2;
            this.labelOverallCurrentSavings.Text = "-";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.labelOverallTotalExpenses);
            this.groupBox14.Location = new System.Drawing.Point(150, 68);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(142, 41);
            this.groupBox14.TabIndex = 11;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Total expenses";
            // 
            // labelOverallTotalExpenses
            // 
            this.labelOverallTotalExpenses.AutoSize = true;
            this.labelOverallTotalExpenses.Location = new System.Drawing.Point(6, 16);
            this.labelOverallTotalExpenses.Name = "labelOverallTotalExpenses";
            this.labelOverallTotalExpenses.Size = new System.Drawing.Size(10, 13);
            this.labelOverallTotalExpenses.TabIndex = 2;
            this.labelOverallTotalExpenses.Text = "-";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.labelOverallTotalIncome);
            this.groupBox13.Location = new System.Drawing.Point(6, 67);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(138, 41);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Total income";
            // 
            // labelOverallTotalIncome
            // 
            this.labelOverallTotalIncome.AutoSize = true;
            this.labelOverallTotalIncome.Location = new System.Drawing.Point(7, 16);
            this.labelOverallTotalIncome.Name = "labelOverallTotalIncome";
            this.labelOverallTotalIncome.Size = new System.Drawing.Size(10, 13);
            this.labelOverallTotalIncome.TabIndex = 1;
            this.labelOverallTotalIncome.Text = "-";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.labelOverallAverageExpenses);
            this.groupBox12.Location = new System.Drawing.Point(150, 20);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(142, 41);
            this.groupBox12.TabIndex = 10;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Avg. monthly expenses";
            // 
            // labelOverallAverageExpenses
            // 
            this.labelOverallAverageExpenses.AutoSize = true;
            this.labelOverallAverageExpenses.Location = new System.Drawing.Point(6, 16);
            this.labelOverallAverageExpenses.Name = "labelOverallAverageExpenses";
            this.labelOverallAverageExpenses.Size = new System.Drawing.Size(10, 13);
            this.labelOverallAverageExpenses.TabIndex = 1;
            this.labelOverallAverageExpenses.Text = "-";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.labelOverallAverageIncome);
            this.groupBox11.Location = new System.Drawing.Point(6, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(138, 41);
            this.groupBox11.TabIndex = 9;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Avg. monthly income";
            // 
            // labelOverallAverageIncome
            // 
            this.labelOverallAverageIncome.AutoSize = true;
            this.labelOverallAverageIncome.Location = new System.Drawing.Point(7, 15);
            this.labelOverallAverageIncome.Name = "labelOverallAverageIncome";
            this.labelOverallAverageIncome.Size = new System.Drawing.Size(10, 13);
            this.labelOverallAverageIncome.TabIndex = 0;
            this.labelOverallAverageIncome.Text = "-";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.groupBox22);
            this.groupBox5.Controls.Add(this.groupBox21);
            this.groupBox5.Controls.Add(this.groupBox20);
            this.groupBox5.Controls.Add(this.groupBox19);
            this.groupBox5.Controls.Add(this.groupBox18);
            this.groupBox5.Controls.Add(this.groupBox17);
            this.groupBox5.Controls.Add(this.monthCalendar1);
            this.groupBox5.Location = new System.Drawing.Point(627, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 487);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected month";
            // 
            // groupBox22
            // 
            this.groupBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox22.Controls.Add(this.labelSelectedMostCommon);
            this.groupBox22.Location = new System.Drawing.Point(12, 254);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(227, 41);
            this.groupBox22.TabIndex = 12;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Most common category";
            // 
            // labelSelectedMostCommon
            // 
            this.labelSelectedMostCommon.AutoSize = true;
            this.labelSelectedMostCommon.Location = new System.Drawing.Point(6, 16);
            this.labelSelectedMostCommon.Name = "labelSelectedMostCommon";
            this.labelSelectedMostCommon.Size = new System.Drawing.Size(10, 13);
            this.labelSelectedMostCommon.TabIndex = 5;
            this.labelSelectedMostCommon.Text = "-";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.labelSelectedHighestExpense);
            this.groupBox21.Location = new System.Drawing.Point(12, 207);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(227, 41);
            this.groupBox21.TabIndex = 10;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Highest income";
            // 
            // labelSelectedHighestExpense
            // 
            this.labelSelectedHighestExpense.AutoSize = true;
            this.labelSelectedHighestExpense.Location = new System.Drawing.Point(6, 16);
            this.labelSelectedHighestExpense.Name = "labelSelectedHighestExpense";
            this.labelSelectedHighestExpense.Size = new System.Drawing.Size(10, 13);
            this.labelSelectedHighestExpense.TabIndex = 1;
            this.labelSelectedHighestExpense.Text = "-";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.labelSelectedHighestIncome);
            this.groupBox20.Location = new System.Drawing.Point(12, 160);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(227, 41);
            this.groupBox20.TabIndex = 10;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Highest income";
            // 
            // labelSelectedHighestIncome
            // 
            this.labelSelectedHighestIncome.AutoSize = true;
            this.labelSelectedHighestIncome.Location = new System.Drawing.Point(6, 16);
            this.labelSelectedHighestIncome.Name = "labelSelectedHighestIncome";
            this.labelSelectedHighestIncome.Size = new System.Drawing.Size(10, 13);
            this.labelSelectedHighestIncome.TabIndex = 1;
            this.labelSelectedHighestIncome.Text = "-";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.labelSelectedReamined);
            this.groupBox19.Location = new System.Drawing.Point(12, 113);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(227, 41);
            this.groupBox19.TabIndex = 13;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Remained";
            // 
            // labelSelectedReamined
            // 
            this.labelSelectedReamined.AutoSize = true;
            this.labelSelectedReamined.Location = new System.Drawing.Point(6, 16);
            this.labelSelectedReamined.Name = "labelSelectedReamined";
            this.labelSelectedReamined.Size = new System.Drawing.Size(10, 13);
            this.labelSelectedReamined.TabIndex = 3;
            this.labelSelectedReamined.Text = "-";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.labelSelectedExpenses);
            this.groupBox18.Location = new System.Drawing.Point(12, 66);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(227, 41);
            this.groupBox18.TabIndex = 12;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Expenses";
            // 
            // labelSelectedExpenses
            // 
            this.labelSelectedExpenses.AutoSize = true;
            this.labelSelectedExpenses.Location = new System.Drawing.Point(6, 16);
            this.labelSelectedExpenses.Name = "labelSelectedExpenses";
            this.labelSelectedExpenses.Size = new System.Drawing.Size(10, 13);
            this.labelSelectedExpenses.TabIndex = 3;
            this.labelSelectedExpenses.Text = "-";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.labelSelectedIncome);
            this.groupBox17.Location = new System.Drawing.Point(12, 19);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(227, 41);
            this.groupBox17.TabIndex = 9;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Income";
            // 
            // labelSelectedIncome
            // 
            this.labelSelectedIncome.AutoSize = true;
            this.labelSelectedIncome.Location = new System.Drawing.Point(6, 16);
            this.labelSelectedIncome.Name = "labelSelectedIncome";
            this.labelSelectedIncome.Size = new System.Drawing.Size(10, 13);
            this.labelSelectedIncome.TabIndex = 0;
            this.labelSelectedIncome.Text = "-";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(12, 307);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(627, 521);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 28);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExitSave);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Text = "Simply Budget.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatestRecords)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewLatestRecords;
        private System.Windows.Forms.Button buttonRecordAdd;
        private System.Windows.Forms.Button buttonRecordEdit;
        private System.Windows.Forms.Button buttonRecordDelete;
        private System.Windows.Forms.Button buttonExitSave;
        private System.Windows.Forms.Button buttonOverview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarCurrentMonth;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelCurrentHighestExpense;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelCurrentHighestIncome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCurrentIncomes;
        private System.Windows.Forms.Label labelCurrentMostCommon;
        private System.Windows.Forms.Label labelCurrentCurrentBalance;
        private System.Windows.Forms.Label labelCurrentExpenses;
        private System.Windows.Forms.Button buttonResetChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarOverallSavings;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label labelOverallHighestExpense;
        private System.Windows.Forms.Label labelOverallCurrentSavings;
        private System.Windows.Forms.Label labelOverallTotalExpenses;
        private System.Windows.Forms.Label labelOverallTotalIncome;
        private System.Windows.Forms.Label labelOverallAverageExpenses;
        private System.Windows.Forms.Label labelOverallAverageIncome;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label labelSelectedMostCommon;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label labelSelectedHighestExpense;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label labelSelectedHighestIncome;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label labelSelectedReamined;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label labelSelectedExpenses;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label labelSelectedIncome;
        private System.Windows.Forms.Button button1;
    }
}

