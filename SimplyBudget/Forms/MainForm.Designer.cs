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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonResetChanges = new System.Windows.Forms.Button();
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
            this.groupBox5.SuspendLayout();
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
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.importDataToolStripMenuItem.Text = "Import data...";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exportDataToolStripMenuItem.Text = "Export data...";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
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
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openSettingsToolStripMenuItem.Text = "Open settings...";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit application...";
            // 
            // dataGridViewLatestRecords
            // 
            this.dataGridViewLatestRecords.AllowUserToAddRows = false;
            this.dataGridViewLatestRecords.AllowUserToDeleteRows = false;
            this.dataGridViewLatestRecords.AllowUserToResizeColumns = false;
            this.dataGridViewLatestRecords.AllowUserToResizeRows = false;
            this.dataGridViewLatestRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLatestRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLatestRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewLatestRecords.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewLatestRecords.MultiSelect = false;
            this.dataGridViewLatestRecords.Name = "dataGridViewLatestRecords";
            this.dataGridViewLatestRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLatestRecords.Size = new System.Drawing.Size(591, 263);
            this.dataGridViewLatestRecords.TabIndex = 1;
            this.dataGridViewLatestRecords.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLatestRecords_CellMouseDoubleClick);
            // 
            // buttonRecordAdd
            // 
            this.buttonRecordAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRecordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecordAdd.Location = new System.Drawing.Point(6, 288);
            this.buttonRecordAdd.Name = "buttonRecordAdd";
            this.buttonRecordAdd.Size = new System.Drawing.Size(98, 23);
            this.buttonRecordAdd.TabIndex = 2;
            this.buttonRecordAdd.Text = "Add record...";
            this.buttonRecordAdd.UseVisualStyleBackColor = true;
            this.buttonRecordAdd.Click += new System.EventHandler(this.buttonRecordAdd_Click);
            // 
            // buttonRecordEdit
            // 
            this.buttonRecordEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRecordEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecordEdit.Location = new System.Drawing.Point(110, 288);
            this.buttonRecordEdit.Name = "buttonRecordEdit";
            this.buttonRecordEdit.Size = new System.Drawing.Size(98, 23);
            this.buttonRecordEdit.TabIndex = 3;
            this.buttonRecordEdit.Text = "Edit record...";
            this.buttonRecordEdit.UseVisualStyleBackColor = true;
            this.buttonRecordEdit.Click += new System.EventHandler(this.buttonRecordEdit_Click);
            // 
            // buttonRecordDelete
            // 
            this.buttonRecordDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRecordDelete.Location = new System.Drawing.Point(214, 288);
            this.buttonRecordDelete.Name = "buttonRecordDelete";
            this.buttonRecordDelete.Size = new System.Drawing.Size(98, 23);
            this.buttonRecordDelete.TabIndex = 4;
            this.buttonRecordDelete.Text = "Delete record";
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
            this.buttonOverview.Location = new System.Drawing.Point(395, 288);
            this.buttonOverview.Name = "buttonOverview";
            this.buttonOverview.Size = new System.Drawing.Size(98, 23);
            this.buttonOverview.TabIndex = 6;
            this.buttonOverview.Text = "Overview...";
            this.buttonOverview.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonResetChanges);
            this.groupBox2.Controls.Add(this.dataGridViewLatestRecords);
            this.groupBox2.Controls.Add(this.buttonRecordAdd);
            this.groupBox2.Controls.Add(this.buttonOverview);
            this.groupBox2.Controls.Add(this.buttonRecordEdit);
            this.groupBox2.Controls.Add(this.buttonRecordDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 317);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Latest records";
            // 
            // groupBox3
            // 
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
            this.groupBox3.Size = new System.Drawing.Size(299, 199);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current month";
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
            this.groupBox1.Text = "Incomes";
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
            this.progressBarCurrentMonth.Location = new System.Drawing.Point(7, 164);
            this.progressBarCurrentMonth.MarqueeAnimationSpeed = 0;
            this.progressBarCurrentMonth.Name = "progressBarCurrentMonth";
            this.progressBarCurrentMonth.Size = new System.Drawing.Size(286, 23);
            this.progressBarCurrentMonth.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(317, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 199);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Overall statistics";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current savings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total expenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average monthly expenses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average monthly income";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.monthCalendar1);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(627, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 487);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected month";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 313);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Most common expense category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Highest income";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Highest expense";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Remained";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Expenses";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Incomes";
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
            // buttonResetChanges
            // 
            this.buttonResetChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetChanges.Location = new System.Drawing.Point(499, 288);
            this.buttonResetChanges.Name = "buttonResetChanges";
            this.buttonResetChanges.Size = new System.Drawing.Size(98, 23);
            this.buttonResetChanges.TabIndex = 7;
            this.buttonResetChanges.Text = "Reset changes";
            this.buttonResetChanges.UseVisualStyleBackColor = true;
            this.buttonResetChanges.Click += new System.EventHandler(this.buttonResetChanges_Click);
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
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Text = "Simply Budget.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatestRecords)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarCurrentMonth;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
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
    }
}

