namespace Bogys_Winforms.Windows.Admin
{
    partial class CustomerLibrary
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
            components = new System.ComponentModel.Container();
            usersBindingSource = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            birthDatePicker = new DateTimePicker();
            registerBtn = new Button();
            lastnameTxt = new TextBox();
            addressTxt = new TextBox();
            firstnameTxt = new TextBox();
            usernameTxt = new TextBox();
            label3 = new Label();
            CustomerView = new DataGridView();
            emailTxt = new TextBox();
            phoneTxt = new TextBox();
            searchTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerView).BeginInit();
            SuspendLayout();
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(79, 94);
            label2.Name = "label2";
            label2.Size = new Size(222, 25);
            label2.TabIndex = 1;
            label2.Text = "Select the customer to edit.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 228, 186);
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 2;
            label1.Text = "Edit Customer";
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(1228, 719);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(350, 31);
            birthDatePicker.TabIndex = 14;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(225, 107, 87);
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.FromArgb(255, 228, 186);
            registerBtn.Location = new Point(651, 887);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(357, 49);
            registerBtn.TabIndex = 13;
            registerBtn.Text = "Edit";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += editBtn_Click;
            // 
            // lastnameTxt
            // 
            lastnameTxt.BorderStyle = BorderStyle.FixedSingle;
            lastnameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnameTxt.ForeColor = Color.Black;
            lastnameTxt.Location = new Point(824, 716);
            lastnameTxt.Name = "lastnameTxt";
            lastnameTxt.PlaceholderText = "Last Name";
            lastnameTxt.Size = new Size(240, 34);
            lastnameTxt.TabIndex = 9;
            // 
            // addressTxt
            // 
            addressTxt.BorderStyle = BorderStyle.FixedSingle;
            addressTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTxt.ForeColor = Color.Black;
            addressTxt.Location = new Point(558, 801);
            addressTxt.Name = "addressTxt";
            addressTxt.PlaceholderText = "Address";
            addressTxt.Size = new Size(506, 34);
            addressTxt.TabIndex = 10;
            // 
            // firstnameTxt
            // 
            firstnameTxt.BorderStyle = BorderStyle.FixedSingle;
            firstnameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnameTxt.ForeColor = Color.Black;
            firstnameTxt.Location = new Point(558, 716);
            firstnameTxt.Name = "firstnameTxt";
            firstnameTxt.PlaceholderText = "First Name";
            firstnameTxt.Size = new Size(240, 34);
            firstnameTxt.TabIndex = 11;
            // 
            // usernameTxt
            // 
            usernameTxt.BorderStyle = BorderStyle.FixedSingle;
            usernameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.ForeColor = Color.Black;
            usernameTxt.Location = new Point(79, 716);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "Username";
            usernameTxt.Size = new Size(357, 34);
            usernameTxt.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(1125, 725);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 5;
            label3.Text = "Birthdate : ";
            // 
            // CustomerView
            // 
            CustomerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerView.Location = new Point(79, 229);
            CustomerView.MultiSelect = false;
            CustomerView.Name = "CustomerView";
            CustomerView.ReadOnly = true;
            CustomerView.RowHeadersWidth = 62;
            CustomerView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerView.Size = new Size(1499, 435);
            CustomerView.TabIndex = 15;
            CustomerView.CellClick += CustomerView_CellClick;
            // 
            // emailTxt
            // 
            emailTxt.BorderStyle = BorderStyle.FixedSingle;
            emailTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = Color.Black;
            emailTxt.Location = new Point(79, 801);
            emailTxt.Name = "emailTxt";
            emailTxt.PlaceholderText = "Email";
            emailTxt.Size = new Size(357, 34);
            emailTxt.TabIndex = 10;
            // 
            // phoneTxt
            // 
            phoneTxt.BorderStyle = BorderStyle.FixedSingle;
            phoneTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneTxt.ForeColor = Color.Black;
            phoneTxt.Location = new Point(1125, 801);
            phoneTxt.MaxLength = 11;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.PlaceholderText = "Phone #";
            phoneTxt.Size = new Size(453, 34);
            phoneTxt.TabIndex = 10;
            // 
            // searchTxt
            // 
            searchTxt.BorderStyle = BorderStyle.FixedSingle;
            searchTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.ForeColor = Color.Black;
            searchTxt.Location = new Point(79, 170);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "Search by Username, First Name, and Last Name";
            searchTxt.Size = new Size(529, 34);
            searchTxt.TabIndex = 38;
            searchTxt.TextChanged += searchuserTxt_TextChanged;
            // 
            // CustomerLibrary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(searchTxt);
            Controls.Add(CustomerView);
            Controls.Add(birthDatePicker);
            Controls.Add(registerBtn);
            Controls.Add(lastnameTxt);
            Controls.Add(phoneTxt);
            Controls.Add(emailTxt);
            Controls.Add(addressTxt);
            Controls.Add(firstnameTxt);
            Controls.Add(usernameTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerLibrary";
            Size = new Size(1663, 1024);
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource usersBindingSource;
        private Label label2;
        private Label label1;
        private DateTimePicker birthDatePicker;
        private Button registerBtn;
        private TextBox lastnameTxt;
        private TextBox addressTxt;
        private TextBox firstnameTxt;
        private TextBox usernameTxt;
        private Label label3;
        private DataGridView CustomerView;
        private TextBox emailTxt;
        private TextBox phoneTxt;
        private TextBox searchTxt;
    }
}
