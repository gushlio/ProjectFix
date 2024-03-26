﻿namespace ZooBazarDesktopApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabAnimal = new TabPage();
            dataGridViewAnimals = new DataGridView();
            lblAnimalID = new Label();
            txtAnimalID = new TextBox();
            txtLastFeedTime = new TextBox();
            lblLastFeedTime = new Label();
            chkIsSick = new CheckBox();
            txtLocation = new TextBox();
            txtColor = new TextBox();
            txtWeight = new TextBox();
            lblLocation = new Label();
            lblsick = new Label();
            lblColor = new Label();
            lblWeight = new Label();
            lblGender = new Label();
            txtGender = new TextBox();
            label1 = new Label();
            txtAge = new TextBox();
            lblSpecies = new Label();
            txtSpecies = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            btnDelete = new Button();
            btnUpdateAnimal = new Button();
            btnAddAnimal = new Button();
            tabStaff = new TabPage();
            groupBox1 = new GroupBox();
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
            btnDeleteEmployee = new Button();
            btnAddEmployees = new Button();
            dataGridViewStaff = new DataGridView();
            tabTicketManagement = new TabPage();
            btnClear = new Button();
            RemainingTickets = new ListBox();
            CurrentPrices = new ListBox();
            groupBox2 = new GroupBox();
            label12 = new Label();
            btnApply = new Button();
            textBox1 = new TextBox();
            label11 = new Label();
            checkedCategoryTicket = new CheckedListBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            btnDisplay = new Button();
            tabControl1.SuspendLayout();
            tabAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimals).BeginInit();
            tabStaff.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpdateEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            tabTicketManagement.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAnimal);
            tabControl1.Controls.Add(tabStaff);
            tabControl1.Controls.Add(tabTicketManagement);
            tabControl1.Location = new Point(20, 19);
            tabControl1.Margin = new Padding(5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1823, 1074);
            tabControl1.TabIndex = 0;
            // 
            // tabAnimal
            // 
            tabAnimal.Controls.Add(dataGridViewAnimals);
            tabAnimal.Controls.Add(lblAnimalID);
            tabAnimal.Controls.Add(txtAnimalID);
            tabAnimal.Controls.Add(txtLastFeedTime);
            tabAnimal.Controls.Add(lblLastFeedTime);
            tabAnimal.Controls.Add(chkIsSick);
            tabAnimal.Controls.Add(txtLocation);
            tabAnimal.Controls.Add(txtColor);
            tabAnimal.Controls.Add(txtWeight);
            tabAnimal.Controls.Add(lblLocation);
            tabAnimal.Controls.Add(lblsick);
            tabAnimal.Controls.Add(lblColor);
            tabAnimal.Controls.Add(lblWeight);
            tabAnimal.Controls.Add(lblGender);
            tabAnimal.Controls.Add(txtGender);
            tabAnimal.Controls.Add(label1);
            tabAnimal.Controls.Add(txtAge);
            tabAnimal.Controls.Add(lblSpecies);
            tabAnimal.Controls.Add(txtSpecies);
            tabAnimal.Controls.Add(lblName);
            tabAnimal.Controls.Add(txtName);
            tabAnimal.Controls.Add(btnDelete);
            tabAnimal.Controls.Add(btnUpdateAnimal);
            tabAnimal.Controls.Add(btnAddAnimal);
            tabAnimal.Location = new Point(8, 46);
            tabAnimal.Margin = new Padding(5);
            tabAnimal.Name = "tabAnimal";
            tabAnimal.Padding = new Padding(5);
            tabAnimal.Size = new Size(1807, 1020);
            tabAnimal.TabIndex = 0;
            tabAnimal.Text = "Animal";
            tabAnimal.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAnimals
            // 
            dataGridViewAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimals.Location = new Point(868, 147);
            dataGridViewAnimals.Margin = new Padding(5);
            dataGridViewAnimals.Name = "dataGridViewAnimals";
            dataGridViewAnimals.RowHeadersWidth = 51;
            dataGridViewAnimals.Size = new Size(488, 301);
            dataGridViewAnimals.TabIndex = 24;
            dataGridViewAnimals.CellClick += dataGridViewAnimals_CellClick;
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(440, 18);
            lblAnimalID.Margin = new Padding(5, 0, 5, 0);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(111, 32);
            lblAnimalID.TabIndex = 23;
            lblAnimalID.Text = "AnimalID";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(561, 13);
            txtAnimalID.Margin = new Padding(5);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(201, 39);
            txtAnimalID.TabIndex = 22;
            // 
            // txtLastFeedTime
            // 
            txtLastFeedTime.Location = new Point(611, 510);
            txtLastFeedTime.Margin = new Padding(5);
            txtLastFeedTime.Name = "txtLastFeedTime";
            txtLastFeedTime.Size = new Size(201, 39);
            txtLastFeedTime.TabIndex = 21;
            // 
            // lblLastFeedTime
            // 
            lblLastFeedTime.AutoSize = true;
            lblLastFeedTime.Location = new Point(439, 515);
            lblLastFeedTime.Margin = new Padding(5, 0, 5, 0);
            lblLastFeedTime.Name = "lblLastFeedTime";
            lblLastFeedTime.Size = new Size(160, 32);
            lblLastFeedTime.TabIndex = 20;
            lblLastFeedTime.Text = "LastFeedTime";
            // 
            // chkIsSick
            // 
            chkIsSick.AutoSize = true;
            chkIsSick.Location = new Point(561, 400);
            chkIsSick.Margin = new Padding(5);
            chkIsSick.Name = "chkIsSick";
            chkIsSick.Size = new Size(88, 36);
            chkIsSick.TabIndex = 19;
            chkIsSick.Text = "Sick";
            chkIsSick.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(561, 448);
            txtLocation.Margin = new Padding(5);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(201, 39);
            txtLocation.TabIndex = 18;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(561, 339);
            txtColor.Margin = new Padding(5);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(201, 39);
            txtColor.TabIndex = 16;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(561, 277);
            txtWeight.Margin = new Padding(5);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(201, 39);
            txtWeight.TabIndex = 15;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(439, 453);
            lblLocation.Margin = new Padding(5, 0, 5, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(104, 32);
            lblLocation.TabIndex = 14;
            lblLocation.Text = "Location";
            // 
            // lblsick
            // 
            lblsick.AutoSize = true;
            lblsick.Location = new Point(439, 400);
            lblsick.Margin = new Padding(5, 0, 5, 0);
            lblsick.Name = "lblsick";
            lblsick.Size = new Size(111, 32);
            lblsick.TabIndex = 13;
            lblsick.Text = "Animal is";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(439, 344);
            lblColor.Margin = new Padding(5, 0, 5, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(71, 32);
            lblColor.TabIndex = 12;
            lblColor.Text = "Color";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(439, 282);
            lblWeight.Margin = new Padding(5, 0, 5, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(90, 32);
            lblWeight.TabIndex = 11;
            lblWeight.Text = "Weight";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(439, 229);
            lblGender.Margin = new Padding(5, 0, 5, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(92, 32);
            lblGender.TabIndex = 10;
            lblGender.Text = "Gender";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(561, 224);
            txtGender.Margin = new Padding(5);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(201, 39);
            txtGender.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 176);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 32);
            label1.TabIndex = 8;
            label1.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(561, 171);
            txtAge.Margin = new Padding(5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(201, 39);
            txtAge.TabIndex = 7;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(439, 123);
            lblSpecies.Margin = new Padding(5, 0, 5, 0);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(94, 32);
            lblSpecies.TabIndex = 6;
            lblSpecies.Text = "Species";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(561, 118);
            txtSpecies.Margin = new Padding(5);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(201, 39);
            txtSpecies.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(439, 70);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 32);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(561, 66);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 39);
            txtName.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(138, 218);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(198, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Animal";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.Location = new Point(138, 138);
            btnUpdateAnimal.Margin = new Padding(5);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(198, 46);
            btnUpdateAnimal.TabIndex = 1;
            btnUpdateAnimal.Text = "Update Animal";
            btnUpdateAnimal.UseVisualStyleBackColor = true;
            btnUpdateAnimal.Click += btnUpdateAnimal_Click;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(138, 64);
            btnAddAnimal.Margin = new Padding(5);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(198, 46);
            btnAddAnimal.TabIndex = 0;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // tabStaff
            // 
            tabStaff.Controls.Add(groupBox1);
            tabStaff.Controls.Add(btnDeleteEmployee);
            tabStaff.Controls.Add(btnAddEmployees);
            tabStaff.Controls.Add(dataGridViewStaff);
            tabStaff.Location = new Point(8, 46);
            tabStaff.Margin = new Padding(5);
            tabStaff.Name = "tabStaff";
            tabStaff.Padding = new Padding(5);
            tabStaff.Size = new Size(1807, 1020);
            tabStaff.TabIndex = 1;
            tabStaff.Text = "Staff";
            tabStaff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(cmbJobTitle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(numericUpDownUpdateEmployee);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1046, 32);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(736, 978);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Employee";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(211, 882);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(320, 70);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(260, 581);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(381, 39);
            txtPassword.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(260, 491);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(381, 39);
            txtEmail.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 586);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(116, 32);
            label8.TabIndex = 28;
            label8.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 491);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 32);
            label7.TabIndex = 27;
            label7.Text = "Email:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(260, 674);
            dateTimePicker1.Margin = new Padding(5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(404, 39);
            dateTimePicker1.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 682);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 32);
            label6.TabIndex = 25;
            label6.Text = "Hire date: ";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(260, 781);
            txtSalary.Margin = new Padding(5);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(269, 39);
            txtSalary.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 781);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 23;
            label4.Text = "Salary:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(255, 262);
            txtLastName.Margin = new Padding(5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(386, 39);
            txtLastName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 274);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 32);
            label3.TabIndex = 21;
            label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(255, 152);
            txtFirstName.Margin = new Padding(5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(386, 39);
            txtFirstName.TabIndex = 20;
            // 
            // cmbJobTitle
            // 
            cmbJobTitle.FormattingEnabled = true;
            cmbJobTitle.Location = new Point(255, 376);
            cmbJobTitle.Margin = new Padding(5);
            cmbJobTitle.Name = "cmbJobTitle";
            cmbJobTitle.Size = new Size(386, 40);
            cmbJobTitle.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 389);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 32);
            label5.TabIndex = 18;
            label5.Text = "Job Title:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 157);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(134, 32);
            label9.TabIndex = 17;
            label9.Text = "First Name:";
            // 
            // numericUpDownUpdateEmployee
            // 
            numericUpDownUpdateEmployee.Location = new Point(294, 75);
            numericUpDownUpdateEmployee.Margin = new Padding(5);
            numericUpDownUpdateEmployee.Name = "numericUpDownUpdateEmployee";
            numericUpDownUpdateEmployee.Size = new Size(154, 39);
            numericUpDownUpdateEmployee.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 75);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 32);
            label2.TabIndex = 4;
            label2.Text = "Enter the employee ID:";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(621, 939);
            btnDeleteEmployee.Margin = new Padding(5);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(320, 70);
            btnDeleteEmployee.TabIndex = 2;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnAddEmployees
            // 
            btnAddEmployees.Location = new Point(115, 939);
            btnAddEmployees.Margin = new Padding(5);
            btnAddEmployees.Name = "btnAddEmployees";
            btnAddEmployees.Size = new Size(320, 70);
            btnAddEmployees.TabIndex = 1;
            btnAddEmployees.Text = "Add Employee";
            btnAddEmployees.UseVisualStyleBackColor = true;
            btnAddEmployees.Click += btnAddEmployees_Click;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new Point(28, 46);
            dataGridViewStaff.Margin = new Padding(5);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowHeadersWidth = 51;
            dataGridViewStaff.Size = new Size(986, 845);
            dataGridViewStaff.TabIndex = 0;
            // 
            // tabTicketManagement
            // 
            tabTicketManagement.Controls.Add(btnDisplay);
            tabTicketManagement.Controls.Add(btnClear);
            tabTicketManagement.Controls.Add(RemainingTickets);
            tabTicketManagement.Controls.Add(CurrentPrices);
            tabTicketManagement.Controls.Add(groupBox2);
            tabTicketManagement.Location = new Point(8, 46);
            tabTicketManagement.Name = "tabTicketManagement";
            tabTicketManagement.Size = new Size(1807, 1020);
            tabTicketManagement.TabIndex = 2;
            tabTicketManagement.Text = "TicketManagement";
            tabTicketManagement.UseVisualStyleBackColor = true;
            tabTicketManagement.Click += tabTicketManagement_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1418, 349);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // RemainingTickets
            // 
            RemainingTickets.FormattingEnabled = true;
            RemainingTickets.Location = new Point(937, 466);
            RemainingTickets.Name = "RemainingTickets";
            RemainingTickets.Size = new Size(631, 164);
            RemainingTickets.TabIndex = 6;
            // 
            // CurrentPrices
            // 
            CurrentPrices.FormattingEnabled = true;
            CurrentPrices.Location = new Point(937, 41);
            CurrentPrices.Name = "CurrentPrices";
            CurrentPrices.Size = new Size(631, 292);
            CurrentPrices.TabIndex = 5;
            CurrentPrices.SelectedIndexChanged += CurrentPrices_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(btnApply);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(checkedCategoryTicket);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(18, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(794, 989);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ticket Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 516);
            label12.Name = "label12";
            label12.Size = new Size(259, 32);
            label12.TabIndex = 5;
            label12.Text = "Set Amount Of Tickets:";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(590, 300);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(150, 46);
            btnApply.TabIndex = 4;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 307);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 39);
            textBox1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 307);
            label11.Name = "label11";
            label11.Size = new Size(111, 32);
            label11.TabIndex = 2;
            label11.Text = "Set Price:";
            // 
            // checkedCategoryTicket
            // 
            checkedCategoryTicket.FormattingEnabled = true;
            checkedCategoryTicket.Items.AddRange(new object[] { "Adult", "Kid", "Elderly" });
            checkedCategoryTicket.Location = new Point(294, 78);
            checkedCategoryTicket.Name = "checkedCategoryTicket";
            checkedCategoryTicket.Size = new Size(240, 112);
            checkedCategoryTicket.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 78);
            label10.Name = "label10";
            label10.Size = new Size(218, 32);
            label10.TabIndex = 0;
            label10.Text = "Select Ticket Type: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "50", "100", "150", "200", "250", "300" });
            comboBox1.Location = new Point(372, 516);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 6;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(1418, 680);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(150, 46);
            btnDisplay.TabIndex = 7;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1851, 1094);
            Controls.Add(tabControl1);
            Margin = new Padding(5);
            Name = "Main";
            Text = "ZooBazar";
            tabControl1.ResumeLayout(false);
            tabAnimal.ResumeLayout(false);
            tabAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimals).EndInit();
            tabStaff.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpdateEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            tabTicketManagement.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAnimal;
        private TabPage tabStaff;
        private Button btnDeleteEmployee;
        private Button btnAddEmployees;
        private DataGridView dataGridViewStaff;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownUpdateEmployee;
        private Label label2;
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
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnUpdateAnimal;
        private Button btnAddAnimal;
        private TextBox txtSpecies;
        private Label lblName;
        private TextBox txtName;
        private Label lblSpecies;
        private TextBox txtLocation;
        private TextBox txtColor;
        private TextBox txtWeight;
        private Label lblLocation;
        private Label lblsick;
        private Label lblColor;
        private Label lblWeight;
        private Label lblGender;
        private TextBox txtGender;
        private Label label1;
        private TextBox txtAge;
        private CheckBox chkIsSick;
        private Label lblLastFeedTime;
        private TextBox txtLastFeedTime;
        private Label lblAnimalID;
        private TextBox txtAnimalID;
        private DataGridView dataGridViewAnimals;
        private TabPage tabTicketManagement;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox textBox1;
        private Label label11;
        private CheckedListBox checkedCategoryTicket;
        private ListBox CurrentPrices;
        private Label label12;
        private Button btnApply;
        private ListBox RemainingTickets;
        private Button btnClear;
        private Button btnDisplay;
        private ComboBox comboBox1;
    }
}
