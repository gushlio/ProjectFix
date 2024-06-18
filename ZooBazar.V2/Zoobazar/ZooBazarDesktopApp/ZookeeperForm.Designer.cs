namespace ZooBazarDesktopApp
{
    partial class ZooKeeperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZooKeeperForm));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblAnimal = new Label();
            pictureBoxStatistics = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBoxAnimals = new PictureBox();
            pictureBoxEmployees = new PictureBox();
            pnlForm = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStatistics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnimals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployees).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAnimal);
            panel1.Controls.Add(pictureBoxStatistics);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxAnimals);
            panel1.Controls.Add(pictureBoxEmployees);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 729);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(29, 679);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 9;
            label4.Text = "Ticketng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(29, 451);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 8;
            label3.Text = "Time Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(29, 568);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 7;
            label2.Text = "Statistics";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1, 315);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 6;
            label1.Text = "Employee Manager";
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAnimal.ForeColor = SystemColors.ControlLightLight;
            lblAnimal.Location = new Point(3, 207);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(137, 21);
            lblAnimal.TabIndex = 5;
            lblAnimal.Text = "Animal Manager";
            // 
            // pictureBoxStatistics
            // 
            pictureBoxStatistics.BackgroundImage = (Image)resources.GetObject("pictureBoxStatistics.BackgroundImage");
            pictureBoxStatistics.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxStatistics.Location = new Point(29, 495);
            pictureBoxStatistics.Name = "pictureBoxStatistics";
            pictureBoxStatistics.Size = new Size(92, 79);
            pictureBoxStatistics.TabIndex = 2;
            pictureBoxStatistics.TabStop = false;
            pictureBoxStatistics.Click += pictureBoxStatistics_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(29, 601);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 82);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(29, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 84);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBoxAnimals
            // 
            pictureBoxAnimals.BackgroundImage = (Image)resources.GetObject("pictureBoxAnimals.BackgroundImage");
            pictureBoxAnimals.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAnimals.Location = new Point(29, 122);
            pictureBoxAnimals.Name = "pictureBoxAnimals";
            pictureBoxAnimals.Size = new Size(92, 82);
            pictureBoxAnimals.TabIndex = 1;
            pictureBoxAnimals.TabStop = false;
            pictureBoxAnimals.Click += pictureBoxAnimals_Click;
            // 
            // pictureBoxEmployees
            // 
            pictureBoxEmployees.BackgroundImage = Properties.Resources.icons8_employees_50;
            pictureBoxEmployees.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxEmployees.Location = new Point(29, 246);
            pictureBoxEmployees.Name = "pictureBoxEmployees";
            pictureBoxEmployees.Size = new Size(92, 81);
            pictureBoxEmployees.TabIndex = 0;
            pictureBoxEmployees.TabStop = false;
            pictureBoxEmployees.Click += pictureBoxEmployees_Click;
            // 
            // pnlForm
            // 
            pnlForm.Location = new Point(156, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(1259, 729);
            pnlForm.TabIndex = 1;
            // 
            // ZooKeeperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1415, 726);
            Controls.Add(pnlForm);
            Controls.Add(panel1);
            Name = "ZooKeeperForm";
            Text = "ZooKeeperForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStatistics).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnimals).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxEmployees;
        private PictureBox pictureBoxStatistics;
        private PictureBox pictureBoxAnimals;
        private Label lblAnimal;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel pnlForm;
    }
}