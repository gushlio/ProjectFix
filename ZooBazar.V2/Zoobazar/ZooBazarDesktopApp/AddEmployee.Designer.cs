namespace DesktopApp
{
    partial class AddEmployee
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
            label1 = new Label();
            label2 = new Label();
            cmbJobTitle = new ComboBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            btnAddEmployee = new Button();
            txtSalary = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 175);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Job Title:";
            // 
            // cmbJobTitle
            // 
            cmbJobTitle.FormattingEnabled = true;
            cmbJobTitle.Location = new Point(176, 167);
            cmbJobTitle.Name = "cmbJobTitle";
            cmbJobTitle.Size = new Size(239, 28);
            cmbJobTitle.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(176, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(239, 27);
            txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 103);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(176, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(239, 27);
            txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 420);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "Salary:";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.FlatAppearance.BorderColor = Color.Maroon;
            btnAddEmployee.FlatAppearance.BorderSize = 6;
            btnAddEmployee.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnAddEmployee.Location = new Point(137, 497);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(177, 56);
            btnAddEmployee.TabIndex = 8;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(179, 420);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(167, 27);
            txtSalary.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(179, 353);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 358);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 10;
            label6.Text = "Hire date: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 239);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 298);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 14;
            label8.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(179, 239);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(179, 295);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 27);
            txtPassword.TabIndex = 16;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(441, 586);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(btnAddEmployee);
            Controls.Add(txtSalary);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(cmbJobTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEmployee";
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbJobTitle;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private Button btnAddEmployee;
        private TextBox txtSalary;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}