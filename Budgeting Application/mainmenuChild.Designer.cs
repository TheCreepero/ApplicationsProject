namespace Budgeting_Application
{
    partial class mainmenuChild
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mainDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSet = new Budgeting_Application.ApplicationData.MainDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fetchTransactions = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelReceiver = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.mainDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.mainDBDataSet1 = new Budgeting_Application.ApplicationData.MainDBDataSet();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ownedTransactionsButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.accBalLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterDatesButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filterCategoryCB = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportResultText = new System.Windows.Forms.Label();
            this.reportExpLabel = new System.Windows.Forms.Label();
            this.reportIncomeLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, child!";
            // 
            // mainDBDataSetBindingSource
            // 
            this.mainDBDataSetBindingSource.DataSource = this.mainDBDataSet;
            this.mainDBDataSetBindingSource.Position = 0;
            // 
            // mainDBDataSet
            // 
            this.mainDBDataSet.DataSetName = "MainDBDataSet";
            this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amount,
            this.accountid,
            this.payerid,
            this.owner,
            this.date,
            this.receiver,
            this.product,
            this.description,
            this.EventID});
            this.dataGridView1.Location = new System.Drawing.Point(15, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(818, 458);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // amount
            // 
            this.amount.FillWeight = 51.76816F;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // accountid
            // 
            this.accountid.FillWeight = 45.46315F;
            this.accountid.HeaderText = "Category";
            this.accountid.Name = "accountid";
            this.accountid.ReadOnly = true;
            // 
            // payerid
            // 
            this.payerid.FillWeight = 45.46315F;
            this.payerid.HeaderText = "User Account";
            this.payerid.Name = "payerid";
            this.payerid.ReadOnly = true;
            // 
            // owner
            // 
            this.owner.FillWeight = 45.46315F;
            this.owner.HeaderText = "Owner";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            // 
            // date
            // 
            this.date.FillWeight = 45.46315F;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // receiver
            // 
            this.receiver.FillWeight = 45.46315F;
            this.receiver.HeaderText = "Receiver";
            this.receiver.Name = "receiver";
            this.receiver.ReadOnly = true;
            // 
            // product
            // 
            this.product.FillWeight = 45.46315F;
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // description
            // 
            this.description.FillWeight = 45.46315F;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // EventID
            // 
            this.EventID.FillWeight = 10F;
            this.EventID.HeaderText = "ID";
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            this.EventID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fetchTransactions
            // 
            this.fetchTransactions.Location = new System.Drawing.Point(980, 35);
            this.fetchTransactions.Name = "fetchTransactions";
            this.fetchTransactions.Size = new System.Drawing.Size(134, 26);
            this.fetchTransactions.TabIndex = 2;
            this.fetchTransactions.Text = "List my transactions";
            this.fetchTransactions.UseVisualStyleBackColor = true;
            this.fetchTransactions.Click += new System.EventHandler(this.fetchTransactions_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(1056, 544);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(981, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(981, 291);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(981, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(981, 367);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 20);
            this.textBox4.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(981, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(977, 120);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 17;
            this.labelAmount.Text = "Amount";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(977, 158);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 18;
            this.labelCategory.Text = "Category";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(977, 198);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(38, 13);
            this.labelOwner.TabIndex = 21;
            this.labelOwner.Text = "Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(977, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.mm.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(981, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // labelReceiver
            // 
            this.labelReceiver.AutoSize = true;
            this.labelReceiver.Location = new System.Drawing.Point(977, 274);
            this.labelReceiver.Name = "labelReceiver";
            this.labelReceiver.Size = new System.Drawing.Size(161, 13);
            this.labelReceiver.TabIndex = 24;
            this.labelReceiver.Text = "Receiver (leave empty if income)";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(977, 312);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(44, 13);
            this.labelProduct.TabIndex = 25;
            this.labelProduct.Text = "Product";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(977, 350);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(161, 13);
            this.labelDesc.TabIndex = 26;
            this.labelDesc.Text = "Description (please keep it short)";
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Location = new System.Drawing.Point(981, 393);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(133, 30);
            this.buttonAddEvent.TabIndex = 27;
            this.buttonAddEvent.Text = "Add new event";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // mainDBDataSetBindingSource1
            // 
            this.mainDBDataSetBindingSource1.DataSource = this.mainDBDataSet;
            this.mainDBDataSetBindingSource1.Position = 0;
            // 
            // mainDBDataSetBindingSource2
            // 
            this.mainDBDataSetBindingSource2.DataSource = this.mainDBDataSet;
            this.mainDBDataSetBindingSource2.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(977, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Add a new transaction:";
            // 
            // mainDBDataSet1
            // 
            this.mainDBDataSet1.DataSetName = "MainDBDataSet";
            this.mainDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(61, 29);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(10, 13);
            this.balanceLabel.TabIndex = 30;
            this.balanceLabel.Text = "-";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(981, 429);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(133, 30);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(980, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 32;
            // 
            // ownedTransactionsButton
            // 
            this.ownedTransactionsButton.Location = new System.Drawing.Point(980, 67);
            this.ownedTransactionsButton.Name = "ownedTransactionsButton";
            this.ownedTransactionsButton.Size = new System.Drawing.Size(134, 26);
            this.ownedTransactionsButton.TabIndex = 33;
            this.ownedTransactionsButton.Text = "List owned transactions";
            this.ownedTransactionsButton.UseVisualStyleBackColor = true;
            this.ownedTransactionsButton.Click += new System.EventHandler(this.ownedTransactionsButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.expenseLabel);
            this.groupBox3.Controls.Add(this.incomeLabel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.userNameLabel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.accBalLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(570, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 68);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Information";
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.Location = new System.Drawing.Point(226, 36);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(10, 13);
            this.expenseLabel.TabIndex = 7;
            this.expenseLabel.Text = "-";
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(226, 16);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(10, 13);
            this.incomeLabel.TabIndex = 6;
            this.incomeLabel.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Expenses:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Incomes:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(87, 16);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(10, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "User Account:";
            // 
            // accBalLabel
            // 
            this.accBalLabel.AutoSize = true;
            this.accBalLabel.Location = new System.Drawing.Point(61, 36);
            this.accBalLabel.Name = "accBalLabel";
            this.accBalLabel.Size = new System.Drawing.Size(10, 13);
            this.accBalLabel.TabIndex = 1;
            this.accBalLabel.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Balance:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterDatesButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(204, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 68);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            // 
            // filterDatesButton
            // 
            this.filterDatesButton.Location = new System.Drawing.Point(296, 11);
            this.filterDatesButton.Name = "filterDatesButton";
            this.filterDatesButton.Size = new System.Drawing.Size(58, 52);
            this.filterDatesButton.TabIndex = 40;
            this.filterDatesButton.Text = "Refresh";
            this.filterDatesButton.UseVisualStyleBackColor = true;
            this.filterDatesButton.Click += new System.EventHandler(this.filterDatesButton_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "-";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(155, 34);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker3.TabIndex = 41;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.filterCategoryCB);
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 68);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Category";
            // 
            // filterCategoryCB
            // 
            this.filterCategoryCB.FormattingEnabled = true;
            this.filterCategoryCB.Location = new System.Drawing.Point(6, 33);
            this.filterCategoryCB.Name = "filterCategoryCB";
            this.filterCategoryCB.Size = new System.Drawing.Size(107, 21);
            this.filterCategoryCB.TabIndex = 37;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(119, 11);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(58, 52);
            this.filterButton.TabIndex = 38;
            this.filterButton.Text = "Refresh";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(843, 155);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(131, 46);
            this.generateReportButton.TabIndex = 53;
            this.generateReportButton.Text = "Generate report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reportResultText);
            this.groupBox4.Controls.Add(this.reportExpLabel);
            this.groupBox4.Controls.Add(this.reportIncomeLabel);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.balanceLabel);
            this.groupBox4.Location = new System.Drawing.Point(843, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 114);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report";
            // 
            // reportResultText
            // 
            this.reportResultText.AutoSize = true;
            this.reportResultText.Location = new System.Drawing.Point(9, 93);
            this.reportResultText.Name = "reportResultText";
            this.reportResultText.Size = new System.Drawing.Size(10, 13);
            this.reportResultText.TabIndex = 33;
            this.reportResultText.Text = "-";
            // 
            // reportExpLabel
            // 
            this.reportExpLabel.AutoSize = true;
            this.reportExpLabel.Location = new System.Drawing.Point(61, 69);
            this.reportExpLabel.Name = "reportExpLabel";
            this.reportExpLabel.Size = new System.Drawing.Size(10, 13);
            this.reportExpLabel.TabIndex = 32;
            this.reportExpLabel.Text = "-";
            // 
            // reportIncomeLabel
            // 
            this.reportIncomeLabel.AutoSize = true;
            this.reportIncomeLabel.Location = new System.Drawing.Point(61, 49);
            this.reportIncomeLabel.Name = "reportIncomeLabel";
            this.reportIncomeLabel.Size = new System.Drawing.Size(10, 13);
            this.reportIncomeLabel.TabIndex = 31;
            this.reportIncomeLabel.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Expenses:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Balance:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Incomes:";
            // 
            // mainmenuChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 580);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ownedTransactionsButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelReceiver);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.fetchTransactions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "mainmenuChild";
            this.Text = "Budgeting Application - Child User";
            this.Load += new System.EventHandler(this.mainmenuChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mainDBDataSetBindingSource;
        private ApplicationData.MainDBDataSet mainDBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button fetchTransactions;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelReceiver;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.BindingSource mainDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource mainDBDataSetBindingSource2;
        private System.Windows.Forms.Label label3;
        private ApplicationData.MainDBDataSet mainDBDataSet1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountid;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button ownedTransactionsButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label accBalLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button filterDatesButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filterCategoryCB;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label reportResultText;
        private System.Windows.Forms.Label reportExpLabel;
        private System.Windows.Forms.Label reportIncomeLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}