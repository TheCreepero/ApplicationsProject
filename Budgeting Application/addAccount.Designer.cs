using System.Windows.Forms;

namespace Budgeting_Application
{
    partial class addAccount
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accNameText = new System.Windows.Forms.TextBox();
            this.accTypeBox = new System.Windows.Forms.ComboBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.accName,
            this.accType});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(276, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // accName
            // 
            this.accName.HeaderText = "Name";
            this.accName.Name = "accName";
            this.accName.ReadOnly = true;
            // 
            // accType
            // 
            this.accType.HeaderText = "Type";
            this.accType.Name = "accType";
            this.accType.ReadOnly = true;
            // 
            // accNameText
            // 
            this.accNameText.Location = new System.Drawing.Point(12, 213);
            this.accNameText.MinimumSize = new System.Drawing.Size(134, 21);
            this.accNameText.Name = "accNameText";
            this.accNameText.Size = new System.Drawing.Size(134, 21);
            this.accNameText.TabIndex = 1;
            // 
            // accTypeBox
            // 
            this.accTypeBox.FormattingEnabled = true;
            this.accTypeBox.Location = new System.Drawing.Point(154, 213);
            this.accTypeBox.Name = "accTypeBox";
            this.accTypeBox.Size = new System.Drawing.Size(134, 21);
            this.accTypeBox.TabIndex = 2;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(111, 240);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.addCategoryButton.TabIndex = 3;
            this.addCategoryButton.Text = "Add";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 267);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.accTypeBox);
            this.Controls.Add(this.accNameText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "addAccount";
            this.Text = "Add a new product category";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accType;
        private TextBox accNameText;
        private ComboBox accTypeBox;
        private Button addCategoryButton;
    }
}