namespace Bogys_Winforms.Windows.Admin
{
    partial class RentalReport
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
            dateTxt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            reportView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)reportView).BeginInit();
            SuspendLayout();
            // 
            // dateTxt
            // 
            dateTxt.BackColor = SystemColors.Control;
            dateTxt.BorderStyle = BorderStyle.None;
            dateTxt.Font = new Font("Segoe UI Semilight", 9F);
            dateTxt.Location = new Point(1069, 59);
            dateTxt.Name = "dateTxt";
            dateTxt.ReadOnly = true;
            dateTxt.Size = new Size(216, 24);
            dateTxt.TabIndex = 25;
            dateTxt.Text = "DD/MM/YYYY";
            dateTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1069, 31);
            label3.Name = "label3";
            label3.Size = new Size(216, 25);
            label3.TabIndex = 24;
            label3.Text = "Bogsy Video Rental Store™";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(73, 51);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 23;
            label1.Text = "Rental Report";
            // 
            // reportView
            // 
            reportView.AllowUserToAddRows = false;
            reportView.AllowUserToDeleteRows = false;
            reportView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportView.BackgroundColor = SystemColors.Control;
            reportView.BorderStyle = BorderStyle.None;
            reportView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportView.Location = new Point(73, 123);
            reportView.Name = "reportView";
            reportView.ReadOnly = true;
            reportView.RowHeadersWidth = 62;
            reportView.Size = new Size(1212, 473);
            reportView.TabIndex = 22;
            // 
            // RentalReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 635);
            Controls.Add(dateTxt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(reportView);
            MaximizeBox = false;
            Name = "RentalReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RentalReport";
            ((System.ComponentModel.ISupportInitialize)reportView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dateTxt;
        private Label label3;
        private Label label1;
        private DataGridView reportView;
    }
}