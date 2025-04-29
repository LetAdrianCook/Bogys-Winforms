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
            searchTxt = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)VideoView).BeginInit();
            SuspendLayout();
            // 
            // VideoView
            // 
            VideoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoView.Location = new Point(32, 148);
            VideoView.MultiSelect = false;
            VideoView.Name = "VideoView";
            VideoView.RowHeadersWidth = 62;
            VideoView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VideoView.Size = new Size(757, 468);
            VideoView.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F);
            label2.ForeColor = Color.FromArgb(255, 228, 186);
            label2.Location = new Point(32, 59);
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
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 27;
            label1.Text = "Video List";
            // 
            // videoTypeCbx
            // 
            videoTypeCbx.FormattingEnabled = true;
            videoTypeCbx.Items.AddRange(new object[] { "DVD", "VCD" });
            videoTypeCbx.Location = new Point(424, 99);
            videoTypeCbx.Name = "videoTypeCbx";
            videoTypeCbx.Size = new Size(152, 33);
            videoTypeCbx.TabIndex = 38;
            // 
            // searchTxt
            // 
            searchTxt.BorderStyle = BorderStyle.FixedSingle;
            searchTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.ForeColor = Color.Black;
            searchTxt.Location = new Point(32, 97);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "Search by Title";
            searchTxt.Size = new Size(280, 34);
            searchTxt.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F);
            label3.ForeColor = Color.FromArgb(255, 228, 186);
            label3.Location = new Point(318, 102);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 36;
            label3.Text = "Video Type :";
            // 
            // VideoList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 68, 92);
            Controls.Add(videoTypeCbx);
            Controls.Add(searchTxt);
            Controls.Add(label3);
            Controls.Add(VideoView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VideoList";
            Size = new Size(823, 664);
            ((System.ComponentModel.ISupportInitialize)VideoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView VideoView;
        private Label label2;
        private Label label1;
        private ComboBox videoTypeCbx;
        private TextBox searchTxt;
        private Label label3;
    }
}
