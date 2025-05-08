namespace Bogys_Winforms.Windows.Admin
{
    partial class VideoList
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
            VideoView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            videoTypeCbx = new ComboBox();
            searchTitleTxt = new TextBox();
            label3 = new Label();
            searchNameTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)VideoView).BeginInit();
            SuspendLayout();
            // 
            // VideoView
            // 
            VideoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VideoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoView.Location = new Point(79, 229);
            VideoView.MultiSelect = false;
            VideoView.Name = "VideoView";
            VideoView.ReadOnly = true;
            VideoView.RowHeadersWidth = 62;
            VideoView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VideoView.Size = new Size(1532, 694);
            VideoView.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(79, 94);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 26;
            label2.Text = "List of Rented Videos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 228, 186);
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 27;
            label1.Text = "Video List";
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "ALL", "DVD", "VCD" });
            videoTypeCbx.Location = new Point(891, 170);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(233, 33);
            videoTypeCbx.TabIndex = 38;
            videoTypeCbx.SelectedIndexChanged += videoTypeCbx_SelectedIndexChanged;
            // 
            // searchTitleTxt
            // 
            searchTitleTxt.BorderStyle = BorderStyle.FixedSingle;
            searchTitleTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTitleTxt.ForeColor = Color.Black;
            searchTitleTxt.Location = new Point(79, 170);
            searchTitleTxt.Name = "searchTitleTxt";
            searchTitleTxt.PlaceholderText = "Search by Title";
            searchTitleTxt.Size = new Size(301, 34);
            searchTitleTxt.TabIndex = 37;
            searchTitleTxt.TextChanged += searchTitleTxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(780, 170);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 36;
            label3.Text = "Video Type :";
            // 
            // searchNameTxt
            // 
            searchNameTxt.BorderStyle = BorderStyle.FixedSingle;
            searchNameTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchNameTxt.ForeColor = Color.Black;
            searchNameTxt.Location = new Point(434, 170);
            searchNameTxt.Name = "searchNameTxt";
            searchNameTxt.PlaceholderText = "Search by Customer Name";
            searchNameTxt.Size = new Size(301, 34);
            searchNameTxt.TabIndex = 37;
            searchNameTxt.TextChanged += searchNameTxt_TextChanged;
            // 
            // VideoList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(videoTypeCbx);
            Controls.Add(searchNameTxt);
            Controls.Add(searchTitleTxt);
            Controls.Add(label3);
            Controls.Add(VideoView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VideoList";
            Size = new Size(1663, 1024);
            ((System.ComponentModel.ISupportInitialize)VideoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView VideoView;
        private Label label2;
        private Label label1;
        private ComboBox videoTypeCbx;
        private TextBox searchTitleTxt;
        private Label label3;
        private TextBox searchNameTxt;
    }
}
