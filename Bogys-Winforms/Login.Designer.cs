namespace Bogys_Winforms
{
    partial class loginBtn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            button1 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            cpasswordTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 33);
            label1.Name = "label1";
            label1.Size = new Size(349, 45);
            label1.TabIndex = 0;
            label1.Text = "Login to your account";
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = Color.FromArgb(60, 54, 76);
            usernameTxt.BorderStyle = BorderStyle.FixedSingle;
            usernameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.ForeColor = Color.White;
            usernameTxt.Location = new Point(439, 155);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "Username";
            usernameTxt.Size = new Size(319, 34);
            usernameTxt.TabIndex = 1;
            usernameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.FromArgb(60, 54, 76);
            passwordTxt.BorderStyle = BorderStyle.FixedSingle;
            passwordTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.ForeColor = Color.White;
            passwordTxt.Location = new Point(439, 222);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(319, 34);
            passwordTxt.TabIndex = 1;
            passwordTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(109, 84, 181);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(439, 348);
            button1.Name = "button1";
            button1.Size = new Size(319, 50);
            button1.TabIndex = 2;
            button1.Text = "Login your account";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 92);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 0;
            label2.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(168, 160, 192);
            linkLabel1.Location = new Point(623, 92);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(72, 25);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.LoginPanelImage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 426);
            panel1.TabIndex = 4;
            // 
            // cpasswordTxt
            // 
            cpasswordTxt.BackColor = Color.FromArgb(60, 54, 76);
            cpasswordTxt.BorderStyle = BorderStyle.FixedSingle;
            cpasswordTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpasswordTxt.ForeColor = Color.White;
            cpasswordTxt.Location = new Point(439, 285);
            cpasswordTxt.Name = "cpasswordTxt";
            cpasswordTxt.PlaceholderText = "Confirm Password";
            cpasswordTxt.Size = new Size(319, 34);
            cpasswordTxt.TabIndex = 1;
            cpasswordTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // loginBtn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 38, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(cpasswordTxt);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "loginBtn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Button button1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private TextBox cpasswordTxt;
    }
}
