namespace Bogys_Winforms.Windows.Customer
{
    partial class ReturnModule
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
            videoTypeCbx = new ComboBox();
            VideoRentedView = new DataGridView();
            returnBtn = new Button();
            titleTxt = new TextBox();
            feeTxt = new TextBox();
            totalTxt = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            searchTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)VideoRentedView).BeginInit();
            SuspendLayout();
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "DVD", "VCD" });
            videoTypeCbx.Location = new Point(638, 62);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(152, 33);
            videoTypeCbx.TabIndex = 61;
            // 
            // VideoRentedView
            // 
            VideoRentedView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoRentedView.Location = new Point(246, 116);
            VideoRentedView.MultiSelect = false;
            VideoRentedView.Name = "VideoRentedView";
            VideoRentedView.RowHeadersWidth = 62;
            VideoRentedView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VideoRentedView.Size = new Size(544, 512);
            VideoRentedView.TabIndex = 60;
            VideoRentedView.CellClick += VideoRentedView_CellClick;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(225, 107, 87);
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBtn.ForeColor = Color.FromArgb(255, 228, 186);
            returnBtn.Location = new Point(33, 416);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(178, 49);
            returnBtn.TabIndex = 59;
            returnBtn.Text = "Return";
            returnBtn.UseVisualStyleBackColor = false;
            // 
            // titleTxt
            // 
            titleTxt.BorderStyle = BorderStyle.FixedSingle;
            titleTxt.Enabled = false;
            titleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxt.ForeColor = Color.Black;
            titleTxt.Location = new Point(33, 157);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(159, 34);
            titleTxt.TabIndex = 55;
            // 
            // feeTxt
            // 
            feeTxt.BorderStyle = BorderStyle.FixedSingle;
            feeTxt.Enabled = false;
            feeTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feeTxt.ForeColor = Color.Black;
            feeTxt.Location = new Point(33, 239);
            feeTxt.Name = "feeTxt";
            feeTxt.Size = new Size(159, 34);
            feeTxt.TabIndex = 56;
            // 
            // totalTxt
            // 
            totalTxt.BorderStyle = BorderStyle.FixedSingle;
            totalTxt.Enabled = false;
            totalTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalTxt.ForeColor = Color.Black;
            totalTxt.Location = new Point(33, 322);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(159, 34);
            totalTxt.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.FromArgb(255, 228, 186);
            label4.Location = new Point(33, 211);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 52;
            label4.Text = "Overdue Fees :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 9F);
            label6.ForeColor = Color.FromArgb(255, 228, 186);
            label6.Location = new Point(33, 129);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 51;
            label6.Text = "Video Selected :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F);
            label5.ForeColor = Color.FromArgb(255, 228, 186);
            label5.Location = new Point(33, 294);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 53;
            label5.Text = "Total :";
            // 
            // searchTxt
            // 
            searchTxt.BorderStyle = BorderStyle.FixedSingle;
            searchTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.ForeColor = Color.Black;
            searchTxt.Location = new Point(246, 60);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "Search by Title";
            searchTxt.Size = new Size(280, 34);
            searchTxt.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(532, 65);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 54;
            label3.Text = "Video Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 49;
            label2.Text = "Return Rented Videos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 228, 186);
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 50;
            label1.Text = "Return Module";
            // 
            // ReturnModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(videoTypeCbx);
            Controls.Add(VideoRentedView);
            Controls.Add(returnBtn);
            Controls.Add(titleTxt);
            Controls.Add(feeTxt);
            Controls.Add(totalTxt);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(searchTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReturnModule";
            Size = new Size(823, 664);
            ((System.ComponentModel.ISupportInitialize)VideoRentedView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox videoTypeCbx;
        private DataGridView VideoRentedView;
        private Button returnBtn;
        private TextBox titleTxt;
        private TextBox feeTxt;
        private TextBox totalTxt;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox searchTxt;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
