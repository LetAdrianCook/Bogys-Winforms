namespace Bogys_Winforms
{
    partial class Register
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
            LoginLink = new LinkLabel();
            birthDatePicker = new DateTimePicker();
            registerBtn = new Button();
            confirmpassTxt = new TextBox();
            passwordTxt = new TextBox();
            lastnameTxt = new TextBox();
            addressTxt = new TextBox();
            firstnameTxt = new TextBox();
            usernameTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            emailTxt = new TextBox();
            phoneTxt = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 68, 92);
            panel1.Controls.Add(LoginLink);
            panel1.Controls.Add(birthDatePicker);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(confirmpassTxt);
            panel1.Controls.Add(phoneTxt);
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(lastnameTxt);
            panel1.Controls.Add(addressTxt);
            panel1.Controls.Add(firstnameTxt);
            panel1.Controls.Add(usernameTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 454);
            panel1.TabIndex = 2;
            // 
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLink.LinkColor = Color.FromArgb(192, 192, 255);
            LoginLink.Location = new Point(533, 359);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(54, 25);
            LoginLink.TabIndex = 4;
            LoginLink.TabStop = true;
            LoginLink.Text = "Login";
            LoginLink.LinkClicked += LoginLink_LinkClicked;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(333, 267);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(350, 31);
            birthDatePicker.TabIndex = 3;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(225, 107, 87);
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.FromArgb(255, 228, 186);
            registerBtn.Location = new Point(63, 347);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(245, 49);
            registerBtn.TabIndex = 2;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // confirmpassTxt
            // 
            confirmpassTxt.BorderStyle = BorderStyle.FixedSingle;
            confirmpassTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmpassTxt.ForeColor = Color.Black;
            confirmpassTxt.Location = new Point(63, 264);
            confirmpassTxt.Name = "confirmpassTxt";
            confirmpassTxt.PlaceholderText = " Confirm Password";
            confirmpassTxt.Size = new Size(245, 34);
            confirmpassTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            passwordTxt.BorderStyle = BorderStyle.FixedSingle;
            passwordTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.ForeColor = Color.Black;
            passwordTxt.Location = new Point(63, 199);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(245, 34);
            passwordTxt.TabIndex = 1;
            // 
            // lastnameTxt
            // 
            lastnameTxt.BorderStyle = BorderStyle.FixedSingle;
            lastnameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnameTxt.ForeColor = Color.Black;
            lastnameTxt.Location = new Point(519, 132);
            lastnameTxt.Name = "lastnameTxt";
            lastnameTxt.PlaceholderText = "Last Name";
            lastnameTxt.Size = new Size(164, 34);
            lastnameTxt.TabIndex = 1;
            // 
            // addressTxt
            // 
            addressTxt.BorderStyle = BorderStyle.FixedSingle;
            addressTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTxt.ForeColor = Color.Black;
            addressTxt.Location = new Point(333, 199);
            addressTxt.Name = "addressTxt";
            addressTxt.PlaceholderText = "Address";
            addressTxt.Size = new Size(350, 34);
            addressTxt.TabIndex = 1;
            // 
            // firstnameTxt
            // 
            firstnameTxt.BorderStyle = BorderStyle.FixedSingle;
            firstnameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnameTxt.ForeColor = Color.Black;
            firstnameTxt.Location = new Point(333, 132);
            firstnameTxt.Name = "firstnameTxt";
            firstnameTxt.PlaceholderText = "First Name";
            firstnameTxt.Size = new Size(164, 34);
            firstnameTxt.TabIndex = 1;
            // 
            // usernameTxt
            // 
            usernameTxt.BorderStyle = BorderStyle.FixedSingle;
            usernameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.ForeColor = Color.Black;
            usernameTxt.Location = new Point(63, 132);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "Username";
            usernameTxt.Size = new Size(245, 34);
            usernameTxt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(333, 239);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 0;
            label3.Text = "Birthdate : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.FromArgb(255, 228, 186);
            label4.Location = new Point(333, 359);
            label4.Name = "label4";
            label4.Size = new Size(208, 25);
            label4.TabIndex = 0;
            label4.Text = "Already have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(63, 64);
            label2.Name = "label2";
            label2.Size = new Size(383, 25);
            label2.TabIndex = 0;
            label2.Text = "Fill up the required fields to create your account.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 228, 186);
            label1.Location = new Point(63, 32);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // emailTxt
            // 
            emailTxt.BorderStyle = BorderStyle.FixedSingle;
            emailTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = Color.Black;
            emailTxt.Location = new Point(707, 132);
            emailTxt.Name = "emailTxt";
            emailTxt.PlaceholderText = "Email";
            emailTxt.Size = new Size(245, 34);
            emailTxt.TabIndex = 1;
            // 
            // phoneTxt
            // 
            phoneTxt.BorderStyle = BorderStyle.FixedSingle;
            phoneTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneTxt.ForeColor = Color.Black;
            phoneTxt.Location = new Point(707, 199);
            phoneTxt.MaxLength = 11;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.PlaceholderText = "Phone #";
            phoneTxt.Size = new Size(245, 34);
            phoneTxt.TabIndex = 1;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 52, 70);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1154, 534);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private LinkLabel LoginLink;
        private DateTimePicker birthDatePicker;
        private Button registerBtn;
        private TextBox confirmpassTxt;
        private TextBox passwordTxt;
        private TextBox lastnameTxt;
        private TextBox addressTxt;
        private TextBox firstnameTxt;
        private TextBox usernameTxt;
        private Label label3;
        private Label label4;
        private TextBox phoneTxt;
        private TextBox emailTxt;
    }
}