namespace Bogys_Winforms.Windows
{
    partial class AdminDashboard
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Harry Potter" }, -1, Color.White, Color.FromArgb(44, 38, 56), null);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 38, 56);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 110);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 54, 76);
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(1058, 554);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Bogsy_Logo;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(46, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(91, 76);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(163, 29);
            button1.Name = "button1";
            button1.Size = new Size(228, 56);
            button1.TabIndex = 1;
            button1.Text = "Customer Library";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(397, 29);
            button2.Name = "button2";
            button2.Size = new Size(228, 56);
            button2.TabIndex = 1;
            button2.Text = "Video Library";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(631, 29);
            button3.Name = "button3";
            button3.Size = new Size(228, 56);
            button3.TabIndex = 1;
            button3.Text = "Rental Module";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(847, 29);
            button4.Name = "button4";
            button4.Size = new Size(228, 56);
            button4.TabIndex = 1;
            button4.Text = "Report";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(59, 53, 72);
            panel4.BackgroundImage = Properties.Resources.LoginPanelImage;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 554);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(449, 24);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 1;
            label1.Text = "New Movies Added!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(449, 56);
            label2.Name = "label2";
            label2.Size = new Size(507, 28);
            label2.TabIndex = 1;
            label2.Text = "Don't miss out and start renting the newly released movies!";
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(449, 106);
            listView1.Name = "listView1";
            listView1.Size = new Size(566, 199);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 456);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 1;
            label3.Text = "Created by :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(449, 488);
            label4.Name = "label4";
            label4.Size = new Size(393, 28);
            label4.TabIndex = 1;
            label4.Text = "Adrian G. Villasis, feel free to reach out to me ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(449, 516);
            label5.Name = "label5";
            label5.Size = new Size(325, 28);
            label5.TabIndex = 1;
            label5.Text = "email : adrianvillasis2252@gmail.com";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            StartPosition = FormStartPosition.Manual;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel4;
        private ListView listView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}