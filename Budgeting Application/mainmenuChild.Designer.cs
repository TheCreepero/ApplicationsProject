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
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
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
            // mainmenuChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 642);
            this.Controls.Add(this.label1);
            this.Name = "mainmenuChild";
            this.Text = "Budgeting Application - Child User";
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mainDBDataSetBindingSource;
        private ApplicationData.MainDBDataSet mainDBDataSet;
    }
}