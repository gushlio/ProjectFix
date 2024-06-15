namespace ZooBazarDesktopApp.UserControls
{
    partial class ReportsControl
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listBoxReports = new ListBox();
            groupBox2 = new GroupBox();
            btnViewReport = new Button();
            btnCreateReport = new Button();
            txtTitle = new TextBox();
            cboCategory = new ComboBox();
            txtDescription = new RichTextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-11, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 106);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(417, 33);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "REPORTS";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(btnViewReport);
            groupBox1.Controls.Add(listBoxReports);
            groupBox1.Location = new Point(576, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 459);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "All Reports";
            // 
            // listBoxReports
            // 
            listBoxReports.FormattingEnabled = true;
            listBoxReports.ItemHeight = 15;
            listBoxReports.Location = new Point(6, 22);
            listBoxReports.Name = "listBoxReports";
            listBoxReports.Size = new Size(319, 349);
            listBoxReports.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.Controls.Add(txtDescription);
            groupBox2.Controls.Add(cboCategory);
            groupBox2.Controls.Add(txtTitle);
            groupBox2.Controls.Add(btnCreateReport);
            groupBox2.Location = new Point(24, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 385);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Submit Report";
            // 
            // btnViewReport
            // 
            btnViewReport.Location = new Point(6, 377);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(319, 76);
            btnViewReport.TabIndex = 1;
            btnViewReport.Text = "View Report";
            btnViewReport.UseVisualStyleBackColor = true;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // btnCreateReport
            // 
            btnCreateReport.BackColor = Color.DarkSeaGreen;
            btnCreateReport.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCreateReport.ForeColor = SystemColors.ButtonHighlight;
            btnCreateReport.Location = new Point(6, 323);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(471, 56);
            btnCreateReport.TabIndex = 0;
            btnCreateReport.Text = "Submit Report";
            btnCreateReport.UseVisualStyleBackColor = false;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(134, 43);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(328, 23);
            txtTitle.TabIndex = 1;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(134, 83);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(187, 23);
            cboCategory.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(134, 112);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(328, 205);
            txtDescription.TabIndex = 3;
            txtDescription.Text = "";
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ReportsControl";
            Size = new Size(934, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private ListBox listBoxReports;
        private Button btnViewReport;
        private GroupBox groupBox2;
        private Button btnCreateReport;
        private RichTextBox txtDescription;
        private ComboBox cboCategory;
        private TextBox txtTitle;
    }
}
