namespace Bogys_Winforms.Windows.Admin
{
    partial class RentalModule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            VideoView = new DataGridView();
            rentBtn = new Button();
            searchTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            videoTypeCbx = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            titleTxt = new TextBox();
            txtUserID = new TextBox();
            priceTxt = new TextBox();
            label4 = new Label();
            categoryTxt = new TextBox();
            label7 = new Label();
            rentDaysTxt = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)VideoView).BeginInit();
            SuspendLayout();
            // 
            // VideoView
            // 
            VideoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VideoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoView.Location = new Point(340, 200);
            VideoView.MultiSelect = false;
            VideoView.Name = "VideoView";
            VideoView.RowHeadersWidth = 62;
            VideoView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VideoView.Size = new Size(1225, 711);
            VideoView.TabIndex = 34;
            VideoView.CellClick += VideoView_CellClick;
            // 
            // rentBtn
            // 
            rentBtn.BackColor = Color.FromArgb(225, 107, 87);
            rentBtn.FlatAppearance.BorderSize = 0;
            rentBtn.FlatStyle = FlatStyle.Flat;
            rentBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentBtn.ForeColor = Color.FromArgb(255, 228, 186);
            rentBtn.Location = new Point(79, 665);
            rentBtn.Name = "rentBtn";
            rentBtn.Size = new Size(181, 49);
            rentBtn.TabIndex = 31;
            rentBtn.Text = "Rent";
            rentBtn.UseVisualStyleBackColor = false;
            rentBtn.Click += rentBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.BorderStyle = BorderStyle.FixedSingle;
            searchTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.ForeColor = Color.Black;
            searchTxt.Location = new Point(340, 148);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "Search by Title";
            searchTxt.Size = new Size(280, 34);
            searchTxt.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(686, 151);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 29;
            label3.Text = "Video Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(79, 94);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 27;
            label2.Text = "Return Videos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 228, 186);
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 28;
            label1.Text = "Rental Module";
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "DVD", "VCD" });
            videoTypeCbx.Location = new Point(792, 148);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(152, 33);
            videoTypeCbx.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F);
            label5.ForeColor = Color.FromArgb(255, 228, 186);
            label5.Location = new Point(79, 539);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 29;
            label5.Text = "Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 9F);
            label6.ForeColor = Color.FromArgb(255, 228, 186);
            label6.Location = new Point(79, 200);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 29;
            label6.Text = "Title :";
            // 
            // titleTxt
            // 
            titleTxt.BorderStyle = BorderStyle.FixedSingle;
            titleTxt.Enabled = false;
            titleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxt.ForeColor = Color.Black;
            titleTxt.Location = new Point(79, 228);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(181, 34);
            titleTxt.TabIndex = 30;
            // 
            // txtUserID
            // 
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Enabled = false;
            txtUserID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserID.ForeColor = Color.Black;
            txtUserID.Location = new Point(1406, 62);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(159, 34);
            txtUserID.TabIndex = 30;
            // 
            // priceTxt
            // 
            priceTxt.BorderStyle = BorderStyle.FixedSingle;
            priceTxt.Enabled = false;
            priceTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTxt.ForeColor = Color.Black;
            priceTxt.Location = new Point(79, 567);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(181, 34);
            priceTxt.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.FromArgb(255, 228, 186);
            label4.Location = new Point(79, 421);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 29;
            label4.Text = "Category:";
            // 
            // categoryTxt
            // 
            categoryTxt.BorderStyle = BorderStyle.FixedSingle;
            categoryTxt.Enabled = false;
            categoryTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryTxt.ForeColor = Color.Black;
            categoryTxt.Location = new Point(79, 449);
            categoryTxt.Name = "categoryTxt";
            categoryTxt.Size = new Size(181, 34);
            categoryTxt.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 9F);
            label7.ForeColor = Color.FromArgb(255, 228, 186);
            label7.Location = new Point(79, 306);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 29;
            label7.Text = "Rent Day(s) :";
            // 
            // rentDaysTxt
            // 
            rentDaysTxt.BorderStyle = BorderStyle.FixedSingle;
            rentDaysTxt.Enabled = false;
            rentDaysTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentDaysTxt.ForeColor = Color.Black;
            rentDaysTxt.Location = new Point(79, 334);
            rentDaysTxt.Name = "rentDaysTxt";
            rentDaysTxt.Size = new Size(181, 34);
            rentDaysTxt.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 9F);
            label8.ForeColor = Color.FromArgb(255, 228, 186);
            label8.Location = new Point(1284, 69);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 29;
            label8.Text = "Customer ID :";
            // 
            // RentalModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(videoTypeCbx);
            Controls.Add(VideoView);
            Controls.Add(rentBtn);
            Controls.Add(titleTxt);
            Controls.Add(txtUserID);
            Controls.Add(rentDaysTxt);
            Controls.Add(categoryTxt);
            Controls.Add(label7);
            Controls.Add(priceTxt);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(searchTxt);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(79, 141);
            Name = "RentalModule";
            Size = new Size(1663, 1024);
            ((System.ComponentModel.ISupportInitialize)VideoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView VideoView;
        private Button rentBtn;
        private TextBox searchTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox videoTypeCbx;
        private Label label5;
        private Label label6;
        private TextBox titleTxt;
        private TextBox txtUserID;
        private TextBox priceTxt;
        private Label label4;
        private TextBox categoryTxt;
        private Label label7;
        private TextBox rentDaysTxt;
        private Label label8;
    }
}
