﻿namespace Bogys_Winforms.Windows.Customer
{
    partial class ReturnModule
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
            videoTypeCbx = new ComboBox();
            VideoRentedView = new DataGridView();
            returnBtn = new Button();
            titleTxt = new TextBox();
            feeTxt = new TextBox();
            label4 = new Label();
            label6 = new Label();
            searchTitleTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            statusCbx = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)VideoRentedView).BeginInit();
            SuspendLayout();
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "ALL", "DVD", "VCD" });
            videoTypeCbx.Location = new Point(792, 148);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(152, 33);
            videoTypeCbx.TabIndex = 61;
            videoTypeCbx.SelectedIndexChanged += videoTypeCbx_SelectedIndexChanged;
            // 
            // VideoRentedView
            // 
            VideoRentedView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VideoRentedView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoRentedView.Location = new Point(340, 200);
            VideoRentedView.MultiSelect = false;
            VideoRentedView.Name = "VideoRentedView";
            VideoRentedView.ReadOnly = true;
            VideoRentedView.RowHeadersWidth = 62;
            VideoRentedView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VideoRentedView.Size = new Size(1225, 711);
            VideoRentedView.TabIndex = 60;
            VideoRentedView.CellClick += VideoRentedView_CellClick;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(225, 107, 87);
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBtn.ForeColor = Color.FromArgb(255, 228, 186);
            returnBtn.Location = new Point(79, 450);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(178, 49);
            returnBtn.TabIndex = 59;
            returnBtn.Text = "Return";
            returnBtn.UseVisualStyleBackColor = false;
            returnBtn.Click += returnBtn_Click;
            // 
            // titleTxt
            // 
            titleTxt.BorderStyle = BorderStyle.FixedSingle;
            titleTxt.Enabled = false;
            titleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxt.ForeColor = Color.Black;
            titleTxt.Location = new Point(79, 249);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(159, 34);
            titleTxt.TabIndex = 55;
            // 
            // feeTxt
            // 
            feeTxt.BorderStyle = BorderStyle.FixedSingle;
            feeTxt.Enabled = false;
            feeTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feeTxt.ForeColor = Color.Black;
            feeTxt.Location = new Point(79, 352);
            feeTxt.Name = "feeTxt";
            feeTxt.Size = new Size(159, 34);
            feeTxt.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F);
            label4.ForeColor = Color.FromArgb(255, 228, 186);
            label4.Location = new Point(79, 324);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 52;
            label4.Text = "Overdue Fees :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 9F);
            label6.ForeColor = Color.FromArgb(255, 228, 186);
            label6.Location = new Point(79, 221);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 51;
            label6.Text = "Video Selected :";
            // 
            // searchTitleTxt
            // 
            searchTitleTxt.BorderStyle = BorderStyle.FixedSingle;
            searchTitleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTitleTxt.ForeColor = Color.Black;
            searchTitleTxt.Location = new Point(340, 148);
            searchTitleTxt.Name = "searchTitleTxt";
            searchTitleTxt.PlaceholderText = "Search by Title";
            searchTitleTxt.Size = new Size(280, 34);
            searchTitleTxt.TabIndex = 58;
            searchTitleTxt.TextChanged += searchTitleTxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(686, 151);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 54;
            label3.Text = "Video Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(79, 94);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 49;
            label2.Text = "Return Rented Videos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 228, 186);
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 50;
            label1.Text = "Return Module";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F);
            label5.ForeColor = Color.FromArgb(255, 228, 186);
            label5.Location = new Point(1008, 151);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 54;
            label5.Text = "Status :";
            // 
            // statusCbx
            // 
            statusCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCbx.FormattingEnabled = true;
            statusCbx.Items.AddRange(new object[] { "ALL", "ACTIVE", "OVERDUE" });
            statusCbx.Location = new Point(1081, 148);
            statusCbx.Name = "statusCbx";
            statusCbx.Size = new Size(152, 33);
            statusCbx.TabIndex = 61;
            statusCbx.SelectedIndexChanged += statusCbx_SelectedIndexChanged;
            // 
            // ReturnModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(statusCbx);
            Controls.Add(videoTypeCbx);
            Controls.Add(VideoRentedView);
            Controls.Add(returnBtn);
            Controls.Add(titleTxt);
            Controls.Add(feeTxt);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(searchTitleTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReturnModule";
            Size = new Size(1663, 1024);
            ((System.ComponentModel.ISupportInitialize)VideoRentedView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox videoTypeCbx;
        private DataGridView VideoRentedView;
        private Button returnBtn;
        private TextBox titleTxt;
        private TextBox feeTxt;
        private Label label4;
        private Label label6;
        private TextBox searchTitleTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox statusCbx;
    }
}
