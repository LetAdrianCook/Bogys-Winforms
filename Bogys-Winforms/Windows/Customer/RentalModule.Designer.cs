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
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            rentalDaysCbx = new ComboBox();
            label6 = new Label();
            titleTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)VideoView).BeginInit();
            SuspendLayout();
            // 
            // VideoView
            // 
            VideoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoView.Location = new Point(246, 113);
            VideoView.MultiSelect = false;
            VideoView.Name = "VideoView";
            VideoView.RowHeadersWidth = 62;
            VideoView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VideoView.Size = new Size(544, 512);
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
            rentBtn.Location = new Point(33, 413);
            rentBtn.Name = "rentBtn";
            rentBtn.Size = new Size(178, 49);
            rentBtn.TabIndex = 31;
            rentBtn.Text = "Rent";
            rentBtn.UseVisualStyleBackColor = false;
            // 
            // searchTxt
            // 
            searchTxt.BorderStyle = BorderStyle.FixedSingle;
            searchTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.ForeColor = Color.Black;
            searchTxt.Location = new Point(246, 57);
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
            label3.Location = new Point(532, 62);
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
            label2.Location = new Point(33, 66);
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
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 28;
            label1.Text = "Rental Module";
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "DVD", "VCD" });
            videoTypeCbx.Location = new Point(638, 59);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(152, 33);
            videoTypeCbx.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.FromArgb(255, 228, 186);
            label4.Location = new Point(33, 226);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 29;
            label4.Text = "Rental Day(s) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F);
            label5.ForeColor = Color.FromArgb(255, 228, 186);
            label5.Location = new Point(33, 305);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 29;
            label5.Text = "Total :";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(33, 333);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 34);
            textBox2.TabIndex = 30;
            // 
            // rentalDaysCbx
            // 
            rentalDaysCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            rentalDaysCbx.FormattingEnabled = true;
            rentalDaysCbx.Items.AddRange(new object[] { "1", "2", "3" });
            rentalDaysCbx.Location = new Point(33, 254);
            rentalDaysCbx.Name = "rentalDaysCbx";
            rentalDaysCbx.Size = new Size(159, 33);
            rentalDaysCbx.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 9F);
            label6.ForeColor = Color.FromArgb(255, 228, 186);
            label6.Location = new Point(33, 126);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 29;
            label6.Text = "Video Selected :";
            // 
            // titleTxt
            // 
            titleTxt.BorderStyle = BorderStyle.FixedSingle;
            titleTxt.Enabled = false;
            titleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxt.ForeColor = Color.Black;
            titleTxt.Location = new Point(33, 154);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(159, 34);
            titleTxt.TabIndex = 30;
            // 
            // RentalModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(rentalDaysCbx);
            Controls.Add(videoTypeCbx);
            Controls.Add(VideoView);
            Controls.Add(rentBtn);
            Controls.Add(titleTxt);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(searchTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RentalModule";
            Size = new Size(823, 664);
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
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private ComboBox rentalDaysCbx;
        private Label label6;
        private TextBox titleTxt;
    }
}
