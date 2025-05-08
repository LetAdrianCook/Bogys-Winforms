namespace Bogys_Winforms.Windows.Admin
{
    partial class VideoLibrary
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
            components = new System.ComponentModel.Container();
            VideoView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            videoBindingSource = new BindingSource(components);
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            titleTxt = new TextBox();
            stockTxt = new TextBox();
            addBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            label6 = new Label();
            rentDaysCbx = new ComboBox();
            videoTypeCbx = new ComboBox();
            searchTitleTxt = new TextBox();
            categoryFilterCbx = new ComboBox();
            label7 = new Label();
            reportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)VideoView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // VideoView
            // 
            VideoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VideoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoView.Location = new Point(79, 229);
            VideoView.MultiSelect = false;
            VideoView.Name = "VideoView";
            VideoView.RowHeadersWidth = 62;
            VideoView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VideoView.Size = new Size(1499, 435);
            VideoView.TabIndex = 25;
            VideoView.CellClick += VideoView_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(79, 94);
            label2.Name = "label2";
            label2.Size = new Size(289, 25);
            label2.TabIndex = 16;
            label2.Text = "Add, Edit, Delete, and Report Videos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 228, 186);
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 17;
            label1.Text = "Video Library";
            // 
            // videoBindingSource
            // 
            videoBindingSource.DataSource = typeof(Models.Video);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(73, 844);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 18;
            label3.Text = "Category :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F);
            label5.ForeColor = Color.FromArgb(255, 228, 186);
            label5.Location = new Point(73, 753);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 18;
            label5.Text = "Title :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.FromArgb(255, 228, 186);
            label4.Location = new Point(550, 753);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 18;
            label4.Text = "Video in :";
            // 
            // titleTxt
            // 
            titleTxt.BorderStyle = BorderStyle.FixedSingle;
            titleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxt.ForeColor = Color.Black;
            titleTxt.Location = new Point(173, 753);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(257, 34);
            titleTxt.TabIndex = 22;
            // 
            // stockTxt
            // 
            stockTxt.BorderStyle = BorderStyle.FixedSingle;
            stockTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockTxt.ForeColor = Color.Black;
            stockTxt.Location = new Point(650, 748);
            stockTxt.Name = "stockTxt";
            stockTxt.Size = new Size(257, 34);
            stockTxt.TabIndex = 22;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(225, 107, 87);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.FromArgb(255, 228, 186);
            addBtn.Location = new Point(981, 738);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(278, 49);
            addBtn.TabIndex = 23;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(193, 68, 46);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.FromArgb(255, 228, 186);
            deleteBtn.Location = new Point(981, 827);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(278, 49);
            deleteBtn.TabIndex = 23;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(58, 110, 165);
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBtn.ForeColor = Color.FromArgb(255, 228, 186);
            editBtn.Location = new Point(1300, 738);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(278, 49);
            editBtn.TabIndex = 23;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 9F);
            label6.ForeColor = Color.FromArgb(255, 228, 186);
            label6.Location = new Point(550, 840);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 18;
            label6.Text = "Rent Days :";
            // 
            // rentDaysCbx
            // 
            rentDaysCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            rentDaysCbx.FormattingEnabled = true;
            rentDaysCbx.Items.AddRange(new object[] { "1", "2", "3" });
            rentDaysCbx.Location = new Point(650, 837);
            rentDaysCbx.Name = "rentDaysCbx";
            rentDaysCbx.Size = new Size(257, 33);
            rentDaysCbx.TabIndex = 26;
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "DVD", "VCD" });
            videoTypeCbx.Location = new Point(173, 836);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(257, 33);
            videoTypeCbx.TabIndex = 26;
            // 
            // searchTitleTxt
            // 
            searchTitleTxt.BorderStyle = BorderStyle.FixedSingle;
            searchTitleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTitleTxt.ForeColor = Color.Black;
            searchTitleTxt.Location = new Point(79, 170);
            searchTitleTxt.Name = "searchTitleTxt";
            searchTitleTxt.PlaceholderText = "Search by Title";
            searchTitleTxt.Size = new Size(301, 34);
            searchTitleTxt.TabIndex = 39;
            searchTitleTxt.TextChanged += searchTitleTxt_TextChanged;
            // 
            // categoryFilterCbx
            // 
            categoryFilterCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryFilterCbx.FormattingEnabled = true;
            categoryFilterCbx.Items.AddRange(new object[] { "ALL", "DVD", "VCD" });
            categoryFilterCbx.Location = new Point(522, 170);
            categoryFilterCbx.Name = "categoryFilterCbx";
            categoryFilterCbx.Size = new Size(233, 33);
            categoryFilterCbx.TabIndex = 41;
            categoryFilterCbx.SelectedIndexChanged += categoryFilterCbx_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 9F);
            label7.ForeColor = Color.FromArgb(255, 228, 186);
            label7.Location = new Point(411, 170);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 40;
            label7.Text = "Video Type :";
            // 
            // reportBtn
            // 
            reportBtn.BackColor = Color.FromArgb(58, 158, 90);
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportBtn.ForeColor = Color.FromArgb(255, 228, 186);
            reportBtn.Location = new Point(1300, 828);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(278, 49);
            reportBtn.TabIndex = 23;
            reportBtn.Text = "Report";
            reportBtn.UseVisualStyleBackColor = false;
            reportBtn.Click += reportBtn_Click;
            // 
            // VideoLibrary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(categoryFilterCbx);
            Controls.Add(label7);
            Controls.Add(searchTitleTxt);
            Controls.Add(videoTypeCbx);
            Controls.Add(rentDaysCbx);
            Controls.Add(VideoView);
            Controls.Add(reportBtn);
            Controls.Add(editBtn);
            Controls.Add(label2);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(stockTxt);
            Controls.Add(label6);
            Controls.Add(titleTxt);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "VideoLibrary";
            Size = new Size(1663, 1024);
            ((System.ComponentModel.ISupportInitialize)VideoView).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView VideoView;
        private Label label2;
        private Label label1;
        private BindingSource videoBindingSource;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox titleTxt;
        private TextBox stockTxt;
        private Button addBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Label label6;
        private ComboBox rentDaysCbx;
        private ComboBox videoTypeCbx;
        private TextBox searchTitleTxt;
        private ComboBox categoryFilterCbx;
        private Label label7;
        private Button reportBtn;
    }
}
