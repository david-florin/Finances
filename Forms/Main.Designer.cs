namespace Spending_App2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dateTimePickerDateSelector = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelBalanceAmount = new System.Windows.Forms.Label();
            this.tabControlPages = new System.Windows.Forms.TabControl();
            this.tabPageAddToBalance = new System.Windows.Forms.TabPage();
            this.buttonAddAmount = new System.Windows.Forms.Button();
            this.labelAmmountQuestion = new System.Windows.Forms.Label();
            this.textBoxAddAmount = new System.Windows.Forms.TextBox();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.dateTimePickerDisplayDate = new System.Windows.Forms.DateTimePicker();
            this.buttonDeleteTransaction = new System.Windows.Forms.Button();
            this.buttonUpdateTransaction = new System.Windows.Forms.Button();
            this.textBoxDisplayNote = new System.Windows.Forms.TextBox();
            this.textBoxDisplayCategory = new System.Windows.Forms.TextBox();
            this.textBoxDisplaySum = new System.Windows.Forms.TextBox();
            this.labelDisplayDate = new System.Windows.Forms.Label();
            this.labelDisplayNote = new System.Windows.Forms.Label();
            this.labelDisplayCategory = new System.Windows.Forms.Label();
            this.labelDisplaySum = new System.Windows.Forms.Label();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.tabPageAddTransaction = new System.Windows.Forms.TabPage();
            this.buttonAddTrans = new System.Windows.Forms.Button();
            this.dateTimePickerTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTransactionNote = new System.Windows.Forms.TextBox();
            this.comboBoxTransactionCategory = new System.Windows.Forms.ComboBox();
            this.textBoxTransactionSum = new System.Windows.Forms.TextBox();
            this.labelTransactionNote = new System.Windows.Forms.Label();
            this.labelTransactionCategory = new System.Windows.Forms.Label();
            this.labelTransactionDate = new System.Windows.Forms.Label();
            this.labelTransactionSum = new System.Windows.Forms.Label();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.buttonLoadCharts = new System.Windows.Forms.Button();
            this.chartDays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.tabControlPages.SuspendLayout();
            this.tabPageAddToBalance.SuspendLayout();
            this.tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.tabPageAddTransaction.SuspendLayout();
            this.tabPageReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDateSelector
            // 
            this.dateTimePickerDateSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateSelector.CustomFormat = "  dd/MM/yyyy";
            this.dateTimePickerDateSelector.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateTimePickerDateSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateSelector.Location = new System.Drawing.Point(984, 11);
            this.dateTimePickerDateSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDateSelector.Name = "dateTimePickerDateSelector";
            this.dateTimePickerDateSelector.Size = new System.Drawing.Size(152, 26);
            this.dateTimePickerDateSelector.TabIndex = 7;
            this.dateTimePickerDateSelector.Value = new System.DateTime(2021, 4, 13, 16, 30, 9, 0);
            this.dateTimePickerDateSelector.ValueChanged += new System.EventHandler(this.dateTimePickerDateSelector_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, -94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBoxIcon);
            this.panel1.Controls.Add(this.dateTimePickerDateSelector);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 38);
            this.panel1.TabIndex = 9;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(64, 38);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 10;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(12, 39);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(63, 17);
            this.labelBalance.TabIndex = 10;
            this.labelBalance.Text = "Balance:";
            // 
            // labelBalanceAmount
            // 
            this.labelBalanceAmount.AutoSize = true;
            this.labelBalanceAmount.Location = new System.Drawing.Point(98, 39);
            this.labelBalanceAmount.Name = "labelBalanceAmount";
            this.labelBalanceAmount.Size = new System.Drawing.Size(32, 17);
            this.labelBalanceAmount.TabIndex = 11;
            this.labelBalanceAmount.Text = "000";
            // 
            // tabControlPages
            // 
            this.tabControlPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPages.Controls.Add(this.tabPageAddToBalance);
            this.tabControlPages.Controls.Add(this.tabPageTransactions);
            this.tabControlPages.Controls.Add(this.tabPageAddTransaction);
            this.tabControlPages.Controls.Add(this.tabPageReports);
            this.tabControlPages.Location = new System.Drawing.Point(12, 98);
            this.tabControlPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 3;
            this.tabControlPages.Size = new System.Drawing.Size(1118, 404);
            this.tabControlPages.TabIndex = 14;
            this.tabControlPages.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageAddToBalance
            // 
            this.tabPageAddToBalance.Controls.Add(this.buttonAddAmount);
            this.tabPageAddToBalance.Controls.Add(this.labelAmmountQuestion);
            this.tabPageAddToBalance.Controls.Add(this.textBoxAddAmount);
            this.tabPageAddToBalance.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddToBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddToBalance.Name = "tabPageAddToBalance";
            this.tabPageAddToBalance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddToBalance.Size = new System.Drawing.Size(1110, 375);
            this.tabPageAddToBalance.TabIndex = 0;
            this.tabPageAddToBalance.Text = "Add to balance";
            this.tabPageAddToBalance.UseVisualStyleBackColor = true;
            // 
            // buttonAddAmount
            // 
            this.buttonAddAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddAmount.Location = new System.Drawing.Point(28, 92);
            this.buttonAddAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAmount.Name = "buttonAddAmount";
            this.buttonAddAmount.Size = new System.Drawing.Size(98, 24);
            this.buttonAddAmount.TabIndex = 2;
            this.buttonAddAmount.Text = "Add";
            this.buttonAddAmount.UseVisualStyleBackColor = true;
            this.buttonAddAmount.Click += new System.EventHandler(this.buttonAddAmount_Click);
            // 
            // labelAmmountQuestion
            // 
            this.labelAmmountQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAmmountQuestion.AutoSize = true;
            this.labelAmmountQuestion.Location = new System.Drawing.Point(6, 14);
            this.labelAmmountQuestion.Name = "labelAmmountQuestion";
            this.labelAmmountQuestion.Size = new System.Drawing.Size(149, 17);
            this.labelAmmountQuestion.TabIndex = 1;
            this.labelAmmountQuestion.Text = "What is your balance?";
            // 
            // textBoxAddAmount
            // 
            this.textBoxAddAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAddAmount.Location = new System.Drawing.Point(6, 47);
            this.textBoxAddAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddAmount.MaximumSize = new System.Drawing.Size(200, 200);
            this.textBoxAddAmount.MinimumSize = new System.Drawing.Size(100, 27);
            this.textBoxAddAmount.Name = "textBoxAddAmount";
            this.textBoxAddAmount.Size = new System.Drawing.Size(150, 22);
            this.textBoxAddAmount.TabIndex = 0;
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.dateTimePickerDisplayDate);
            this.tabPageTransactions.Controls.Add(this.buttonDeleteTransaction);
            this.tabPageTransactions.Controls.Add(this.buttonUpdateTransaction);
            this.tabPageTransactions.Controls.Add(this.textBoxDisplayNote);
            this.tabPageTransactions.Controls.Add(this.textBoxDisplayCategory);
            this.tabPageTransactions.Controls.Add(this.textBoxDisplaySum);
            this.tabPageTransactions.Controls.Add(this.labelDisplayDate);
            this.tabPageTransactions.Controls.Add(this.labelDisplayNote);
            this.tabPageTransactions.Controls.Add(this.labelDisplayCategory);
            this.tabPageTransactions.Controls.Add(this.labelDisplaySum);
            this.tabPageTransactions.Controls.Add(this.dataGridViewTransactions);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 25);
            this.tabPageTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTransactions.Size = new System.Drawing.Size(1110, 375);
            this.tabPageTransactions.TabIndex = 1;
            this.tabPageTransactions.Text = "Transactions";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            this.tabPageTransactions.Click += new System.EventHandler(this.tabPageTransactions_Click);
            // 
            // dateTimePickerDisplayDate
            // 
            this.dateTimePickerDisplayDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDisplayDate.CustomFormat = "  dd/MM/yyyy";
            this.dateTimePickerDisplayDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateTimePickerDisplayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDisplayDate.Location = new System.Drawing.Point(846, 159);
            this.dateTimePickerDisplayDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDisplayDate.Name = "dateTimePickerDisplayDate";
            this.dateTimePickerDisplayDate.Size = new System.Drawing.Size(160, 26);
            this.dateTimePickerDisplayDate.TabIndex = 11;
            this.dateTimePickerDisplayDate.Value = new System.DateTime(2021, 4, 13, 16, 30, 35, 0);
            // 
            // buttonDeleteTransaction
            // 
            this.buttonDeleteTransaction.Location = new System.Drawing.Point(931, 210);
            this.buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            this.buttonDeleteTransaction.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTransaction.TabIndex = 10;
            this.buttonDeleteTransaction.Text = "Delete";
            this.buttonDeleteTransaction.UseVisualStyleBackColor = true;
            this.buttonDeleteTransaction.Click += new System.EventHandler(this.buttonDeleteTransaction_Click);
            // 
            // buttonUpdateTransaction
            // 
            this.buttonUpdateTransaction.Location = new System.Drawing.Point(846, 210);
            this.buttonUpdateTransaction.Name = "buttonUpdateTransaction";
            this.buttonUpdateTransaction.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTransaction.TabIndex = 9;
            this.buttonUpdateTransaction.Text = "Update";
            this.buttonUpdateTransaction.UseVisualStyleBackColor = true;
            this.buttonUpdateTransaction.Click += new System.EventHandler(this.buttonUpdateTransaction_Click);
            // 
            // textBoxDisplayNote
            // 
            this.textBoxDisplayNote.Location = new System.Drawing.Point(846, 120);
            this.textBoxDisplayNote.Name = "textBoxDisplayNote";
            this.textBoxDisplayNote.Size = new System.Drawing.Size(160, 22);
            this.textBoxDisplayNote.TabIndex = 7;
            // 
            // textBoxDisplayCategory
            // 
            this.textBoxDisplayCategory.Location = new System.Drawing.Point(846, 77);
            this.textBoxDisplayCategory.Name = "textBoxDisplayCategory";
            this.textBoxDisplayCategory.Size = new System.Drawing.Size(160, 22);
            this.textBoxDisplayCategory.TabIndex = 6;
            // 
            // textBoxDisplaySum
            // 
            this.textBoxDisplaySum.Location = new System.Drawing.Point(846, 30);
            this.textBoxDisplaySum.Name = "textBoxDisplaySum";
            this.textBoxDisplaySum.Size = new System.Drawing.Size(160, 22);
            this.textBoxDisplaySum.TabIndex = 5;
            // 
            // labelDisplayDate
            // 
            this.labelDisplayDate.AutoSize = true;
            this.labelDisplayDate.Location = new System.Drawing.Point(770, 167);
            this.labelDisplayDate.Name = "labelDisplayDate";
            this.labelDisplayDate.Size = new System.Drawing.Size(42, 17);
            this.labelDisplayDate.TabIndex = 4;
            this.labelDisplayDate.Text = "Date:";
            // 
            // labelDisplayNote
            // 
            this.labelDisplayNote.AutoSize = true;
            this.labelDisplayNote.Location = new System.Drawing.Point(770, 123);
            this.labelDisplayNote.Name = "labelDisplayNote";
            this.labelDisplayNote.Size = new System.Drawing.Size(38, 17);
            this.labelDisplayNote.TabIndex = 3;
            this.labelDisplayNote.Text = "Note";
            // 
            // labelDisplayCategory
            // 
            this.labelDisplayCategory.AutoSize = true;
            this.labelDisplayCategory.Location = new System.Drawing.Point(770, 80);
            this.labelDisplayCategory.Name = "labelDisplayCategory";
            this.labelDisplayCategory.Size = new System.Drawing.Size(65, 17);
            this.labelDisplayCategory.TabIndex = 2;
            this.labelDisplayCategory.Text = "Category";
            // 
            // labelDisplaySum
            // 
            this.labelDisplaySum.AutoSize = true;
            this.labelDisplaySum.Location = new System.Drawing.Point(770, 30);
            this.labelDisplaySum.Name = "labelDisplaySum";
            this.labelDisplaySum.Size = new System.Drawing.Size(40, 17);
            this.labelDisplaySum.TabIndex = 1;
            this.labelDisplaySum.Text = "Sum:";
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.ReadOnly = true;
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(733, 371);
            this.dataGridViewTransactions.TabIndex = 0;
            this.dataGridViewTransactions.Text = "dataGridView1";
            this.dataGridViewTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactions_CellContentClick);
            // 
            // tabPageAddTransaction
            // 
            this.tabPageAddTransaction.Controls.Add(this.buttonAddTrans);
            this.tabPageAddTransaction.Controls.Add(this.dateTimePickerTransactionDate);
            this.tabPageAddTransaction.Controls.Add(this.textBoxTransactionNote);
            this.tabPageAddTransaction.Controls.Add(this.comboBoxTransactionCategory);
            this.tabPageAddTransaction.Controls.Add(this.textBoxTransactionSum);
            this.tabPageAddTransaction.Controls.Add(this.labelTransactionNote);
            this.tabPageAddTransaction.Controls.Add(this.labelTransactionCategory);
            this.tabPageAddTransaction.Controls.Add(this.labelTransactionDate);
            this.tabPageAddTransaction.Controls.Add(this.labelTransactionSum);
            this.tabPageAddTransaction.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddTransaction.Name = "tabPageAddTransaction";
            this.tabPageAddTransaction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddTransaction.Size = new System.Drawing.Size(1110, 375);
            this.tabPageAddTransaction.TabIndex = 2;
            this.tabPageAddTransaction.Text = "Add Transaction";
            this.tabPageAddTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonAddTrans
            // 
            this.buttonAddTrans.Location = new System.Drawing.Point(176, 196);
            this.buttonAddTrans.Name = "buttonAddTrans";
            this.buttonAddTrans.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTrans.TabIndex = 5;
            this.buttonAddTrans.Text = "Add";
            this.buttonAddTrans.UseVisualStyleBackColor = true;
            this.buttonAddTrans.Click += new System.EventHandler(this.buttonAddTrans_Click);
            // 
            // dateTimePickerTransactionDate
            // 
            this.dateTimePickerTransactionDate.CustomFormat = "     dd/MM/yyyy";
            this.dateTimePickerTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTransactionDate.Location = new System.Drawing.Point(145, 147);
            this.dateTimePickerTransactionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            this.dateTimePickerTransactionDate.Size = new System.Drawing.Size(151, 22);
            this.dateTimePickerTransactionDate.TabIndex = 4;
            // 
            // textBoxTransactionNote
            // 
            this.textBoxTransactionNote.Location = new System.Drawing.Point(145, 106);
            this.textBoxTransactionNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTransactionNote.Name = "textBoxTransactionNote";
            this.textBoxTransactionNote.Size = new System.Drawing.Size(151, 22);
            this.textBoxTransactionNote.TabIndex = 3;
            // 
            // comboBoxTransactionCategory
            // 
            this.comboBoxTransactionCategory.FormattingEnabled = true;
            this.comboBoxTransactionCategory.Items.AddRange(new object[] {
            "Groceries",
            "Restaurant",
            "Cafe",
            "Bill",
            "Rent",
            "Transportation",
            "Shopping",
            "Entertainment",
            "Travel",
            "Health & Fitness",
            "Gifts & Donations",
            "Family",
            "Education",
            "Investment",
            "Business",
            "Insurances",
            "Others"});
            this.comboBoxTransactionCategory.Location = new System.Drawing.Point(145, 64);
            this.comboBoxTransactionCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTransactionCategory.Name = "comboBoxTransactionCategory";
            this.comboBoxTransactionCategory.Size = new System.Drawing.Size(151, 24);
            this.comboBoxTransactionCategory.TabIndex = 2;
            // 
            // textBoxTransactionSum
            // 
            this.textBoxTransactionSum.Location = new System.Drawing.Point(145, 18);
            this.textBoxTransactionSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTransactionSum.Name = "textBoxTransactionSum";
            this.textBoxTransactionSum.Size = new System.Drawing.Size(151, 22);
            this.textBoxTransactionSum.TabIndex = 1;
            // 
            // labelTransactionNote
            // 
            this.labelTransactionNote.AutoSize = true;
            this.labelTransactionNote.Location = new System.Drawing.Point(10, 111);
            this.labelTransactionNote.Name = "labelTransactionNote";
            this.labelTransactionNote.Size = new System.Drawing.Size(42, 17);
            this.labelTransactionNote.TabIndex = 0;
            this.labelTransactionNote.Text = "Note:";
            // 
            // labelTransactionCategory
            // 
            this.labelTransactionCategory.AutoSize = true;
            this.labelTransactionCategory.Location = new System.Drawing.Point(10, 64);
            this.labelTransactionCategory.Name = "labelTransactionCategory";
            this.labelTransactionCategory.Size = new System.Drawing.Size(69, 17);
            this.labelTransactionCategory.TabIndex = 0;
            this.labelTransactionCategory.Text = "Category:";
            // 
            // labelTransactionDate
            // 
            this.labelTransactionDate.AutoSize = true;
            this.labelTransactionDate.Location = new System.Drawing.Point(10, 152);
            this.labelTransactionDate.Name = "labelTransactionDate";
            this.labelTransactionDate.Size = new System.Drawing.Size(42, 17);
            this.labelTransactionDate.TabIndex = 0;
            this.labelTransactionDate.Text = "Date:";
            // 
            // labelTransactionSum
            // 
            this.labelTransactionSum.AutoSize = true;
            this.labelTransactionSum.Location = new System.Drawing.Point(10, 21);
            this.labelTransactionSum.Name = "labelTransactionSum";
            this.labelTransactionSum.Size = new System.Drawing.Size(40, 17);
            this.labelTransactionSum.TabIndex = 0;
            this.labelTransactionSum.Text = "Sum:";
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.buttonLoadCharts);
            this.tabPageReports.Controls.Add(this.chartDays);
            this.tabPageReports.Controls.Add(this.chartPie);
            this.tabPageReports.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageReports.Size = new System.Drawing.Size(1110, 375);
            this.tabPageReports.TabIndex = 3;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            this.tabPageReports.Click += new System.EventHandler(this.tabPageReports_Click);
            // 
            // buttonLoadCharts
            // 
            this.buttonLoadCharts.Location = new System.Drawing.Point(726, 334);
            this.buttonLoadCharts.Name = "buttonLoadCharts";
            this.buttonLoadCharts.Size = new System.Drawing.Size(117, 23);
            this.buttonLoadCharts.TabIndex = 2;
            this.buttonLoadCharts.Text = "Load Charts";
            this.buttonLoadCharts.UseVisualStyleBackColor = true;
            this.buttonLoadCharts.Click += new System.EventHandler(this.buttonLoadCharts_Click);
            // 
            // chartDays
            // 
            this.chartDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartDays.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDays.Legends.Add(legend3);
            this.chartDays.Location = new System.Drawing.Point(453, 28);
            this.chartDays.Name = "chartDays";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Expenditure";
            this.chartDays.Series.Add(series3);
            this.chartDays.Size = new System.Drawing.Size(654, 300);
            this.chartDays.TabIndex = 1;
            this.chartDays.Text = "chart2";
            title3.Name = "TitleDays";
            title3.Text = "Expenditure by days";
            this.chartDays.Titles.Add(title3);
            // 
            // chartPie
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPie.Legends.Add(legend4);
            this.chartPie.Location = new System.Drawing.Point(6, 28);
            this.chartPie.Name = "chartPie";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPie.Series.Add(series4);
            this.chartPie.Size = new System.Drawing.Size(438, 300);
            this.chartPie.TabIndex = 0;
            this.chartPie.Text = "chartPie";
            title4.Name = "Expenditure";
            this.chartPie.Titles.Add(title4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 512);
            this.Controls.Add(this.tabControlPages);
            this.Controls.Add(this.labelBalanceAmount);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Finances";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.tabControlPages.ResumeLayout(false);
            this.tabPageAddToBalance.ResumeLayout(false);
            this.tabPageAddToBalance.PerformLayout();
            this.tabPageTransactions.ResumeLayout(false);
            this.tabPageTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.tabPageAddTransaction.ResumeLayout(false);
            this.tabPageAddTransaction.PerformLayout();
            this.tabPageReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelBalanceAmount;
        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage tabPageAddToBalance;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private System.Windows.Forms.TabPage tabPageAddTransaction;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.TextBox textBoxAddAmount;
        private System.Windows.Forms.Button buttonAddAmount;
        private System.Windows.Forms.Label labelAmmountQuestion;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Label labelTransactionNote;
        private System.Windows.Forms.Label labelTransactionCategory;
        private System.Windows.Forms.Label labelTransactionDate;
        private System.Windows.Forms.Label labelTransactionSum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDays;
        private System.Windows.Forms.Button buttonAddTrans;
        public System.Windows.Forms.TextBox textBoxTransactionNote;
        public System.Windows.Forms.ComboBox comboBoxTransactionCategory;
        public System.Windows.Forms.TextBox textBoxTransactionSum;
        public System.Windows.Forms.DateTimePicker dateTimePickerTransactionDate;
        private System.Windows.Forms.Button buttonDeleteTransaction;
        private System.Windows.Forms.Button buttonUpdateTransaction;
        private System.Windows.Forms.TextBox textBoxDisplayNote;
        private System.Windows.Forms.TextBox textBoxDisplayCategory;
        private System.Windows.Forms.TextBox textBoxDisplaySum;
        private System.Windows.Forms.Label labelDisplayDate;
        private System.Windows.Forms.Label labelDisplayNote;
        private System.Windows.Forms.Label labelDisplayCategory;
        private System.Windows.Forms.Label labelDisplaySum;
        private System.Windows.Forms.DateTimePicker dateTimePickerDisplayDate;
        private System.Windows.Forms.Button buttonLoadCharts;
    }
}

