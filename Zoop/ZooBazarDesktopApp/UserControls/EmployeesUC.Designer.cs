namespace LibraryApplication.UserControls
{
    partial class EmployeesUC
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
            TabControl tabControl1;
            tabPage1 = new TabPage();
            panelUpdate = new Panel();
            lblUpdateemployee = new Label();
            panelEmployees = new Panel();
            lblEmployees = new Label();
            gbAddBook = new GroupBox();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtSalary = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            cmbJobTitle = new ComboBox();
            label5 = new Label();
            label9 = new Label();
            numericUpDownUpdateEmployee = new NumericUpDown();
            label2 = new Label();
            gbBooks = new GroupBox();
            dataGridViewStaff = new DataGridView();
            btnDeleteEmployee = new Button();
            btnAddEmployee = new Button();
            tabPage2 = new TabPage();
            tabControl1 = new TabControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panelUpdate.SuspendLayout();
            panelEmployees.SuspendLayout();
            gbAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpdateEmployee).BeginInit();
            gbBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(865, 736);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(panelUpdate);
            tabPage1.Controls.Add(panelEmployees);
            tabPage1.Controls.Add(gbAddBook);
            tabPage1.Controls.Add(gbBooks);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(857, 703);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Employees";
            // 
            // panelUpdate
            // 
            panelUpdate.BackColor = Color.DarkGreen;
            panelUpdate.Controls.Add(lblUpdateemployee);
            panelUpdate.Location = new Point(6, 6);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(831, 28);
            panelUpdate.TabIndex = 14;
            // 
            // lblUpdateemployee
            // 
            lblUpdateemployee.AutoSize = true;
            lblUpdateemployee.BackColor = Color.DarkGreen;
            lblUpdateemployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblUpdateemployee.ForeColor = Color.White;
            lblUpdateemployee.Location = new Point(3, 3);
            lblUpdateemployee.Name = "lblUpdateemployee";
            lblUpdateemployee.Size = new Size(69, 23);
            lblUpdateemployee.TabIndex = 0;
            lblUpdateemployee.Text = "Update";
            // 
            // panelEmployees
            // 
            panelEmployees.BackColor = Color.DarkGreen;
            panelEmployees.Controls.Add(lblEmployees);
            panelEmployees.Location = new Point(6, 347);
            panelEmployees.Name = "panelEmployees";
            panelEmployees.Size = new Size(831, 28);
            panelEmployees.TabIndex = 16;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.BackColor = Color.DarkGreen;
            lblEmployees.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEmployees.ForeColor = Color.White;
            lblEmployees.Location = new Point(3, 3);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(95, 23);
            lblEmployees.TabIndex = 0;
            lblEmployees.Text = "Employees";
            // 
            // gbAddBook
            // 
            gbAddBook.BackColor = Color.White;
            gbAddBook.Controls.Add(btnUpdate);
            gbAddBook.Controls.Add(txtPassword);
            gbAddBook.Controls.Add(txtEmail);
            gbAddBook.Controls.Add(label8);
            gbAddBook.Controls.Add(label7);
            gbAddBook.Controls.Add(dateTimePicker1);
            gbAddBook.Controls.Add(label6);
            gbAddBook.Controls.Add(txtSalary);
            gbAddBook.Controls.Add(label4);
            gbAddBook.Controls.Add(txtLastName);
            gbAddBook.Controls.Add(label3);
            gbAddBook.Controls.Add(txtFirstName);
            gbAddBook.Controls.Add(cmbJobTitle);
            gbAddBook.Controls.Add(label5);
            gbAddBook.Controls.Add(label9);
            gbAddBook.Controls.Add(numericUpDownUpdateEmployee);
            gbAddBook.Controls.Add(label2);
            gbAddBook.Location = new Point(6, 6);
            gbAddBook.Name = "gbAddBook";
            gbAddBook.Size = new Size(831, 335);
            gbAddBook.TabIndex = 0;
            gbAddBook.TabStop = false;
            gbAddBook.Text = "Add Book";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.OldLace;
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnUpdate.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.DarkGreen;
            btnUpdate.Location = new Point(336, 298);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(201, 31);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(573, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 27);
            txtPassword.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(573, 54);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 27);
            txtEmail.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(450, 126);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 36;
            label8.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 57);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 35;
            label7.Text = "Email:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(573, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 191);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 33;
            label6.Text = "Hire date: ";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(573, 251);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(167, 27);
            txtSalary.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 259);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 31;
            label4.Text = "Salary:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(138, 184);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(239, 27);
            txtLastName.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 191);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 29;
            label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(138, 119);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(239, 27);
            txtFirstName.TabIndex = 28;
            // 
            // cmbJobTitle
            // 
            cmbJobTitle.FormattingEnabled = true;
            cmbJobTitle.Location = new Point(138, 251);
            cmbJobTitle.Name = "cmbJobTitle";
            cmbJobTitle.Size = new Size(239, 28);
            cmbJobTitle.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 259);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 26;
            label5.Text = "Job Title:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 126);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 25;
            label9.Text = "First Name:";
            // 
            // numericUpDownUpdateEmployee
            // 
            numericUpDownUpdateEmployee.Location = new Point(282, 50);
            numericUpDownUpdateEmployee.Name = "numericUpDownUpdateEmployee";
            numericUpDownUpdateEmployee.Size = new Size(95, 27);
            numericUpDownUpdateEmployee.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 57);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 23;
            label2.Text = "Enter the employee ID:";
            // 
            // gbBooks
            // 
            gbBooks.BackColor = Color.White;
            gbBooks.Controls.Add(dataGridViewStaff);
            gbBooks.Controls.Add(btnDeleteEmployee);
            gbBooks.Controls.Add(btnAddEmployee);
            gbBooks.Location = new Point(6, 347);
            gbBooks.Name = "gbBooks";
            gbBooks.Size = new Size(831, 334);
            gbBooks.TabIndex = 15;
            gbBooks.TabStop = false;
            gbBooks.Text = "empl";
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new Point(5, 34);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowHeadersWidth = 51;
            dataGridViewStaff.Size = new Size(818, 237);
            dataGridViewStaff.TabIndex = 42;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.OldLace;
            btnDeleteEmployee.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnDeleteEmployee.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnDeleteEmployee.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteEmployee.ForeColor = Color.DarkGreen;
            btnDeleteEmployee.Location = new Point(526, 287);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(201, 31);
            btnDeleteEmployee.TabIndex = 41;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.OldLace;
            btnAddEmployee.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnAddEmployee.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnAddEmployee.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.DarkGreen;
            btnAddEmployee.Location = new Point(125, 287);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(201, 31);
            btnAddEmployee.TabIndex = 40;
            btnAddEmployee.Text = "Add";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(857, 703);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Shifts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // EmployeesUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Location = new Point(140, 40);
            Name = "EmployeesUC";
            Size = new Size(898, 773);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            panelEmployees.ResumeLayout(false);
            panelEmployees.PerformLayout();
            gbAddBook.ResumeLayout(false);
            gbAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpdateEmployee).EndInit();
            gbBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAddBook;
        private Panel panelUpdate;
        private Label lblUpdateemployee;
        private Panel panelEmployees;
        private Label lblEmployees;
        private GroupBox gbBooks;
        private Button btnUpdate;
        private Button btnAddEmployee;
        private Button btnDeleteEmployee;
        private DataGridView dataGridViewStaff;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txtSalary;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private ComboBox cmbJobTitle;
        private Label label5;
        private Label label9;
        private NumericUpDown numericUpDownUpdateEmployee;
        private Label label2;
    }
}
