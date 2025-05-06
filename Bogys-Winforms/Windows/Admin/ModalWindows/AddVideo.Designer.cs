namespace Bogys_Winforms.Windows.Admin.ModalWindows
{
    partial class AddVideo
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
            videoTypeCbx = new ComboBox();
            addBtn = new Button();
            stockTxt = new TextBox();
            titleTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "DVD", "VCD" });
            videoTypeCbx.Location = new Point(498, 37);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(250, 33);
            videoTypeCbx.TabIndex = 32;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(225, 107, 87);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.FromArgb(255, 228, 186);
            addBtn.Location = new Point(267, 150);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(225, 40);
            addBtn.TabIndex = 31;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // stockTxt
            // 
            stockTxt.BorderStyle = BorderStyle.FixedSingle;
            stockTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockTxt.ForeColor = Color.Black;
            stockTxt.Location = new Point(124, 93);
            stockTxt.Name = "stockTxt";
            stockTxt.Size = new Size(257, 34);
            stockTxt.TabIndex = 29;
            // 
            // titleTxt
            // 
            titleTxt.BorderStyle = BorderStyle.FixedSingle;
            titleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxt.ForeColor = Color.Black;
            titleTxt.Location = new Point(124, 35);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(257, 34);
            titleTxt.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 98);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 27;
            label4.Text = "Video in :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(387, 42);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 28;
            label3.Text = "Video Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 51;
            label2.Text = "Input the following details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 52;
            label1.Text = "Add Video Window";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(13, 42);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 28;
            label5.Text = "Video Type :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(videoTypeCbx);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(stockTxt);
            panel1.Controls.Add(titleTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(20, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 213);
            panel1.TabIndex = 53;
            // 
            // AddVideo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 341);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddVideo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddVideo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox videoTypeCbx;
        private Button addBtn;
        private TextBox stockTxt;
        private TextBox titleTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Panel panel1;
    }
}