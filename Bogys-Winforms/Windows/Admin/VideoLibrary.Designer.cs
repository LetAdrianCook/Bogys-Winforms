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
            addBtn = new Button();
            titleTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            videoTypeCbx = new ComboBox();
            deleteBtn = new Button();
            editBtn = new Button();
            videoBindingSource = new BindingSource(components);
            stockTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)VideoView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // VideoView
            // 
            VideoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoView.Location = new Point(34, 92);
            VideoView.MultiSelect = false;
            VideoView.Name = "VideoView";
            VideoView.RowHeadersWidth = 62;
            VideoView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VideoView.Size = new Size(757, 294);
            VideoView.TabIndex = 25;
            VideoView.CellClick += VideoView_CellClick;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(225, 107, 87);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.FromArgb(255, 228, 186);
            addBtn.Location = new Point(441, 26);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(278, 49);
            addBtn.TabIndex = 23;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // titleTxt
            // 
            titleTxt.BorderStyle = BorderStyle.FixedSingle;
            titleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxt.ForeColor = Color.Black;
            titleTxt.Location = new Point(126, 26);
            titleTxt.Name = "titleTxt";
            titleTxt.PlaceholderText = "Video Title";
            titleTxt.Size = new Size(257, 34);
            titleTxt.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(26, 106);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 18;
            label3.Text = "Category :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(34, 45);
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
            label1.Location = new Point(34, 13);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 17;
            label1.Text = "Video Library";
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "DVD", "VCD" });
            videoTypeCbx.Location = new Point(126, 103);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(257, 33);
            videoTypeCbx.TabIndex = 26;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(193, 68, 46);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.FromArgb(255, 228, 186);
            deleteBtn.Location = new Point(441, 162);
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
            editBtn.Location = new Point(441, 94);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(278, 49);
            editBtn.TabIndex = 23;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // videoBindingSource
            // 
            videoBindingSource.DataSource = typeof(Models.Video);
            // 
            // stockTxt
            // 
            stockTxt.BorderStyle = BorderStyle.FixedSingle;
            stockTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockTxt.ForeColor = Color.Black;
            stockTxt.Location = new Point(126, 177);
            stockTxt.Name = "stockTxt";
            stockTxt.Size = new Size(257, 34);
            stockTxt.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.FromArgb(255, 228, 186);
            label4.Location = new Point(26, 182);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 18;
            label4.Text = "Video in :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F);
            label5.ForeColor = Color.FromArgb(255, 228, 186);
            label5.Location = new Point(26, 26);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 18;
            label5.Text = "Title :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(90, 80, 103);
            panel1.Controls.Add(videoTypeCbx);
            panel1.Controls.Add(editBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(stockTxt);
            panel1.Controls.Add(titleTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(33, 405);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 239);
            panel1.TabIndex = 27;
            // 
            // VideoLibrary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(panel1);
            Controls.Add(VideoView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VideoLibrary";
            Size = new Size(823, 664);
            ((System.ComponentModel.ISupportInitialize)VideoView).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView VideoView;
        private Button addBtn;
        private TextBox titleTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox videoTypeCbx;
        private Button deleteBtn;
        private Button editBtn;
        private BindingSource videoBindingSource;
        private TextBox stockTxt;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}
