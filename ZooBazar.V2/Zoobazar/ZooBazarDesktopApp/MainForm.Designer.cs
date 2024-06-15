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
            button2 = new Button();
            button1 = new Button();
            lblZooBazar = new Label();
            btnReport = new Button();
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
            panelQuickAccess.Controls.Add(button2);
            panelQuickAccess.Controls.Add(button1);
            panelQuickAccess.Controls.Add(lblZooBazar);
            panelQuickAccess.Controls.Add(btnReport);
            panelQuickAccess.Controls.Add(btnDashboard);
            panelQuickAccess.Controls.Add(btnAnimals);
            panelQuickAccess.Controls.Add(btnStaff);
            panelQuickAccess.Controls.Add(btnTickets);
            panelQuickAccess.Controls.Add(btnAreas);
            panelQuickAccess.Location = new Point(2, -1);
            panelQuickAccess.Margin = new Padding(3, 2, 3, 2);
            panelQuickAccess.Name = "panelQuickAccess";
            panelQuickAccess.Size = new Size(158, 826);
            panelQuickAccess.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 68, 77);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(6, 620);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(106, 64);
            button2.TabIndex = 8;
            button2.Text = "Tasks";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            button1.Location = new Point(6, 705);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(106, 64);
            button1.TabIndex = 7;
            button1.Text = "Calendar";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblZooBazar
            // 
            lblZooBazar.AutoSize = true;
            lblZooBazar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblZooBazar.ForeColor = Color.White;
            lblZooBazar.Location = new Point(53, 16);
            lblZooBazar.Name = "lblZooBazar";
            lblZooBazar.Size = new Size(95, 74);
            lblZooBazar.TabIndex = 0;
            lblZooBazar.Text = "Zoo\r\n Bazar";
            lblZooBazar.TextAlign = ContentAlignment.MiddleCenter;
            lblZooBazar.Click += lblQuickAccess_Click;
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
            btnReport.Location = new Point(6, 536);
            btnReport.Margin = new Padding(3, 2, 3, 2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(106, 64);
            btnReport.TabIndex = 6;
            btnReport.Text = "Report";
            btnReport.TextAlign = ContentAlignment.BottomCenter;
            btnReport.UseVisualStyleBackColor = true;
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
            btnDashboard.Location = new Point(6, 88);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(106, 64);
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
            btnAnimals.Location = new Point(3, 177);
            btnAnimals.Margin = new Padding(3, 2, 3, 2);
            btnAnimals.Name = "btnAnimals";
            btnAnimals.Size = new Size(109, 75);
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
            btnStaff.Location = new Point(3, 277);
            btnStaff.Margin = new Padding(3, 2, 3, 2);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(109, 64);
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
            btnTickets.Location = new Point(0, 361);
            btnTickets.Margin = new Padding(3, 2, 3, 2);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(112, 64);
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
            btnAreas.Location = new Point(0, 447);
            btnAreas.Margin = new Padding(3, 2, 3, 2);
            btnAreas.Name = "btnAreas";
            btnAreas.Size = new Size(112, 64);
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
            btnClose.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClose.ForeColor = Color.Black;
            btnClose.ImageAlign = ContentAlignment.TopCenter;
            btnClose.Location = new Point(1641, 4);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 37);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.BottomCenter;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1680, 791);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(panelQuickAccess);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
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
        private Button button2;
    }
}