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
            CustomerView = new DataGridView();
            registerBtn = new Button();
            usernameTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomerView).BeginInit();
            SuspendLayout();
            // 
            // CustomerView
            // 
            CustomerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerView.Location = new Point(33, 111);
            CustomerView.Name = "CustomerView";
            CustomerView.RowHeadersWidth = 62;
            CustomerView.Size = new Size(757, 294);
            CustomerView.TabIndex = 25;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(225, 107, 87);
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.FromArgb(255, 228, 186);
            registerBtn.Location = new Point(33, 496);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(357, 49);
            registerBtn.TabIndex = 23;
            registerBtn.Text = "Add";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // usernameTxt
            // 
            usernameTxt.BorderStyle = BorderStyle.FixedSingle;
            usernameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.ForeColor = Color.Black;
            usernameTxt.Location = new Point(33, 440);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "Video Title";
            usernameTxt.Size = new Size(357, 34);
            usernameTxt.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(422, 445);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 18;
            label3.Text = "Video Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(33, 64);
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
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 17;
            label1.Text = "Video Library";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DVD", "VCD" });
            comboBox1.Location = new Point(533, 440);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 33);
            comboBox1.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(225, 107, 87);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 228, 186);
            button1.Location = new Point(33, 577);
            button1.Name = "button1";
            button1.Size = new Size(357, 49);
            button1.TabIndex = 23;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(225, 107, 87);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 228, 186);
            button2.Location = new Point(433, 496);
            button2.Name = "button2";
            button2.Size = new Size(357, 49);
            button2.TabIndex = 23;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // VideoLibrary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(comboBox1);
            Controls.Add(CustomerView);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(registerBtn);
            Controls.Add(usernameTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VideoLibrary";
            Size = new Size(823, 664);
            ((System.ComponentModel.ISupportInitialize)CustomerView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CustomerView;
        private Button registerBtn;
        private TextBox usernameTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}
