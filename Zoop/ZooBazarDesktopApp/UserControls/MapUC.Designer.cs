namespace ZooBazarDesktopApp.UserControls
{
    partial class MapUC
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
            dgvImages = new DataGridView();
            Image = new DataGridViewImageColumn();
            btnAddImage = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImages).BeginInit();
            SuspendLayout();
            // 
            // dgvImages
            // 
            dgvImages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImages.Columns.AddRange(new DataGridViewColumn[] { Image });
            dgvImages.Location = new Point(114, 82);
            dgvImages.Name = "dgvImages";
            dgvImages.RowHeadersWidth = 51;
            dgvImages.Size = new Size(896, 478);
            dgvImages.TabIndex = 9;
            // 
            // Image
            // 
            Image.HeaderText = "Column1";
            Image.MinimumWidth = 6;
            Image.Name = "Image";
            Image.Width = 125;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.OldLace;
            btnAddImage.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnAddImage.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnAddImage.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddImage.ForeColor = Color.DarkGreen;
            btnAddImage.Location = new Point(244, 632);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(201, 31);
            btnAddImage.TabIndex = 40;
            btnAddImage.Text = "Add Image";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button1.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(707, 632);
            button1.Name = "button1";
            button1.Size = new Size(201, 31);
            button1.TabIndex = 41;
            button1.Text = "Delete Image";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MapUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(btnAddImage);
            Controls.Add(dgvImages);
            Location = new Point(140, 40);
            Name = "MapUC";
            Size = new Size(1151, 722);
            ((System.ComponentModel.ISupportInitialize)dgvImages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvImages;
        private DataGridViewImageColumn Image;
        private Button btnAddImage;
        private Button button1;
    }
}
