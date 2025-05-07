namespace Bogys_Winforms.Windows.Admin
{
    partial class CustomerDashboard
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
            returnBtn = new Button();
            logoutBtn = new Button();
            rentalBtn = new Button();
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
            panel2.Controls.Add(returnBtn);
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(rentalBtn);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 1024);
            panel2.TabIndex = 1;
            // 
            // returnBtn
            // 
            returnBtn.Dock = DockStyle.Top;
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("Segoe UI", 10F);
            returnBtn.ForeColor = Color.FromArgb(255, 228, 186);
            returnBtn.Location = new Point(0, 224);
            returnBtn.Name = "returnBtn";
            returnBtn.Padding = new Padding(5, 0, 0, 0);
            returnBtn.Size = new Size(235, 71);
            returnBtn.TabIndex = 7;
            returnBtn.Text = "Return Module";
            returnBtn.TextAlign = ContentAlignment.MiddleLeft;
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semilight", 10F);
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
            // rentalBtn
            // 
            rentalBtn.Dock = DockStyle.Top;
            rentalBtn.FlatAppearance.BorderSize = 0;
            rentalBtn.FlatStyle = FlatStyle.Flat;
            rentalBtn.Font = new Font("Segoe UI", 10F);
            rentalBtn.ForeColor = Color.FromArgb(255, 228, 186);
            rentalBtn.Location = new Point(0, 153);
            rentalBtn.Name = "rentalBtn";
            rentalBtn.Padding = new Padding(5, 0, 0, 0);
            rentalBtn.Size = new Size(235, 71);
            rentalBtn.TabIndex = 1;
            rentalBtn.Text = "Rental Module";
            rentalBtn.TextAlign = ContentAlignment.MiddleLeft;
            rentalBtn.UseVisualStyleBackColor = true;
            rentalBtn.Click += rentalBtn_Click;
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
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(dashboardPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerDashboard";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button rentalBtn;
        private Panel panel3;
        private Panel dashboardPanel;
        private Button logoutBtn;
        private Button returnBtn;
    }
}