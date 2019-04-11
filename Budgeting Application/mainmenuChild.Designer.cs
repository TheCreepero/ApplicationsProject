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
            this.fetchTransactions = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(15, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(882, 595);
            this.dataGridView1.TabIndex = 1;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // accountid
            // 
            this.accountid.HeaderText = "Category";
            this.accountid.Name = "accountid";
            // 
            // payerid
            // 
            this.payerid.HeaderText = "Payer";
            this.payerid.Name = "payerid";
            // 
            // owner
            // 
            this.owner.HeaderText = "Purchase Owner";
            this.owner.Name = "owner";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // receiver
            // 
            this.receiver.HeaderText = "Receiver/Payer";
            this.receiver.Name = "receiver";
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // fetchTransactions
            // 
            this.fetchTransactions.Location = new System.Drawing.Point(927, 35);
            this.fetchTransactions.Name = "fetchTransactions";
            this.fetchTransactions.Size = new System.Drawing.Size(183, 34);
            this.fetchTransactions.TabIndex = 2;
            this.fetchTransactions.Text = "List my transactions";
            this.fetchTransactions.UseVisualStyleBackColor = true;
            this.fetchTransactions.Click += new System.EventHandler(this.fetchTransactions_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(1052, 607);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // mainmenuChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 642);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.fetchTransactions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "mainmenuChild";
            this.Text = "Budgeting Application - Child User";
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mainDBDataSetBindingSource;
        private ApplicationData.MainDBDataSet mainDBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountid;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button fetchTransactions;
        private System.Windows.Forms.Button exitbutton;
    }
}