namespace ZooBazarDesktopApp.UserControls
{
    partial class TaskUC
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
            gbAddBook = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            listBox1 = new ListBox();
            btnAddTask = new Button();
            label3 = new Label();
            txtFirstName = new TextBox();
            label9 = new Label();
            panelUpdate = new Panel();
            lblUpdateemployee = new Label();
            groupBox1 = new GroupBox();
            checkedListBox2 = new CheckedListBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            listBox2 = new ListBox();
            btnUpdateTask = new Button();
            label11 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            comboBox3 = new ComboBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            comboBox5 = new ComboBox();
            label17 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            listBoxTasks = new ListBox();
            btnRemoveTask = new Button();
            groupBox4 = new GroupBox();
            gbAddBook.SuspendLayout();
            panelUpdate.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // gbAddBook
            // 
            gbAddBook.BackColor = Color.White;
            gbAddBook.Controls.Add(checkedListBox1);
            gbAddBook.Controls.Add(label4);
            gbAddBook.Controls.Add(comboBox1);
            gbAddBook.Controls.Add(label10);
            gbAddBook.Controls.Add(dateTimePicker2);
            gbAddBook.Controls.Add(label5);
            gbAddBook.Controls.Add(radioButton2);
            gbAddBook.Controls.Add(radioButton1);
            gbAddBook.Controls.Add(label2);
            gbAddBook.Controls.Add(listBox1);
            gbAddBook.Controls.Add(btnAddTask);
            gbAddBook.Controls.Add(label3);
            gbAddBook.Controls.Add(txtFirstName);
            gbAddBook.Controls.Add(label9);
            gbAddBook.Location = new Point(3, 12);
            gbAddBook.Name = "gbAddBook";
            gbAddBook.Size = new Size(525, 939);
            gbAddBook.TabIndex = 1;
            gbAddBook.TabStop = false;
            gbAddBook.Text = "Add Task";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            checkedListBox1.Location = new Point(204, 612);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(247, 158);
            checkedListBox1.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 612);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 50;
            label4.Text = "Select days:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 336);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 28);
            comboBox1.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 344);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 47;
            label10.Text = "Area:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(138, 421);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(135, 27);
            dateTimePicker2.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 426);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 45;
            label5.Text = "Time:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(345, 513);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 24);
            radioButton2.TabIndex = 44;
            radioButton2.TabStop = true;
            radioButton2.Text = "Custom";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(178, 513);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 24);
            radioButton1.TabIndex = 43;
            radioButton1.TabStop = true;
            radioButton1.Text = "Daily";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 517);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 42;
            label2.Text = "Frequency:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(138, 142);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(287, 144);
            listBox1.TabIndex = 40;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.OldLace;
            btnAddTask.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnAddTask.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnAddTask.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.ForeColor = Color.DarkGreen;
            btnAddTask.Location = new Point(108, 893);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(201, 31);
            btnAddTask.TabIndex = 39;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 142);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 29;
            label3.Text = "Description:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(138, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(239, 27);
            txtFirstName.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 61);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 25;
            label9.Text = "Task:";
            // 
            // panelUpdate
            // 
            panelUpdate.BackColor = Color.DarkGreen;
            panelUpdate.Controls.Add(lblUpdateemployee);
            panelUpdate.Location = new Point(3, 3);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(525, 28);
            panelUpdate.TabIndex = 15;
            // 
            // lblUpdateemployee
            // 
            lblUpdateemployee.AutoSize = true;
            lblUpdateemployee.BackColor = Color.DarkGreen;
            lblUpdateemployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblUpdateemployee.ForeColor = Color.White;
            lblUpdateemployee.Location = new Point(6, 0);
            lblUpdateemployee.Name = "lblUpdateemployee";
            lblUpdateemployee.Size = new Size(84, 23);
            lblUpdateemployee.TabIndex = 0;
            lblUpdateemployee.Text = "Add Task";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(598, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1386, 493);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Task";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            checkedListBox2.Location = new Point(532, 69);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(247, 158);
            checkedListBox2.TabIndex = 51;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(113, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(253, 28);
            comboBox2.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 222);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 47;
            label6.Text = "Area:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(100, 294);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 27);
            dateTimePicker1.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 299);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 45;
            label7.Text = "Time:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(113, 43);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(287, 144);
            listBox2.TabIndex = 40;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.BackColor = Color.OldLace;
            btnUpdateTask.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnUpdateTask.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnUpdateTask.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateTask.ForeColor = Color.DarkGreen;
            btnUpdateTask.Location = new Point(360, 323);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(201, 31);
            btnUpdateTask.TabIndex = 39;
            btnUpdateTask.Text = "Update";
            btnUpdateTask.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 43);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 29;
            label11.Text = "Description:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 61);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 25;
            label12.Text = "Select task:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(598, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 28);
            panel1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "Update Task";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(138, 53);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(277, 28);
            comboBox3.TabIndex = 1;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(615, 23);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(64, 24);
            radioButton3.TabIndex = 52;
            radioButton3.TabStop = true;
            radioButton3.Text = "Daily";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(699, 21);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(80, 24);
            radioButton4.TabIndex = 53;
            radioButton4.TabStop = true;
            radioButton4.Text = "Custom";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(listBox2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(btnUpdateTask);
            groupBox2.Controls.Add(checkedListBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(15, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(839, 368);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(503, 23);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 54;
            label8.Text = "Frequency:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(btnRemoveTask);
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(comboBox5);
            groupBox3.Controls.Add(label17);
            groupBox3.Location = new Point(598, 514);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(856, 437);
            groupBox3.TabIndex = 53;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Task";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(153, 45);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(277, 28);
            comboBox5.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 53);
            label17.Name = "label17";
            label17.Size = new Size(82, 20);
            label17.TabIndex = 25;
            label17.Text = "Select task:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label13);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 28);
            panel2.TabIndex = 53;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkGreen;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.White;
            label13.Location = new Point(6, 0);
            label13.Name = "label13";
            label13.Size = new Size(109, 23);
            label13.TabIndex = 0;
            label13.Text = "Update Task";
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.Location = new Point(18, 27);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(731, 244);
            listBoxTasks.TabIndex = 54;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.BackColor = Color.OldLace;
            btnRemoveTask.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnRemoveTask.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnRemoveTask.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveTask.ForeColor = Color.DarkGreen;
            btnRemoveTask.Location = new Point(357, 391);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(201, 31);
            btnRemoveTask.TabIndex = 55;
            btnRemoveTask.Text = "Remove";
            btnRemoveTask.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBoxTasks);
            groupBox4.Location = new Point(45, 83);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(765, 286);
            groupBox4.TabIndex = 56;
            groupBox4.TabStop = false;
            groupBox4.Text = "Task details";
            // 
            // TaskUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(panelUpdate);
            Controls.Add(gbAddBook);
            Location = new Point(140, 40);
            Name = "TaskUC";
            Size = new Size(1452, 983);
            gbAddBook.ResumeLayout(false);
            gbAddBook.PerformLayout();
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAddBook;
        private Button btnAddTask;
        private Label label3;
        private TextBox txtFirstName;
        private Label label9;
        private ListBox listBox1;
        private Panel panelUpdate;
        private Label lblUpdateemployee;
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private CheckedListBox checkedListBox2;
        private ComboBox comboBox2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ListBox listBox2;
        private Button btnUpdateTask;
        private Label label11;
        private Label label12;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label8;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private ComboBox comboBox3;
        private GroupBox groupBox3;
        private ComboBox comboBox5;
        private Label label17;
        private ListBox listBoxTasks;
        private Panel panel2;
        private Label label13;
        private GroupBox groupBox4;
        private Button btnRemoveTask;
    }
}
