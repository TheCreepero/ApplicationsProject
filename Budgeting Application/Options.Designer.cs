namespace Budgeting_Application
{
    partial class Options
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
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userLvlSelect = new System.Windows.Forms.ComboBox();
            this.addUserName = new System.Windows.Forms.TextBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
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
            this.Username,
            this.AccessLevel,
            this.UserID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(207, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // Username
            // 
            this.Username.FillWeight = 134.7716F;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // AccessLevel
            // 
            this.AccessLevel.FillWeight = 134.7716F;
            this.AccessLevel.HeaderText = "User Level";
            this.AccessLevel.Name = "AccessLevel";
            this.AccessLevel.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.FillWeight = 30.45685F;
            this.UserID.HeaderText = "ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(123, 313);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(97, 21);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userLvlSelect
            // 
            this.userLvlSelect.FormattingEnabled = true;
            this.userLvlSelect.Location = new System.Drawing.Point(13, 353);
            this.userLvlSelect.Name = "userLvlSelect";
            this.userLvlSelect.Size = new System.Drawing.Size(97, 21);
            this.userLvlSelect.TabIndex = 2;
            // 
            // addUserName
            // 
            this.addUserName.Location = new System.Drawing.Point(13, 313);
            this.addUserName.MinimumSize = new System.Drawing.Size(97, 21);
            this.addUserName.Name = "addUserName";
            this.addUserName.Size = new System.Drawing.Size(97, 21);
            this.addUserName.TabIndex = 3;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(13, 380);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(207, 29);
            this.deleteUserButton.TabIndex = 4;
            this.deleteUserButton.Text = "Delete user";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(13, 415);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(207, 29);
            this.addAccountButton.TabIndex = 5;
            this.addAccountButton.Text = "Edit Categories";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(123, 353);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(97, 21);
            this.updateUserButton.TabIndex = 6;
            this.updateUserButton.Text = "Update selected";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Level";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(168, 472);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(52, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 507);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addUserName);
            this.Controls.Add(this.userLvlSelect);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ComboBox userLvlSelect;
        private System.Windows.Forms.TextBox addUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
    }
}