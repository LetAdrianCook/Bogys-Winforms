namespace Bogys_Winforms
{
    partial class Login
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
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            loginBtn = new Button();
            passwordTxt = new TextBox();
            usernameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 68, 92);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(usernameTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(394, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 454);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(192, 192, 255);
            linkLabel1.Location = new Point(245, 347);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(72, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += RegisterLink_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.FromArgb(255, 228, 186);
            label4.Location = new Point(60, 347);
            label4.Name = "label4";
            label4.Size = new Size(192, 25);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account?";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(225, 107, 87);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.FromArgb(255, 228, 186);
            loginBtn.Location = new Point(60, 266);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(245, 49);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.BorderStyle = BorderStyle.FixedSingle;
            passwordTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.ForeColor = Color.Black;
            passwordTxt.Location = new Point(60, 198);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(245, 34);
            passwordTxt.TabIndex = 2;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // usernameTxt
            // 
            usernameTxt.BorderStyle = BorderStyle.FixedSingle;
            usernameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.ForeColor = Color.Black;
            usernameTxt.Location = new Point(60, 127);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "Username";
            usernameTxt.Size = new Size(245, 34);
            usernameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(19, 55);
            label2.Name = "label2";
            label2.Size = new Size(286, 25);
            label2.TabIndex = 0;
            label2.Text = "Enter your username and password.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 228, 186);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.loginpanel;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 532);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(22, 17);
            label3.Name = "label3";
            label3.Size = new Size(216, 25);
            label3.TabIndex = 2;
            label3.Text = "Bogsy Video Rental Store™";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 53, 71);
            ClientSize = new Size(800, 534);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox passwordTxt;
        private TextBox usernameTxt;
        private Button loginBtn;
        private Panel panel2;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label3;
    }
}