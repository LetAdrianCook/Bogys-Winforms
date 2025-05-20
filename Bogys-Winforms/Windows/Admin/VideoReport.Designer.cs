namespace Bogys_Winforms.Windows.Admin
{
    partial class VideoReport
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
            reportView = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            dateTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)reportView).BeginInit();
            SuspendLayout();
            // 
            // reportView
            // 
            reportView.AllowUserToAddRows = false;
            reportView.AllowUserToDeleteRows = false;
            reportView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportView.BackgroundColor = SystemColors.Control;
            reportView.BorderStyle = BorderStyle.None;
            reportView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportView.Location = new Point(76, 118);
            reportView.Name = "reportView";
            reportView.ReadOnly = true;
            reportView.RowHeadersWidth = 62;
            reportView.Size = new Size(896, 436);
            reportView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(76, 46);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 19;
            label1.Text = "Video Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(756, 37);
            label3.Name = "label3";
            label3.Size = new Size(216, 25);
            label3.TabIndex = 20;
            label3.Text = "Bogsy Video Rental Store™";
            // 
            // dateTxt
            // 
            dateTxt.BackColor = SystemColors.Control;
            dateTxt.BorderStyle = BorderStyle.None;
            dateTxt.Font = new Font("Segoe UI Semilight", 9F);
            dateTxt.Location = new Point(756, 65);
            dateTxt.Name = "dateTxt";
            dateTxt.ReadOnly = true;
            dateTxt.Size = new Size(216, 24);
            dateTxt.TabIndex = 21;
            dateTxt.Text = "DD/MM/YYYY";
            dateTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // VideoReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 600);
            Controls.Add(dateTxt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(reportView);
            MaximizeBox = false;
            Name = "VideoReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VideoReport";
            ((System.ComponentModel.ISupportInitialize)reportView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView reportView;
        private Label label1;
        private Label label3;
        private TextBox dateTxt;
    }
}