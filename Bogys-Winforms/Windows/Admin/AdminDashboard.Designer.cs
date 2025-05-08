namespace Bogys_Winforms.Windows.Admin
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
            panel1 = new Panel();
            panel2 = new Panel();
            logoutBtn = new Button();
            listBtn = new Button();
            videoBtn = new Button();
            customerBtn = new Button();
            panel3 = new Panel();
            dashboardPanel = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(87, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 52, 70);
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(listBtn);
            panel2.Controls.Add(videoBtn);
            panel2.Controls.Add(customerBtn);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 1024);
            panel2.TabIndex = 1;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI", 10F);
            logoutBtn.ForeColor = Color.FromArgb(255, 228, 186);
            logoutBtn.Location = new Point(0, 953);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(5, 0, 0, 0);
            logoutBtn.Size = new Size(235, 71);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Logout";
            logoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // listBtn
            // 
            listBtn.Dock = DockStyle.Top;
            listBtn.FlatAppearance.BorderSize = 0;
            listBtn.FlatStyle = FlatStyle.Flat;
            listBtn.Font = new Font("Segoe UI", 10F);
            listBtn.ForeColor = Color.FromArgb(255, 228, 186);
            listBtn.Location = new Point(0, 289);
            listBtn.Name = "listBtn";
            listBtn.Padding = new Padding(5, 0, 0, 0);
            listBtn.Size = new Size(235, 71);
            listBtn.TabIndex = 4;
            listBtn.Text = "Rental List";
            listBtn.TextAlign = ContentAlignment.MiddleLeft;
            listBtn.UseVisualStyleBackColor = true;
            listBtn.Click += listBtn_Click;
            // 
            // videoBtn
            // 
            videoBtn.Dock = DockStyle.Top;
            videoBtn.FlatAppearance.BorderSize = 0;
            videoBtn.FlatStyle = FlatStyle.Flat;
            videoBtn.Font = new Font("Segoe UI", 10F);
            videoBtn.ForeColor = Color.FromArgb(255, 228, 186);
            videoBtn.Location = new Point(0, 224);
            videoBtn.Name = "videoBtn";
            videoBtn.Padding = new Padding(5, 0, 0, 0);
            videoBtn.Size = new Size(235, 65);
            videoBtn.TabIndex = 2;
            videoBtn.Text = "Video Library";
            videoBtn.TextAlign = ContentAlignment.MiddleLeft;
            videoBtn.UseVisualStyleBackColor = true;
            videoBtn.Click += videoBtn_Click;
            // 
            // customerBtn
            // 
            customerBtn.Dock = DockStyle.Top;
            customerBtn.FlatAppearance.BorderSize = 0;
            customerBtn.FlatStyle = FlatStyle.Flat;
            customerBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerBtn.ForeColor = Color.FromArgb(255, 228, 186);
            customerBtn.Location = new Point(0, 153);
            customerBtn.Name = "customerBtn";
            customerBtn.Padding = new Padding(5, 0, 0, 0);
            customerBtn.Size = new Size(235, 71);
            customerBtn.TabIndex = 1;
            customerBtn.Text = "Customer Library";
            customerBtn.TextAlign = ContentAlignment.MiddleLeft;
            customerBtn.UseVisualStyleBackColor = true;
            customerBtn.Click += customerBtn_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.loginpanel;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 153);
            panel3.TabIndex = 0;
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = Color.FromArgb(80, 68, 92);
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Location = new Point(235, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1663, 1024);
            dashboardPanel.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(dashboardPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button customerBtn;
        private Panel panel3;
        private Panel dashboardPanel;
        private Button listBtn;
        private Button videoBtn;
        private Button logoutBtn;
    }
}