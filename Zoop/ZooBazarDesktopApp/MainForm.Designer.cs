namespace ZooBazarDesktopApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelQuickAccess = new Panel();
            button1 = new Button();
            btnReport = new Button();
            lblZooBazar = new Label();
            btnDashboard = new Button();
            btnAnimals = new Button();
            btnStaff = new Button();
            btnTickets = new Button();
            btnAreas = new Button();
            btnClose = new Button();
            panelQuickAccess.SuspendLayout();
            SuspendLayout();
            // 
            // panelQuickAccess
            // 
            panelQuickAccess.AutoSize = true;
            panelQuickAccess.BackColor = Color.DarkSeaGreen;
            panelQuickAccess.Controls.Add(button1);
            panelQuickAccess.Controls.Add(btnReport);
            panelQuickAccess.Controls.Add(lblZooBazar);
            panelQuickAccess.Controls.Add(btnDashboard);
            panelQuickAccess.Controls.Add(btnAnimals);
            panelQuickAccess.Controls.Add(btnStaff);
            panelQuickAccess.Controls.Add(btnTickets);
            panelQuickAccess.Controls.Add(btnAreas);
            panelQuickAccess.Location = new Point(2, 3);
            panelQuickAccess.Name = "panelQuickAccess";
            panelQuickAccess.Size = new Size(131, 917);
            panelQuickAccess.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(3, 829);
            button1.Name = "button1";
            button1.Size = new Size(121, 85);
            button1.TabIndex = 7;
            button1.Text = "Calendar";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReport
            // 
            btnReport.BackgroundImageLayout = ImageLayout.Center;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 10F);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.TopCenter;
            btnReport.Location = new Point(7, 714);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(121, 85);
            btnReport.TabIndex = 6;
            btnReport.Text = "Report";
            btnReport.TextAlign = ContentAlignment.BottomCenter;
            btnReport.UseVisualStyleBackColor = true;
            // 
            // lblZooBazar
            // 
            lblZooBazar.AutoSize = true;
            lblZooBazar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblZooBazar.ForeColor = Color.White;
            lblZooBazar.Location = new Point(7, 6);
            lblZooBazar.Name = "lblZooBazar";
            lblZooBazar.Size = new Size(117, 92);
            lblZooBazar.TabIndex = 0;
            lblZooBazar.Text = "Zoo\r\n Bazar";
            lblZooBazar.TextAlign = ContentAlignment.MiddleCenter;
            lblZooBazar.Click += lblQuickAccess_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImageLayout = ImageLayout.Center;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.TopCenter;
            btnDashboard.Location = new Point(7, 117);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(121, 85);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.BottomCenter;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnAnimals
            // 
            btnAnimals.BackgroundImageLayout = ImageLayout.Center;
            btnAnimals.FlatAppearance.BorderSize = 0;
            btnAnimals.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            btnAnimals.FlatStyle = FlatStyle.Flat;
            btnAnimals.Font = new Font("Segoe UI", 10F);
            btnAnimals.ForeColor = Color.White;
            btnAnimals.Image = (Image)resources.GetObject("btnAnimals.Image");
            btnAnimals.ImageAlign = ContentAlignment.TopCenter;
            btnAnimals.Location = new Point(3, 236);
            btnAnimals.Name = "btnAnimals";
            btnAnimals.Size = new Size(125, 100);
            btnAnimals.TabIndex = 2;
            btnAnimals.Text = "Animals";
            btnAnimals.TextAlign = ContentAlignment.BottomCenter;
            btnAnimals.UseVisualStyleBackColor = true;
            btnAnimals.Click += btnAnimals_Click;
            // 
            // btnStaff
            // 
            btnStaff.BackgroundImageLayout = ImageLayout.Center;
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Segoe UI", 10F);
            btnStaff.ForeColor = Color.White;
            btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
            btnStaff.ImageAlign = ContentAlignment.TopCenter;
            btnStaff.Location = new Point(3, 369);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(125, 85);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.TextAlign = ContentAlignment.BottomCenter;
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnTickets
            // 
            btnTickets.BackgroundImageLayout = ImageLayout.Center;
            btnTickets.FlatAppearance.BorderSize = 0;
            btnTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            btnTickets.FlatStyle = FlatStyle.Flat;
            btnTickets.Font = new Font("Segoe UI", 10F);
            btnTickets.ForeColor = Color.White;
            btnTickets.Image = (Image)resources.GetObject("btnTickets.Image");
            btnTickets.ImageAlign = ContentAlignment.TopCenter;
            btnTickets.Location = new Point(0, 481);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(128, 85);
            btnTickets.TabIndex = 4;
            btnTickets.Text = "Tickets";
            btnTickets.TextAlign = ContentAlignment.BottomCenter;
            btnTickets.UseVisualStyleBackColor = true;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnAreas
            // 
            btnAreas.BackgroundImageLayout = ImageLayout.Center;
            btnAreas.FlatAppearance.BorderSize = 0;
            btnAreas.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            btnAreas.FlatStyle = FlatStyle.Flat;
            btnAreas.Font = new Font("Segoe UI", 10F);
            btnAreas.ForeColor = Color.White;
            btnAreas.Image = (Image)resources.GetObject("btnAreas.Image");
            btnAreas.ImageAlign = ContentAlignment.TopCenter;
            btnAreas.Location = new Point(0, 596);
            btnAreas.Name = "btnAreas";
            btnAreas.Size = new Size(128, 85);
            btnAreas.TabIndex = 5;
            btnAreas.Text = "Map";
            btnAreas.TextAlign = ContentAlignment.BottomCenter;
            btnAreas.UseVisualStyleBackColor = true;
            btnAreas.Click += btnAreas_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClose.ForeColor = Color.Black;
            btnClose.ImageAlign = ContentAlignment.TopCenter;
            btnClose.Location = new Point(1275, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 27);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.BottomCenter;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1329, 921);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(panelQuickAccess);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panelQuickAccess.ResumeLayout(false);
            panelQuickAccess.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelQuickAccess;
        private Button btnReport;
        private Button btnDashboard;
        private Label lblZooBazar;
        private Button btnAnimals;
        private Button btnStaff;
        private Button btnTickets;
        private Button btnAreas;
        private Button btnClose;
        private Button button1;
    }
}