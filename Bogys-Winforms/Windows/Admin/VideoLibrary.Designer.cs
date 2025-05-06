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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)VideoView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // VideoView
            // 
            VideoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VideoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoView.Location = new Point(79, 141);
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
            label2.Size = new Size(195, 25);
            label2.TabIndex = 16;
            label2.Text = "Add, Edit, Delete Videos";
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
            label3.Location = new Point(79, 715);
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
            label5.Location = new Point(79, 635);
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
            label4.Location = new Point(79, 782);
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
            titleTxt.Location = new Point(179, 635);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(257, 34);
            titleTxt.TabIndex = 22;
            // 
            // stockTxt
            // 
            stockTxt.BorderStyle = BorderStyle.FixedSingle;
            stockTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockTxt.ForeColor = Color.Black;
            stockTxt.Location = new Point(179, 777);
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
            addBtn.Location = new Point(570, 635);
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
            deleteBtn.Location = new Point(570, 839);
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
            editBtn.Location = new Point(570, 737);
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
            label6.Location = new Point(79, 858);
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
            rentDaysCbx.Location = new Point(179, 855);
            rentDaysCbx.Name = "rentDaysCbx";
            rentDaysCbx.Size = new Size(257, 33);
            rentDaysCbx.TabIndex = 26;
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "DVD", "VCD" });
            videoTypeCbx.Location = new Point(179, 707);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(257, 33);
            videoTypeCbx.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 9F);
            label7.ForeColor = Color.FromArgb(255, 228, 186);
            label7.Location = new Point(1034, 671);
            label7.Name = "label7";
            label7.Size = new Size(531, 25);
            label7.TabIndex = 27;
            label7.Text = "1. Before Editing a Video. Make sure to select a TITLE from the table.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 228, 186);
            label8.Location = new Point(1034, 628);
            label8.Name = "label8";
            label8.Size = new Size(95, 32);
            label8.TabIndex = 28;
            label8.Text = "Guide :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 9F);
            label9.ForeColor = Color.FromArgb(255, 228, 186);
            label9.Location = new Point(1034, 715);
            label9.Name = "label9";
            label9.Size = new Size(544, 25);
            label9.TabIndex = 27;
            label9.Text = "2. Before Deleting a Video. Make sure to select a TITLE from the table.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 9F);
            label10.ForeColor = Color.FromArgb(255, 228, 186);
            label10.Location = new Point(1034, 761);
            label10.Name = "label10";
            label10.Size = new Size(430, 25);
            label10.TabIndex = 27;
            label10.Text = "3. Adding Video Title that already exists is not possible.";
            // 
            // VideoLibrary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(videoTypeCbx);
            Controls.Add(rentDaysCbx);
            Controls.Add(VideoView);
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
