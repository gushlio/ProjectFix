namespace ZooBazarDesktopApp
{
    partial class ZookeeperForm
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
            tabControl1 = new TabControl();
            Reports = new TabPage();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTitle = new TextBox();
            btnCreateReport = new Button();
            txtDescription = new RichTextBox();
            cboCategory = new ComboBox();
            btnViewReport = new Button();
            groupBox1 = new GroupBox();
            listBoxReports = new ListBox();
            Schedule = new TabPage();
            panel2 = new Panel();
            btnSettings = new Button();
            btnSchedule = new Button();
            btnHome = new Button();
            btnReports = new Button();
            panelContent = new Panel();
            tabControl1.SuspendLayout();
            Reports.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Reports);
            tabControl1.Controls.Add(Schedule);
            tabControl1.Location = new Point(1102, 529);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(638, 567);
            tabControl1.TabIndex = 0;
            // 
            // Reports
            // 
            Reports.Controls.Add(panel1);
            Reports.Controls.Add(groupBox2);
            Reports.Controls.Add(btnViewReport);
            Reports.Controls.Add(groupBox1);
            Reports.Location = new Point(4, 24);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3);
            Reports.Size = new Size(630, 539);
            Reports.TabIndex = 0;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 96);
            panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtTitle);
            groupBox2.Controls.Add(btnCreateReport);
            groupBox2.Controls.Add(txtDescription);
            groupBox2.Controls.Add(cboCategory);
            groupBox2.Location = new Point(6, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 326);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Submit New Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 117);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 10;
            label3.Text = "Report Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 77);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Category:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 8;
            label1.Text = "Report Title:";
            label1.Click += label1_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(120, 32);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(283, 23);
            txtTitle.TabIndex = 5;
            // 
            // btnCreateReport
            // 
            btnCreateReport.Location = new Point(15, 242);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(392, 65);
            btnCreateReport.TabIndex = 3;
            btnCreateReport.Text = "Submit Report";
            btnCreateReport.UseVisualStyleBackColor = true;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 114);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(268, 96);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(120, 74);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 4;
            // 
            // btnViewReport
            // 
            btnViewReport.Location = new Point(519, 466);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(263, 65);
            btnViewReport.TabIndex = 2;
            btnViewReport.Text = "View Report";
            btnViewReport.UseVisualStyleBackColor = true;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxReports);
            groupBox1.Location = new Point(519, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 335);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reports History";
            // 
            // listBoxReports
            // 
            listBoxReports.FormattingEnabled = true;
            listBoxReports.ItemHeight = 15;
            listBoxReports.Location = new Point(6, 22);
            listBoxReports.Name = "listBoxReports";
            listBoxReports.Size = new Size(251, 304);
            listBoxReports.TabIndex = 0;
            // 
            // Schedule
            // 
            Schedule.Location = new Point(4, 24);
            Schedule.Name = "Schedule";
            Schedule.Padding = new Padding(3);
            Schedule.Size = new Size(630, 369);
            Schedule.TabIndex = 1;
            Schedule.Text = "tabPage2";
            Schedule.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(btnSettings);
            panel2.Controls.Add(btnSchedule);
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(btnReports);
            panel2.Location = new Point(-2, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 670);
            panel2.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Location = new Point(35, 431);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(96, 69);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "SETTINGS";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.Transparent;
            btnSchedule.Location = new Point(35, 339);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(96, 69);
            btnSchedule.TabIndex = 3;
            btnSchedule.Text = "SCHEDULE";
            btnSchedule.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Location = new Point(35, 168);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(96, 69);
            btnHome.TabIndex = 2;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.Location = new Point(35, 253);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(96, 69);
            btnReports.TabIndex = 0;
            btnReports.Text = "REPORTS";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(164, 12);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(688, 471);
            panelContent.TabIndex = 2;
            // 
            // ZookeeperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 662);
            Controls.Add(panelContent);
            Controls.Add(panel2);
            Controls.Add(tabControl1);
            Name = "ZookeeperForm";
            Text = "ZookeeperForm";
            tabControl1.ResumeLayout(false);
            Reports.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Reports;
        private TabPage Schedule;
        private GroupBox groupBox1;
        private ListBox listBoxReports;
        private Button btnViewReport;
        private Button btnCreateReport;
        private ComboBox cboCategory;
        private TextBox txtTitle;
        private RichTextBox txtDescription;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnReports;
        private Button btnSettings;
        private Button btnSchedule;
        private Button btnHome;
        private Panel panelContent;
    }
}