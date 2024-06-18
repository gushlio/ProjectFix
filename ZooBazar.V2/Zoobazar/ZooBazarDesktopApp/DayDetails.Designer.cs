namespace ZooBazarDesktopApp
{
    partial class DayDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayDetails));
            labelDate = new Label();
            labelDetail = new Label();
            dgvFeeding = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFeeding).BeginInit();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.Transparent;
            labelDate.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic);
            labelDate.ForeColor = SystemColors.HighlightText;
            labelDate.Location = new Point(26, 25);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(88, 37);
            labelDate.TabIndex = 0;
            labelDate.Text = "label1";
            // 
            // labelDetail
            // 
            labelDetail.AutoSize = true;
            labelDetail.BackColor = Color.Transparent;
            labelDetail.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            labelDetail.ForeColor = SystemColors.ButtonHighlight;
            labelDetail.Location = new Point(328, 81);
            labelDetail.Name = "labelDetail";
            labelDetail.Size = new Size(112, 46);
            labelDetail.TabIndex = 1;
            labelDetail.Text = "label2";
            // 
            // dgvFeeding
            // 
            dgvFeeding.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeeding.Location = new Point(69, 130);
            dgvFeeding.Name = "dgvFeeding";
            dgvFeeding.Size = new Size(634, 239);
            dgvFeeding.TabIndex = 2;
            // 
            // DayDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(774, 381);
            Controls.Add(dgvFeeding);
            Controls.Add(labelDetail);
            Controls.Add(labelDate);
            DoubleBuffered = true;
            Name = "DayDetails";
            Text = "DayDetails";
            ((System.ComponentModel.ISupportInitialize)dgvFeeding).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private Label labelDetail;
        private DataGridView dgvFeeding;
    }
}