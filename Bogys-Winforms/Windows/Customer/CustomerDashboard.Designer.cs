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
            button6 = new Button();
            rentalBtn = new Button();
            panel3 = new Panel();
            dashboardPanel = new Panel();
            userIdTxt = new Label();
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
            panel2.Controls.Add(userIdTxt);
            panel2.Controls.Add(returnBtn);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(rentalBtn);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 664);
            panel2.TabIndex = 1;
            // 
            // returnBtn
            // 
            returnBtn.Dock = DockStyle.Top;
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnBtn.ForeColor = Color.FromArgb(255, 228, 186);
            returnBtn.Location = new Point(0, 159);
            returnBtn.Name = "returnBtn";
            returnBtn.Padding = new Padding(5, 0, 0, 0);
            returnBtn.Size = new Size(235, 51);
            returnBtn.TabIndex = 7;
            returnBtn.Text = "Return Module";
            returnBtn.TextAlign = ContentAlignment.MiddleLeft;
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
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
            // rentalBtn
            // 
            rentalBtn.Dock = DockStyle.Top;
            rentalBtn.FlatAppearance.BorderSize = 0;
            rentalBtn.FlatStyle = FlatStyle.Flat;
            rentalBtn.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentalBtn.ForeColor = Color.FromArgb(255, 228, 186);
            rentalBtn.Location = new Point(0, 108);
            rentalBtn.Name = "rentalBtn";
            rentalBtn.Padding = new Padding(5, 0, 0, 0);
            rentalBtn.Size = new Size(235, 51);
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
            // userIdTxt
            // 
            userIdTxt.AutoSize = true;
            userIdTxt.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            userIdTxt.ForeColor = Color.FromArgb(255, 228, 186);
            userIdTxt.Location = new Point(54, 260);
            userIdTxt.Name = "userIdTxt";
            userIdTxt.Size = new Size(133, 25);
            userIdTxt.TabIndex = 0;
            userIdTxt.Text = "User : John Doe";
            userIdTxt.TextAlign = ContentAlignment.TopRight;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(dashboardPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerDashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button rentalBtn;
        private Panel panel3;
        private Panel dashboardPanel;
        private Button button6;
        private Label userIdTxt;
        private Button returnBtn;
    }
}