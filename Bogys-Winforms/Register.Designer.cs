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
            registerBtn = new Button();
            passwordTxt = new TextBox();
            usernameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 68, 92);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(usernameTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 454);
            panel1.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(19, 55);
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
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(333, 132);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First Name";
            textBox1.Size = new Size(164, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(519, 132);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Last Name";
            textBox2.Size = new Size(164, 34);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(333, 199);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Address";
            textBox3.Size = new Size(350, 34);
            textBox3.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(333, 267);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 31);
            dateTimePicker1.TabIndex = 3;
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
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(63, 264);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = " Confirm Password";
            textBox4.Size = new Size(245, 34);
            textBox4.TabIndex = 1;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(192, 192, 255);
            linkLabel1.Location = new Point(533, 359);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 52, 70);
            BackgroundImage = Properties.Resources.registerpanel;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 534);
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
        private Button registerBtn;
        private TextBox passwordTxt;
        private TextBox usernameTxt;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}