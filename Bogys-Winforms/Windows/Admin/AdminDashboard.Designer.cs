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
            button6 = new Button();
            reportBtn = new Button();
            listBtn = new Button();
            rentalBtn = new Button();
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
            panel2.Controls.Add(button6);
            panel2.Controls.Add(reportBtn);
            panel2.Controls.Add(listBtn);
            panel2.Controls.Add(rentalBtn);
            panel2.Controls.Add(videoBtn);
            panel2.Controls.Add(customerBtn);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 664);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semilight", 10F);
            button6.ForeColor = Color.FromArgb(255, 228, 186);
            button6.Location = new Point(0, 609);
            button6.Name = "button6";
            button6.Padding = new Padding(5, 0, 0, 0);
            button6.Size = new Size(235, 55);
            button6.TabIndex = 6;
            button6.Text = "Logout";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // reportBtn
            // 
            reportBtn.Dock = DockStyle.Top;
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.Font = new Font("Segoe UI Semilight", 10F);
            reportBtn.ForeColor = Color.FromArgb(255, 228, 186);
            reportBtn.Location = new Point(0, 312);
            reportBtn.Name = "reportBtn";
            reportBtn.Padding = new Padding(5, 0, 0, 0);
            reportBtn.Size = new Size(235, 51);
            reportBtn.TabIndex = 5;
            reportBtn.Text = "Rental Report";
            reportBtn.TextAlign = ContentAlignment.MiddleLeft;
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // listBtn
            // 
            listBtn.Dock = DockStyle.Top;
            listBtn.FlatAppearance.BorderSize = 0;
            listBtn.FlatStyle = FlatStyle.Flat;
            listBtn.Font = new Font("Segoe UI Semilight", 10F);
            listBtn.ForeColor = Color.FromArgb(255, 228, 186);
            listBtn.Location = new Point(0, 261);
            listBtn.Name = "listBtn";
            listBtn.Padding = new Padding(5, 0, 0, 0);
            listBtn.Size = new Size(235, 51);
            listBtn.TabIndex = 4;
            listBtn.Text = "Video List";
            listBtn.TextAlign = ContentAlignment.MiddleLeft;
            listBtn.UseVisualStyleBackColor = true;
            listBtn.Click += listBtn_Click;
            // 
            // rentalBtn
            // 
            rentalBtn.Dock = DockStyle.Top;
            rentalBtn.FlatAppearance.BorderSize = 0;
            rentalBtn.FlatStyle = FlatStyle.Flat;
            rentalBtn.Font = new Font("Segoe UI Semilight", 10F);
            rentalBtn.ForeColor = Color.FromArgb(255, 228, 186);
            rentalBtn.Location = new Point(0, 210);
            rentalBtn.Name = "rentalBtn";
            rentalBtn.Padding = new Padding(5, 0, 0, 0);
            rentalBtn.Size = new Size(235, 51);
            rentalBtn.TabIndex = 3;
            rentalBtn.Text = "Rental Module";
            rentalBtn.TextAlign = ContentAlignment.MiddleLeft;
            rentalBtn.UseVisualStyleBackColor = true;
            rentalBtn.Click += rentalBtn_Click;
            // 
            // videoBtn
            // 
            videoBtn.Dock = DockStyle.Top;
            videoBtn.FlatAppearance.BorderSize = 0;
            videoBtn.FlatStyle = FlatStyle.Flat;
            videoBtn.Font = new Font("Segoe UI Semilight", 10F);
            videoBtn.ForeColor = Color.FromArgb(255, 228, 186);
            videoBtn.Location = new Point(0, 159);
            videoBtn.Name = "videoBtn";
            videoBtn.Padding = new Padding(5, 0, 0, 0);
            videoBtn.Size = new Size(235, 51);
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
            customerBtn.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerBtn.ForeColor = Color.FromArgb(255, 228, 186);
            customerBtn.Location = new Point(0, 108);
            customerBtn.Name = "customerBtn";
            customerBtn.Padding = new Padding(5, 0, 0, 0);
            customerBtn.Size = new Size(235, 51);
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
            panel3.Size = new Size(235, 108);
            panel3.TabIndex = 0;
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = Color.FromArgb(80, 68, 92);
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Location = new Point(235, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(823, 664);
            dashboardPanel.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(dashboardPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button customerBtn;
        private Panel panel3;
        private Panel dashboardPanel;
        private Button reportBtn;
        private Button listBtn;
        private Button rentalBtn;
        private Button videoBtn;
        private Button button6;
    }
}